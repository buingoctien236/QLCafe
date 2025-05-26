
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;
using DataAccessLayer;

namespace PresentationLayer
{
    public partial class fTableManager : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount.Type); }
        }




        public fTableManager(Account acc)
        {
            InitializeComponent();
            this.LoginAccount = acc; // truyen tai khoan vao
            LoadTable();
            LoadCategory();
            LoadComboboxTable(cbSwitchTable);

        }
        void ChangeAccount(int type)
        {
            adminToolStripMenuItem.Enabled = type == 1; // kiem tra quyen admin
            thôngTinTàiKhoảnToolStripMenuItem.Text += "(" + loginAccount.DisplayName + ")";
        }



        void LoadTable()
        {
            flpTable.Controls.Clear();
            List<Table> tableList = TableDAL.Instance.LoadTableList();
            foreach (Table item in tableList)
            {
                Button btn = new Button() { Width = 100, Height = 80 };
                btn.Text = item.Name + Environment.NewLine + item.Status;
                btn.Click += btn_Click;
                btn.Tag = item;



                switch (item.Status)
                {
                    case "Trống":
                        btn.BackColor = Color.Aqua;
                        break;
                    default:
                        btn.BackColor = Color.Pink;
                        break;
                }
                flpTable.Controls.Add(btn);
            }
        }
        void ShowBill(int id)
        {
            lsvBill.Items.Clear();
            List<Menu> listBillInfo = MenuDAL.Instance.GetListMenuByTable(id);
            float totalPrice = 0;
            foreach (Menu item in listBillInfo)
            {
                ListViewItem listView1 = new ListViewItem(item.FoodName.ToString());
                listView1.SubItems.Add(item.Count.ToString());
                listView1.SubItems.Add(item.Price.ToString());
                listView1.SubItems.Add(item.TotalPrice.ToString());
                totalPrice += item.TotalPrice;
                lsvBill.Items.Add(listView1);
            }
            txtTotalPrice.Text = totalPrice.ToString("c");


        }


        void LoadCategory()
        {
            List<Category> listCategory = CategoryDAL.Instance.GetListCategory();
            cbCategory.DataSource = listCategory;
            cbCategory.DisplayMember = "Name";


        }


        void LoadFoodListByCategory(int id)
        {
            List<Food> listFood = FoodDAL.Instance.GetFoodByCategory(id);
            cbFood.DataSource = listFood;
            cbFood.DisplayMember = "Name";

        }



        void btn_Click(object sender, EventArgs e)
        {
            int tableID = ((sender as Button).Tag as Table).ID;
            lsvBill.Tag = (sender as Button).Tag;
            ShowBill(tableID);
        }


        void LoadComboboxTable(ComboBox cb)
        {
            cb.DataSource = TableDAL.Instance.LoadTableList();
            cb.DisplayMember = "Name";

        }





        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table; //lay ra table hien tai


            int idBill = BillDAL.Instance.GetUnckeckBillIdByTableID(table.ID);
            int foodID = (cbFood.SelectedItem as Food).ID;
            int count = (int)nmFoodCount.Value;


            if (idBill == -1) //ko co bill thi them moi
            {
                BillDAL.Instance.InsertBill(table.ID);
                BillInfoDAL.Instance.InsertBillInfo(BillDAL.Instance.GetMaxIDBill(), foodID, count);
            }
            else
            {
                BillInfoDAL.Instance.InsertBillInfo(idBill, foodID, count);
            }
            ShowBill(table.ID);
            LoadTable();
        }


        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thôngTinCáNhânToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAccountProfile f = new fAccountProfile(loginAccount);
            f.ShowDialog();
        }

        private void adminToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fAdmin f = new fAdmin();
            f.ShowDialog();

        }

        private void tableList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void lsvBill_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id = 0;

            ComboBox cb = sender as ComboBox;
            if (cb.SelectedItem == null)
                return;
            Category selected = cb.SelectedItem as Category;
            id = selected.ID;
            LoadFoodListByCategory(id);
        }

        private void btnCheckout_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table; //lay ra table hien tai
            int idBill = BillDAL.Instance.GetUnckeckBillIdByTableID(table.ID);
            ShowBillDetailText(table.ID); // ShowBill
            float totalPrice = float.Parse(txtTotalPrice.Text.Split(',')[0]);
            {

                    BillDAL.Instance.CheckOut(idBill, totalPrice);
                    ShowBill(table.ID);
                    LoadTable();

            }


        }

        private void btnSwichTable_Click(object sender, EventArgs e)
        {
            Table table = lsvBill.Tag as Table;
            int id1 = (lsvBill.Tag as Table).ID;
            int id2 = (cbSwitchTable.SelectedItem as Table).ID;
            string name1 = (lsvBill.Tag as Table).Name;
            string name2 = (cbSwitchTable.SelectedItem as Table).Name;
            string message = string.Format("Bạn có muốn chuyển bàn {0} sang bàn {1}?", name1, name2);
            if (MessageBox.Show(message, "Thông báo", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                TableDAL.Instance.SwitchTable(id1, id2);
                ShowBill(table.ID);
                LoadTable();
            }
        }

        private void txtTotalPrice_TextChanged(object sender, EventArgs e)
        {

        }







        // Hiển thị hóa đơn
        private void ShowBillDetailText(int tableId)
        {
            List<Menu> listBillInfo = MenuDAL.Instance.GetListMenuByTable(tableId);
            StringBuilder billContent = new StringBuilder();
            billContent.AppendLine($"                                                Cafe Thắng Tiến                  ");
            billContent.AppendLine($" ");
            billContent.AppendLine($"=============== HÓA ĐƠN THANH TOÁN===============");
            billContent.AppendLine($" ");
            billContent.AppendLine($"                       Địa chỉ : 55 Giải Phóng, Quận Hai Bà Trưng, Hà Nội");
            billContent.AppendLine($"                                        Pass Wifi :19001008");
            billContent.AppendLine($" ");
            billContent.AppendLine($" ");
            billContent.AppendLine($"Bàn phục vụ :  {(lsvBill.Tag as Table).Name}");
            billContent.AppendLine($" ");
            billContent.AppendLine($" ");
            billContent.AppendLine("--------------------------------------------------------------------------------------------");
            billContent.AppendLine($"Thành tiền                Số lượng                Tên món ");
            billContent.AppendLine("--------------------------------------------------------------------------------------------");

            float totalPrice = 0;

            foreach (Menu item in listBillInfo)
            {
                billContent.AppendLine($"{item.TotalPrice.ToString()}   VNĐ                      {item.Count}                     {item.FoodName}");
                totalPrice += item.TotalPrice;
            }

            billContent.AppendLine("--------------------------------------------------------------------------------------------");
            billContent.AppendLine($"TỔNG CỘNG: {totalPrice.ToString("")}     VNĐ ");
            billContent.AppendLine("--------------------------------------------------------------------------------------------");
            billContent.AppendLine($" ");
            billContent.AppendLine($" ");
            billContent.AppendLine($"Khách hàng có phản hồi về thái độ và dịch vụ xin vui lòng liên hệ qua tổng đài :0565178543 .Để được ship hàng tận nơi ấn phím 1");
            // them tat ca vao roi show
            MessageBox.Show(billContent.ToString(), "Hóa đơn thanh toán", MessageBoxButtons.OK);
        }

    }
}
