using BusinessLogicLayer;
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

namespace PresentationLayer
{
    public partial class fAccountProfile : Form
    {
        private Account loginAccount;
        public Account LoginAccount
        {
            get { return loginAccount; }
            set { loginAccount = value; ChangeAccount(loginAccount); }
        }

        public fAccountProfile(Account acc)
        {
            InitializeComponent();
            LoginAccount = acc;
        }
        void ChangeAccount(Account acc)
        {
            txbUserName.Text = loginAccount.UserName;
            txtDisplayName.Text = loginAccount.DisplayName;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        void UpdateAccount()
        {
            string displayName = txtDisplayName.Text;
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            string newPassWord = txbNewPassWord.Text;
            string reEnterPassWord = txbReEnterPassWord.Text;


            if (!newPassWord.Equals(reEnterPassWord))
            {
                MessageBox.Show("Mật khẩu không khớp");
                return;
            }
            else
            {
                if (AccountDAL.Instance.UpdateAccount(userName, displayName, passWord, newPassWord))
                {
                    MessageBox.Show("Cập nhật thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại");
                }
            }

        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateAccount();

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
