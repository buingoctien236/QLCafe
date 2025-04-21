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
            label1 = new Label();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            flpanel2 = new FlowLayoutPanel();
            pictureBox2 = new PictureBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            flmenu1 = new FlowLayoutPanel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(353, 14);
            label1.Name = "label1";
            label1.Size = new Size(100, 18);
            label1.TabIndex = 0;
            label1.Text = "Bán mang về";
            label1.Click += label1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.LightGray;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(4, 2);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1000, 40);
            panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.back16;
            pictureBox1.ImageLocation = "";
            pictureBox1.Location = new Point(15, 16);
            pictureBox1.Margin = new Padding(0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(16, 16);
            pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // flpanel2
            // 
            flpanel2.Location = new Point(5, 92);
            flpanel2.Name = "flpanel2";
            flpanel2.Size = new Size(186, 369);
            flpanel2.TabIndex = 1;
            flpanel2.Paint += flowLayoutPanel1_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Anchor = AnchorStyles.None;
            pictureBox2.Image = Properties.Resources.search16;
            pictureBox2.Location = new Point(6, 11);
            pictureBox2.Margin = new Padding(0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(25, 25);
            pictureBox2.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Gainsboro;
            textBox1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.InactiveCaptionText;
            textBox1.Location = new Point(34, 11);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = " Tìm kiếm";
            textBox1.Size = new Size(141, 23);
            textBox1.TabIndex = 3;
            textBox1.TextAlign = HorizontalAlignment.Center;
            // 
            // panel2
            // 
            panel2.BackColor = Color.LightGray;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(textBox1);
            panel2.Location = new Point(4, 45);
            panel2.Name = "panel2";
            panel2.Size = new Size(187, 44);
            panel2.TabIndex = 4;
            // 
            // flmenu1
            // 
            flmenu1.AutoScroll = true;
            flmenu1.BackColor = Color.LightGray;
            flmenu1.Font = new Font("Segoe UI Emoji", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            flmenu1.Location = new Point(194, 46);
            flmenu1.Name = "flmenu1";
            flmenu1.Size = new Size(549, 419);
            flmenu1.TabIndex = 5;
            flmenu1.Paint += flowLayoutPanel1_Paint_1;
            // 
            // Giaodienmangve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(984, 461);
            Controls.Add(flmenu1);
            Controls.Add(flpanel2);
            Controls.Add(panel1);
            Controls.Add(panel2);
            ForeColor = SystemColors.ControlText;
            Margin = new Padding(3, 2, 3, 2);
            Name = "Giaodienmangve";
            Text = "Bán mang về";
            TransparencyKey = Color.IndianRed;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private Label label1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private FlowLayoutPanel flpanel2;
        private PictureBox pictureBox2;
        private TextBox textBox1;
        private Panel panel2;
        private FlowLayoutPanel flmenu1;
    }
}