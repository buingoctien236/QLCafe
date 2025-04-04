using BusinessLogicLayer;
using DataAccessLayer;
using MySql.Data.MySqlClient;
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
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {   // on click hien danh sach user
            try
            {
                using (MySqlConnection conn = KetNoiDatabase.Connection())
                {
                    conn.Open();
                    string query = "SELECT * FROM user";
                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);


                    string result = "Danh sách người dùng:\n";
                    foreach (DataRow row in dt.Rows)
                    {
                        result += $"ID: {row["user_id"]}, Username: {row["username"]}\n";
                    }

                    MessageBox.Show(result, "Dữ liệu Users", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (dt.Rows.Count == 0)
                    {
                        MessageBox.Show("Không có dữ liệu trong bảng users!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi kết nối: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(so1.Text);
            double b = Convert.ToDouble(so2.Text); 
            double tong = TinhTong.Tong(a, b); // Ham TinhTong trong BusinessLogicLayer
            ketqua.Text = tong.ToString();
        }
    }
}
