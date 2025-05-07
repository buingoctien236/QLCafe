using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
            loadTable();
        }

        void loadTable()
        {
            List<Table> tables = TableDAL.Instance.LoadTableList();
            foreach (Table item in tables)
            {
                Button btn = new Button()
                {
                    Width = 150,
                    Height = 120,
                    Text = item.Ten_ban,
                    BackColor = item.Tinh_trang == 1 ? Color.Red : Color.Green,
                    Tag = item
                };


                btn.Click += btn_ClickTable;

                flayer1.Controls.Add(btn);
            }
        }
        void ShowInvoice(int id)
        {
            listView2.Items.Clear();

            List<Itemtb> invoiceitemList = ItemtbDAL.Instance.GetListItemByTable(id);
            float totalprice = 0;//tong sau cung
            foreach (Itemtb item in invoiceitemList)
            {
                ListViewItem listView1 = new ListViewItem(item.Food_name.ToString());
                listView1.SubItems.Add(item.Count.ToString());
                listView1.SubItems.Add(item.Price.ToString());
                listView1.SubItems.Add(item.Total_price.ToString());
                listView2.Items.Add(listView1);
                totalprice += item.Total_price;

            }
            txttotalprice.Text = totalprice.ToString();
        }
        private void btn_ClickTable(object sender, EventArgs e)
        {
            int deskId = ((sender as Button).Tag as Table).Desk_id;
            ShowInvoice(deskId);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giaodienmangve g = new Giaodienmangve();
            g.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ftest t = new ftest();
            t.ShowDialog();
        }

        private void flayer1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void listView2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            chamcong c = new chamcong();
            c.ShowDialog();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
