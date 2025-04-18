namespace PresentationLayer
{
    partial class Giaodienmangve
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
            components = new System.ComponentModel.Container();
            panel1 = new Panel();
            btnBack = new Button();
            label1 = new Label();
            panel2 = new Panel();
            txbSearch = new TextBox();
            panel3 = new Panel();
            panel7 = new Panel();
            panel6 = new Panel();
            listView1 = new ListView();
            panel4 = new Panel();
            panel5 = new Panel();
            label2 = new Label();
            button1 = new Button();
            panel8 = new Panel();
            numericUpDown1 = new NumericUpDown();
            button2 = new Button();
            btn_Thanhtoan = new Button();
            lv_Menu = new ListView();
            imageList1 = new ImageList(components);
            btn_search = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnBack);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(960, 59);
            panel1.TabIndex = 0;
            // 
            // btnBack
            // 
            btnBack.Location = new Point(8, 15);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(94, 29);
            btnBack.TabIndex = 1;
            btnBack.Text = "Back";
            btnBack.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(403, 18);
            label1.Name = "label1";
            label1.Size = new Size(125, 21);
            label1.TabIndex = 0;
            label1.Text = "Bán mang về";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(btn_search);
            panel2.Controls.Add(txbSearch);
            panel2.Location = new Point(6, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(178, 469);
            panel2.TabIndex = 1;
            // 
            // txbSearch
            // 
            txbSearch.Location = new Point(34, 3);
            txbSearch.Name = "txbSearch";
            txbSearch.Size = new Size(141, 27);
            txbSearch.TabIndex = 0;
            txbSearch.Text = "Tìm kiếm";
            // 
            // panel3
            // 
            panel3.Controls.Add(panel7);
            panel3.Controls.Add(panel6);
            panel3.Controls.Add(listView1);
            panel3.Location = new Point(744, 118);
            panel3.Name = "panel3";
            panel3.Size = new Size(221, 339);
            panel3.TabIndex = 2;
            // 
            // panel7
            // 
            panel7.Location = new Point(3, 345);
            panel7.Name = "panel7";
            panel7.Size = new Size(208, 41);
            panel7.TabIndex = 5;
            // 
            // panel6
            // 
            panel6.Location = new Point(0, 345);
            panel6.Name = "panel6";
            panel6.Size = new Size(211, 41);
            panel6.TabIndex = 5;
            // 
            // listView1
            // 
            listView1.Location = new Point(3, 3);
            listView1.Name = "listView1";
            listView1.Size = new Size(215, 333);
            listView1.TabIndex = 0;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(lv_Menu);
            panel4.Location = new Point(190, 67);
            panel4.Name = "panel4";
            panel4.Size = new Size(548, 469);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(label2);
            panel5.Controls.Add(button1);
            panel5.Location = new Point(744, 68);
            panel5.Name = "panel5";
            panel5.Size = new Size(220, 47);
            panel5.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(68, 13);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 1;
            label2.Text = "Giỏ hàng";
            // 
            // button1
            // 
            button1.Location = new Point(167, 9);
            button1.Name = "button1";
            button1.Size = new Size(44, 29);
            button1.TabIndex = 0;
            button1.Text = "Xóa";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel8
            // 
            panel8.Controls.Add(numericUpDown1);
            panel8.Controls.Add(button2);
            panel8.Controls.Add(btn_Thanhtoan);
            panel8.Location = new Point(744, 463);
            panel8.Name = "panel8";
            panel8.Size = new Size(221, 73);
            panel8.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(10, 40);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(108, 27);
            numericUpDown1.TabIndex = 2;
            numericUpDown1.TextAlign = HorizontalAlignment.Center;
            // 
            // button2
            // 
            button2.Location = new Point(6, 3);
            button2.Name = "button2";
            button2.Size = new Size(112, 35);
            button2.TabIndex = 1;
            button2.Text = "Giảm giá";
            button2.TextAlign = ContentAlignment.TopCenter;
            button2.UseVisualStyleBackColor = true;
            // 
            // btn_Thanhtoan
            // 
            btn_Thanhtoan.Location = new Point(119, 3);
            btn_Thanhtoan.Name = "btn_Thanhtoan";
            btn_Thanhtoan.Size = new Size(99, 61);
            btn_Thanhtoan.TabIndex = 0;
            btn_Thanhtoan.Text = "Thanh toán";
            btn_Thanhtoan.UseVisualStyleBackColor = true;
            // 
            // lv_Menu
            // 
            lv_Menu.Location = new Point(6, 6);
            lv_Menu.Name = "lv_Menu";
            lv_Menu.Size = new Size(539, 457);
            lv_Menu.TabIndex = 0;
            lv_Menu.UseCompatibleStateImageBehavior = false;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // btn_search
            // 
            btn_search.Image = Properties.Resources.ic_search;
            btn_search.Location = new Point(1, 2);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(34, 31);
            btn_search.TabIndex = 1;
            btn_search.UseVisualStyleBackColor = true;
            // 
            // Giaodienmangve
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(977, 542);
            Controls.Add(panel8);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Giaodienmangve";
            Text = "Bán mang về";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnBack;
        private Panel panel3;
        private Panel panel4;
        private TextBox txbSearch;
        private ListView listView1;
        private Panel panel7;
        private Panel panel6;
        private Panel panel8;
        private Panel panel5;
        private Label label2;
        private Button button1;
        private Button btn_Thanhtoan;
        private Button button2;
        private NumericUpDown numericUpDown1;
        private ListView lv_Menu;
        private ImageList imageList1;
        private Button btn_search;
    }
}