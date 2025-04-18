namespace PresentationLayer
{
    partial class chamcong
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
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            label2 = new Label();
            listView1 = new ListView();
            txt_maca = new TextBox();
            lb_maca = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            label4 = new Label();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Location = new Point(6, 7);
            panel1.Name = "panel1";
            panel1.Size = new Size(916, 54);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(textBox2);
            panel2.Controls.Add(textBox1);
            panel2.Controls.Add(lb_maca);
            panel2.Controls.Add(txt_maca);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(7, 67);
            panel2.Name = "panel2";
            panel2.Size = new Size(432, 421);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(listView1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(445, 67);
            panel3.Name = "panel3";
            panel3.Size = new Size(470, 421);
            panel3.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 8);
            label1.Name = "label1";
            label1.Size = new Size(246, 41);
            label1.TabIndex = 0;
            label1.Text = "Thông tin ca làm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(98, 8);
            label2.Name = "label2";
            label2.Size = new Size(287, 41);
            label2.TabIndex = 1;
            label2.Text = "Thông tin nhân viên";
            // 
            // listView1
            // 
            listView1.Location = new Point(7, 51);
            listView1.Name = "listView1";
            listView1.Size = new Size(460, 312);
            listView1.TabIndex = 2;
            listView1.UseCompatibleStateImageBehavior = false;
            // 
            // txt_maca
            // 
            txt_maca.Location = new Point(117, 72);
            txt_maca.Multiline = true;
            txt_maca.Name = "txt_maca";
            txt_maca.Size = new Size(271, 34);
            txt_maca.TabIndex = 1;
            // 
            // lb_maca
            // 
            lb_maca.AutoSize = true;
            lb_maca.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lb_maca.Location = new Point(27, 76);
            lb_maca.Name = "lb_maca";
            lb_maca.Size = new Size(63, 25);
            lb_maca.TabIndex = 2;
            lb_maca.Text = "Mã ca";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 127);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(271, 34);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 190);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(271, 34);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 196);
            label3.Name = "label3";
            label3.Size = new Size(90, 25);
            label3.TabIndex = 5;
            label3.Text = "Giờ đóng";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(25, 133);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 6;
            label4.Text = "Giờ mở";
            // 
            // chamcong
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 500);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "chamcong";
            Text = "chamcong";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private TextBox txt_maca;
        private Label label1;
        private Panel panel3;
        private ListView listView1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lb_maca;
    }
}