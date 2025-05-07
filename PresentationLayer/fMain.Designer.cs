namespace PresentationLayer
{
    partial class fMain
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            tabPage2 = new TabPage();
            panel1 = new Panel();
            button4 = new Button();
            txttotalprice = new TextBox();
            label3 = new Label();
            listView2 = new ListView();
            tenMon = new ColumnHeader();
            soluong = new ColumnHeader();
            dongia = new ColumnHeader();
            thanhtien = new ColumnHeader();
            listView1 = new ListView();
            idFood = new ColumnHeader();
            count = new ColumnHeader();
            label2 = new Label();
            flayer1 = new FlowLayoutPanel();
            tabPage3 = new TabPage();
            button3 = new Button();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            panel1.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Alignment = TabAlignment.Bottom;
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Font = new Font("Times New Roman", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            tabControl1.ItemSize = new Size(245, 40);
            tabControl1.Location = new Point(0, 0);
            tabControl1.Margin = new Padding(0);
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1000, 460);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(button1);
            tabPage1.Controls.Add(button2);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 4);
            tabPage1.Margin = new Padding(0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(992, 412);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Bán hàng";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(176, 98);
            button1.Name = "button1";
            button1.Size = new Size(237, 183);
            button1.TabIndex = 4;
            button1.Text = "Mang về";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Times New Roman", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(566, 98);
            button2.Name = "button2";
            button2.Size = new Size(237, 183);
            button2.TabIndex = 3;
            button2.Text = "Tại chỗ";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.BackColor = Color.LightGray;
            label1.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(0, 0);
            label1.Margin = new Padding(0);
            label1.Name = "label1";
            label1.Size = new Size(980, 40);
            label1.TabIndex = 1;
            label1.Text = "Nguồn đơn";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Click += label1_Click;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(panel1);
            tabPage2.Controls.Add(listView2);
            tabPage2.Controls.Add(listView1);
            tabPage2.Controls.Add(label2);
            tabPage2.Controls.Add(flayer1);
            tabPage2.Location = new Point(4, 4);
            tabPage2.Margin = new Padding(0);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(992, 412);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Bàn";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(button4);
            panel1.Controls.Add(txttotalprice);
            panel1.Controls.Add(label3);
            panel1.Location = new Point(607, 363);
            panel1.Name = "panel1";
            panel1.Size = new Size(373, 46);
            panel1.TabIndex = 4;
            // 
            // button4
            // 
            button4.BackColor = Color.Navy;
            button4.FlatStyle = FlatStyle.Popup;
            button4.ForeColor = SystemColors.ButtonHighlight;
            button4.Location = new Point(270, 2);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.Size = new Size(103, 41);
            button4.TabIndex = 2;
            button4.Text = "Thanh toán";
            button4.UseVisualStyleBackColor = false;
            // 
            // txttotalprice
            // 
            txttotalprice.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txttotalprice.ForeColor = Color.Red;
            txttotalprice.Location = new Point(161, 18);
            txttotalprice.Name = "txttotalprice";
            txttotalprice.Size = new Size(71, 25);
            txttotalprice.TabIndex = 1;
            txttotalprice.Tag = "0";
            txttotalprice.Text = "0000";
            txttotalprice.TextAlign = HorizontalAlignment.Right;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(161, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 17);
            label3.TabIndex = 0;
            label3.Text = "Tổng tiền";
            label3.Click += label3_Click;
            // 
            // listView2
            // 
            listView2.BorderStyle = BorderStyle.FixedSingle;
            listView2.Columns.AddRange(new ColumnHeader[] { tenMon, soluong, dongia, thanhtien });
            listView2.Location = new Point(607, 80);
            listView2.Margin = new Padding(0);
            listView2.Name = "listView2";
            listView2.Size = new Size(373, 280);
            listView2.TabIndex = 3;
            listView2.UseCompatibleStateImageBehavior = false;
            listView2.View = View.Details;
            listView2.SelectedIndexChanged += listView2_SelectedIndexChanged;
            // 
            // tenMon
            // 
            tenMon.Text = "Tên Món";
            tenMon.Width = 120;
            // 
            // soluong
            // 
            soluong.Text = "Số Lượng";
            soluong.Width = 80;
            // 
            // dongia
            // 
            dongia.Text = "Giá";
            // 
            // thanhtien
            // 
            thanhtien.Text = "Thành Tiền";
            thanhtien.Width = 100;
            // 
            // listView1
            // 
            listView1.BackColor = Color.Gainsboro;
            listView1.BorderStyle = BorderStyle.FixedSingle;
            listView1.Columns.AddRange(new ColumnHeader[] { idFood, count });
            listView1.GridLines = true;
            listView1.Location = new Point(607, 43);
            listView1.Name = "listView1";
            listView1.Size = new Size(373, 366);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            listView1.View = View.List;
            // 
            // count
            // 
            count.Text = "hello";
            count.Width = 10;
            // 
            // label2
            // 
            label2.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(980, 40);
            label2.TabIndex = 1;
            label2.Text = "Danh sách bàn";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // flayer1
            // 
            flayer1.AutoScroll = true;
            flayer1.Location = new Point(8, 43);
            flayer1.Name = "flayer1";
            flayer1.Size = new Size(593, 366);
            flayer1.TabIndex = 0;
            flayer1.Paint += flayer1_Paint;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(button3);
            tabPage3.Location = new Point(4, 4);
            tabPage3.Margin = new Padding(0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(992, 412);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Chấm công";
            tabPage3.UseVisualStyleBackColor = true;
            tabPage3.Click += tabPage3_Click;
            // 
            // button3
            // 
            button3.Location = new Point(37, 32);
            button3.Name = "button3";
            button3.Size = new Size(124, 38);
            button3.TabIndex = 0;
            button3.Text = "chấm công";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // tabPage4
            // 
            tabPage4.Location = new Point(4, 4);
            tabPage4.Margin = new Padding(0);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(992, 412);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Nhà hàng";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 461);
            Controls.Add(tabControl1);
            Name = "fMain";
            Text = "Quán càfe";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            tabPage3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private Label label1;
        private Button button2;
        private Button button1;
        private FlowLayoutPanel flayer1;
        private Label label2;
        private ListView listView1;
        private ColumnHeader idFood;
        private ColumnHeader count;
        private ListView listView2;
        private ColumnHeader tenMon;
        private ColumnHeader soluong;
        private ColumnHeader dongia;
        private Button button3;
        private ColumnHeader thanhtien;
        private Panel panel1;
        private TextBox txttotalprice;
        private Label label3;
        private Button button4;
    }
}