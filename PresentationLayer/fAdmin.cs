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


namespace PresentationLayer
{
    public partial class fAdmin : Form
    {
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();

        }



        //void LoadFoodList()
        //{
        //    string query = "seclect * from db.Food";
        //    dtgvFood.DataSource = DataProvider.Instance.ExecuteQuery(query);
        //}




        void LoadAccountList()
        {

            string query = "exec dbo.GetAccountByUserName @userName";
            
            dtgvAccount.DataSource = DataProvider.Instance.ExecuteQuery(query, new object[]{"tien"});
        }

      
    }
}
