using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class Giaodienmangve : Form
    {
        private Label lbtenban;

        public Giaodienmangve()
        {
            InitializeComponent();
            this.Load += new EventHandler(Giaodienmangve_Load); // goi dau tien

 
        }

        private void Giaodienmangve_Load(object sender, EventArgs e)
        {
            Table table = this.Tag as Table;
            LoadMenu();
        }

        void LoadMenu()
        {
            List<Menu> menus = MenuDAL.Instance.LoadMenuList();
            List<DrinkType> drinkTypes = DrinkTypeDAL.Instance.LoadDrinkTypes();
            string projectRoot = Directory.GetParent(Application.StartupPath).Parent.Parent.Parent.FullName;
            // tinh so luong loai_id
            var loaiIds = menus.Select(m => m.Loai_id).Distinct();


            foreach (var loaiId in loaiIds)
            {
                string moTa;
                var drinkType = drinkTypes.FirstOrDefault(dt => dt.Loai_id == loaiId);

                if (drinkType != null)
                {
                    moTa = drinkType.Mo_ta;
                }
                else
                {
                    moTa = "null";
                }

                var panelGroup = new FlowLayoutPanel
                {
                    FlowDirection = FlowDirection.TopDown,
                    AutoSize = true,
                    WrapContents = false,
                    Margin = new Padding(10)
                };

                var lblHeader = new Label
                {
                    Text = moTa,
                    Font = new Font("Arial", 12, FontStyle.Bold),
                    AutoSize = true,
                    Margin = new Padding(5)
                };
                panelGroup.Controls.Add(lblHeader);

                var flLoai = new FlowLayoutPanel
                {
                    AutoSize = true,
                    WrapContents = true,
                    Margin = new Padding(5),
                    FlowDirection = FlowDirection.LeftToRight
                };

                foreach (var item in menus.Where(m => m.Loai_id == loaiId.ToString()))
                {
                    var btn = new Button
                    {
                        Width = 150,
                        Height = 150,
                        Text = item.Ten_mon,
                        Image = Image.FromFile(Path.Combine(projectRoot, "imgs", Path.GetFileName(item.Hinh_anh))),
                        ImageAlign = ContentAlignment.MiddleCenter,
                        TextAlign = ContentAlignment.BottomCenter,
                        BackColor = item.Tinh_trang == "0" ? Color.Black : SystemColors.Control
                    };

                    var lblGiaBan = new Label
                    {
                        Text = item.Gia_ban.ToString("#,0") + "đ",
                        ForeColor = Color.White,
                        BackColor = Color.Red,
                        AutoSize = true,
                        Location = new Point(btn.Width - 55, 0)
                    };
                    btn.Controls.Add(lblGiaBan);

                    flLoai.Controls.Add(btn);
                }

                panelGroup.Controls.Add(flLoai);
                flmenu1.Controls.Add(panelGroup);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }

        private void btn_search_Click(object sender, EventArgs e) { }

        private void panel1_Paint(object sender, PaintEventArgs e) { }

        private void btnBack_Click(object sender, EventArgs e) { }

        private void pictureBox1_Click(object sender, EventArgs e) {

            this.Hide();
        
        
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e) { }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e) { }
    }
}
