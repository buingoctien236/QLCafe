using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using Microsoft.Data.SqlClient;
using BusinessLogicLayer;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PresentationLayer
{
    public partial class fAdmin : Form
    {
        BindingSource foodList = new BindingSource();
        BindingSource accountList = new BindingSource();
        BindingSource tableList = new BindingSource();
        BindingSource categoryList = new BindingSource();

        public fAdmin()
        {
            InitializeComponent();
            Load();
        }

        void Load()
        {
            dtgvAccount.DataSource = accountList; // lay acc cua admin
            AddAccountBinding();
            LoadAccountList();

            dtgvFood.DataSource = foodList;
            LoadListFood();
            AddFoodBinding();

            dtgvTable.DataSource = tableList;
            LoadListTable();
            AddTableBinding();

            dtgvCategory.DataSource = categoryList;
            LoadListCategory();
            AddCategoryBinding();

            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);
            LoadCatagoryIntoCombobox(cbFoodCategory);


        }






        void LoadListBillByDate(DateTime checkIn, DateTime checkOut)
        {
            DataTable data = BillDAL.Instance.GetBillListByDate(checkIn, checkOut);


            //cong tong doanh thu
            dtgvBill.DataSource = data;

            float totalRevenue = 0;

            foreach (DataRow row in data.Rows)
            {
                if (row["Tổng tiền"] != DBNull.Value)
                {
                    totalRevenue += Convert.ToSingle(row["Tổng tiền"]);
                }
            }

            txtDoanhThu.Text = totalRevenue.ToString("N0") + " VNĐ";
        }




        private void btnViewBill_Click(object sender, EventArgs e)
        {
            LoadListBillByDate(dtpkFromDate.Value, dtpkToDate.Value);

        }

        //---------------------------CRUD Food------------------
        void LoadListFood()
        {

            foodList.DataSource = FoodDAL.Instance.GetListFood();
        }


        // Admin / Thuc an / -------------click vao thi hien thi-------------
        void AddFoodBinding()
        {                                                                                  //true cho phep ép kiểu , never không thay đổi 2 luồng
            txbFoodName.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "Name", true, DataSourceUpdateMode.Never));
            //text thay doi theo name trong datasource

            txbFoodID.DataBindings.Add(new Binding("Text", dtgvFood.DataSource, "ID", true, DataSourceUpdateMode.Never));
            nmFoodPrice.DataBindings.Add(new Binding("Value", dtgvFood.DataSource, "Price", true, DataSourceUpdateMode.Never));
        }


        void LoadCatagoryIntoCombobox(ComboBox cb)
        {
            cb.DataSource = CategoryDAL.Instance.GetListCategory();
            cb.DisplayMember = "Name";

        }

        // Admin / Thuc an / button ----------Xem------------
        private void button3_Click(object sender, EventArgs e)
        {
            LoadListFood();
        }

        private void txbFoodID_TextChanged(object sender, EventArgs e)
        {


            //lay cac o cua dong dau, lay dong chua o , lay o IDCategory
            object value = dtgvFood.SelectedCells[0].OwningRow.Cells["CategoryID"].Value;
            //kiem tra xem có null k -- tranh loi luc search
            if (value == null || value == DBNull.Value)
                return;

            int id = Convert.ToInt32(value);

            Category category = CategoryDAL.Instance.GetCategoryByID(id);
            cbFoodCategory.SelectedItem = cbFoodCategory;
            int index = -1;
            int i = 0;
            foreach (Category item in cbFoodCategory.Items)
            {
                if (item.ID == category.ID)
                {
                    index = i;
                    break;
                }
                i++;
            }
            cbFoodCategory.SelectedIndex = index;


        }

        private void btnAddFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            if (FoodDAL.Instance.InsertFood(name, categoryID, price))
            {   // true
                MessageBox.Show("Thêm món thành công");
                LoadListFood();
            }
            else
            {   // false
                MessageBox.Show("Thêm món thất bại");
            }
        }

        private void btnEditFood_Click(object sender, EventArgs e)
        {
            string name = txbFoodName.Text;
            int categoryID = (cbFoodCategory.SelectedItem as Category).ID;
            float price = (float)nmFoodPrice.Value;
            int id = Convert.ToInt32(txbFoodID.Text);
            if (FoodDAL.Instance.UpdateFood(id, name, categoryID, price))
            {
                MessageBox.Show("Sửa món thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Sửa món thất bại");
            }

        }

        private void btnDeleteFood_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txbFoodID.Text);
            if (FoodDAL.Instance.DeleteFood(id))
            {
                MessageBox.Show("Xóa món thành công");
                LoadListFood();
            }
            else
            {
                MessageBox.Show("Xóa món thất bại");
            }
        }

        List<Food> SearchFoodByName(string name)
        {
            List<Food> listFood = FoodDAL.Instance.SearchFoodByName(name);

            return listFood;
        }

        private void btnSearchFood_Click(object sender, EventArgs e)
        {
            foodList.DataSource = SearchFoodByName(txbSearchFoodName.Text);
        }

        //----------------------------------------






        //------------CRUD Account-----------------


        void AddAccountBinding()
        {
            txtUserName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "UserName", true, DataSourceUpdateMode.Never));
            txtDisplayName.DataBindings.Add(new Binding("Text", dtgvAccount.DataSource, "DisplayName", true, DataSourceUpdateMode.Never));
            nmAccountType.DataBindings.Add(new Binding("Value", dtgvAccount.DataSource, "Type", true, DataSourceUpdateMode.Never));
        }


        //--Xem--
        void LoadAccountList()
        {
            accountList.DataSource = AccountDAL.Instance.GetListAccount();
        }
        private void btnShowAccount_Click(object sender, EventArgs e)
        {
            LoadAccountList();
        }



        //--Them--
        private void btnAddAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)nmAccountType.Value;
            AddAcount(userName, displayName, type);

        }
        void AddAcount(string userName, string displayName, int type)
        {
            if (AccountDAL.Instance.CheckUserNameExists(userName))
            {
                MessageBox.Show("Tên tài khoản đã tồn tại, vui lòng chọn tên khác.");
                return;
            }

            if (AccountDAL.Instance.InsertAccount(userName, displayName, type))
            {
                MessageBox.Show("Thêm tài khoản thành công");
            }
            else
            {
                MessageBox.Show("Thêm tài khoản thất bại");
            }
            LoadAccountList();

        }
        //--Sua--

        void EditAcount(string userName, string displayName, int type)
        {
            if (AccountDAL.Instance.UpdateAccount(userName, displayName, type))
            {
                MessageBox.Show("Cập nhật thành công");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Cập nhật thất bại");
            }
            LoadAccountList();
        }

        private void btnEditAccout_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            string displayName = txtDisplayName.Text;
            int type = (int)nmAccountType.Value;
            EditAcount(userName, displayName, type);
        }

        //--Xoa--

        void DeleteAcount(string userName)
        {
            if (AccountDAL.Instance.DeleteAccount(userName))
            {
                MessageBox.Show("Xóa tài khoản thành công");
                LoadAccountList();
            }
            else
            {
                MessageBox.Show("Xóa tài khoản thất bại");
            }
            LoadAccountList();
        }

        private void btnDeletwAccount_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text;
            DeleteAcount(userName);
        }





        //------------------------------------------------------------

        //------------CRUD Table-----------------

        //Binding
        void AddTableBinding()
        {
            txbIdTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txtNameTable.DataBindings.Add(new Binding("Text", dtgvTable.DataSource, "Name", true, DataSourceUpdateMode.Never));


        }


        void LoadListTable()
        {
            tableList.DataSource = TableDAL.Instance.LoadTableList();
        }


        //--Xem--

        private void btnShowTable_Click(object sender, EventArgs e)
        {
            LoadListTable();
        }

        //--Them--

        void AddTable(string name)
        {
            if (TableDAL.Instance.InsertTable(name))
            {
                MessageBox.Show("Thêm bàn thành công");
            }
            else
            {
                MessageBox.Show("Thêm bàn thất bại");
            }
            LoadListTable();
        }

        private void btnAddTable_Click_1(object sender, EventArgs e)
        {
            string name = txtNameTable.Text;

            AddTable(name);

        }

        // Sua
        void EditTable(string name, int id)
        {
            if (TableDAL.Instance.UpdateTable(id, name))
            {
                MessageBox.Show("Cập nhật bàn thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật bàn thất bại");
            }
            LoadListTable();
        }
        private void btnEditTable_Click_1(object sender, EventArgs e)
        {
            string name = txtNameTable.Text;
            int id = Convert.ToInt32(txbIdTable.Text);
            EditTable(name, id);
        }
        //--Xoa--
        void DeleteTable(int id)
        {
            if (TableDAL.Instance.DeleteTable(id))
            {
                MessageBox.Show("Xóa bàn thành công");
            }
            else
            {
                MessageBox.Show("Xóa bàn thất bại");
            }
            LoadListTable();
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            string name = txtNameTable.Text;
            int id = Convert.ToInt32(txbIdTable.Text);
            DeleteTable(id);
        }







        //-----------------------------------------



        //------------CRUD Danh muc--------------------

        void AddCategoryBinding()
        {
            txbCategoryID.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "ID", true, DataSourceUpdateMode.Never));
            txbCategoryName.DataBindings.Add(new Binding("Text", dtgvCategory.DataSource, "Name", true, DataSourceUpdateMode.Never));


        }


        void LoadListCategory()
        {
            categoryList.DataSource = CategoryDAL.Instance.GetListCategory();
        }



        //--Xem--


        private void btnShowCategory_Click(object sender, EventArgs e)
        {
            LoadListCategory();
        }


        //--Them--

        void AddCategory(string name)
        {
            if (CategoryDAL.Instance.InsertCategory(name))
            {
                MessageBox.Show("Thêm danh muc thành công");
            }
            else
            {
                MessageBox.Show("Thêm danh muc thất bại");
            }
            LoadListCategory();
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            AddCategory(name);
        }

        // Sua
        void EditCategory(string name, int id)
        {
            if (CategoryDAL.Instance.UpdateCategory(id, name))
            {
                MessageBox.Show("Cập nhật danh muc thành công");
            }
            else
            {
                MessageBox.Show("Cập nhật danh muc thất bại");
            }
            LoadListCategory();
        }

        private void btnEditCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);
            EditCategory(name, id);


        }

        //--Xoa--
        void DeleteCategory(int id)
        {
            if (CategoryDAL.Instance.DeleteCategory(id))
            {
                MessageBox.Show("Xóa danh muc thành công");
            }
            else
            {
                MessageBox.Show("Xóa danh muc thất bại");
            }
            LoadListCategory();
        }

        private void btnDeleteCategory_Click(object sender, EventArgs e)
        {
            string name = txbCategoryName.Text;
            int id = Convert.ToInt32(txbCategoryID.Text);
            DeleteCategory(id);
        }
    }

}
