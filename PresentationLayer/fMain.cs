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
using DataAccessLayer;
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
                Button btn = new Button() { Width = TableDAL.TableWidth, Height = TableDAL.TableHeight };

                btn.Text = item.Ten_ban;
                if (item.Tinh_trang == 1)
                {
                    btn.BackColor = Color.Red;
                }
                else
                {
                    btn.BackColor = Color.Green;
                }


                flayer1.Controls.Add(btn);
            }
        }

       
    }
}
