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
    public partial class Giaodienchinh : Form
    {
        public Giaodienchinh()
        {
            InitializeComponent();
        }

        private void Giaodienchinh_Load(object sender, EventArgs e)
        {

        }

        private void btn_mangve_Click(object sender, EventArgs e)
        {
            Giaodienmangve f = new Giaodienmangve();
            this.Hide();
            f.ShowDialog();
            this.Show();
        }

        private bool bfullscreen = false;
        private void Giaodienchinh_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F11)
            {
                if (bfullscreen == false)
                {
                    this.FormBorderStyle = FormBorderStyle.None;
                    this.Left = 0;
                    this.Top = 0;
                    this.Bounds = Screen.PrimaryScreen.Bounds;
                    bfullscreen = true;
                }
                else
                {
                    this.FormBorderStyle = FormBorderStyle.Sizable;
                    bfullscreen = false;
                }
            }
        }

        private void btn_chamcong_Click(object sender, EventArgs e)
        {
            chamcong c = new chamcong();
            this.Hide();
            c.ShowDialog();
            this.Show();
        }
    }
}
