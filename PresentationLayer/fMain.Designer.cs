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
            label2 = new Label();
            flayer1 = new FlowLayoutPanel();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
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
            // 
            // tabPage2
            // 
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
            flayer1.Size = new Size(938, 366);
            flayer1.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.Location = new Point(4, 4);
            tabPage3.Margin = new Padding(0);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(992, 412);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Chấm công";
            tabPage3.UseVisualStyleBackColor = true;
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
    }
}