namespace PresentationLayer
{
    partial class Giaodienchinh
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            btn_mangve = new Button();
            panel3 = new Panel();
            btn_taicho = new Button();
            panel4 = new Panel();
            btn_nhahang = new Button();
            btn_chamcong = new Button();
            btn_khuvuc = new Button();
            btn_banhang = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(20, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1018, 71);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(410, 17);
            label1.Name = "label1";
            label1.Size = new Size(174, 35);
            label1.TabIndex = 0;
            label1.Text = "Nguồn đơn";
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_mangve);
            panel2.Location = new Point(73, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(374, 250);
            panel2.TabIndex = 1;
            // 
            // btn_mangve
            // 
            btn_mangve.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_mangve.Location = new Point(3, 3);
            btn_mangve.Name = "btn_mangve";
            btn_mangve.Size = new Size(368, 244);
            btn_mangve.TabIndex = 0;
            btn_mangve.Text = "Mang về";
            btn_mangve.UseVisualStyleBackColor = true;
            btn_mangve.Click += btn_mangve_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btn_taicho);
            panel3.Location = new Point(587, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(374, 250);
            panel3.TabIndex = 2;
            // 
            // btn_taicho
            // 
            btn_taicho.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_taicho.Location = new Point(3, 3);
            btn_taicho.Name = "btn_taicho";
            btn_taicho.Size = new Size(368, 244);
            btn_taicho.TabIndex = 0;
            btn_taicho.Text = "Tại chỗ";
            btn_taicho.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            panel4.Controls.Add(btn_nhahang);
            panel4.Controls.Add(btn_chamcong);
            panel4.Controls.Add(btn_khuvuc);
            panel4.Controls.Add(btn_banhang);
            panel4.Location = new Point(20, 460);
            panel4.Name = "panel4";
            panel4.Size = new Size(1018, 52);
            panel4.TabIndex = 3;
            // 
            // btn_nhahang
            // 
            btn_nhahang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_nhahang.ForeColor = Color.Black;
            btn_nhahang.Location = new Point(762, 3);
            btn_nhahang.Name = "btn_nhahang";
            btn_nhahang.Size = new Size(253, 46);
            btn_nhahang.TabIndex = 6;
            btn_nhahang.Text = "Nhà hàng";
            btn_nhahang.UseVisualStyleBackColor = true;
            // 
            // btn_chamcong
            // 
            btn_chamcong.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_chamcong.ForeColor = Color.Black;
            btn_chamcong.Location = new Point(514, 3);
            btn_chamcong.Name = "btn_chamcong";
            btn_chamcong.Size = new Size(251, 46);
            btn_chamcong.TabIndex = 5;
            btn_chamcong.Text = "Chấm công";
            btn_chamcong.UseVisualStyleBackColor = true;
            btn_chamcong.Click += btn_chamcong_Click;
            // 
            // btn_khuvuc
            // 
            btn_khuvuc.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_khuvuc.ForeColor = Color.Black;
            btn_khuvuc.Location = new Point(255, 3);
            btn_khuvuc.Name = "btn_khuvuc";
            btn_khuvuc.Size = new Size(258, 46);
            btn_khuvuc.TabIndex = 4;
            btn_khuvuc.Text = "Khu vực";
            btn_khuvuc.UseVisualStyleBackColor = true;
            // 
            // btn_banhang
            // 
            btn_banhang.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_banhang.ForeColor = Color.Black;
            btn_banhang.Location = new Point(3, 3);
            btn_banhang.Name = "btn_banhang";
            btn_banhang.Size = new Size(256, 46);
            btn_banhang.TabIndex = 3;
            btn_banhang.Text = "Bán hàng";
            btn_banhang.UseVisualStyleBackColor = true;
            // 
            // Giaodienchinh
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1050, 543);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            KeyPreview = true;
            Name = "Giaodienchinh";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Phần mềm quản lý quán cafe";
            Load += Giaodienchinh_Load;
            KeyUp += Giaodienchinh_KeyUp;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Button btn_mangve;
        private Button btn_taicho;
        private Button btn_nhahang;
        private Button btn_chamcong;
        private Button btn_khuvuc;
        private Button btn_banhang;
    }
}