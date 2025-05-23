﻿using DataAccessLayer;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }















        private void btnLogin_Click(object sender, EventArgs e)
        {   string userName = txtUserName.Text;
            string passWord = txtPassWord.Text;
            if (CheckLogin(userName,passWord))
            {   Account loginAccount = AccountDAL.Instance.GetAccountByUserName(userName);
                fTableManager f = new fTableManager(loginAccount);
                this.Hide();
                f.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Sai thông tin tài khoản");
                return;
            }
            

        }
        bool CheckLogin(string userName , string passWord)
        {
            return AccountDAL.Instance.Login(userName,passWord);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) != DialogResult.OK)
            {
                e.Cancel= true;
            }
        }


    }
}
