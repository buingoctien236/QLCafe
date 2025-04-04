namespace PresentationLayer
{
    partial class DangNhap
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
            loginbtn = new Button();
            so1 = new TextBox();
            label1 = new Label();
            so2 = new TextBox();
            label2 = new Label();
            ketqua = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // loginbtn
            // 
            loginbtn.Location = new Point(298, 337);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(75, 23);
            loginbtn.TabIndex = 0;
            loginbtn.Text = "testData";
            loginbtn.UseVisualStyleBackColor = true;
            loginbtn.Click += loginbtn_Click;
            // 
            // so1
            // 
            so1.Location = new Point(298, 134);
            so1.Name = "so1";
            so1.Size = new Size(100, 23);
            so1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 137);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 2;
            label1.Text = "+";
            label1.Click += label1_Click;
            // 
            // so2
            // 
            so2.Location = new Point(464, 134);
            so2.Name = "so2";
            so2.Size = new Size(100, 23);
            so2.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(296, 180);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 4;
            label2.Text = "=";
            // 
            // ketqua
            // 
            ketqua.Location = new Point(349, 177);
            ketqua.Name = "ketqua";
            ketqua.Size = new Size(100, 23);
            ketqua.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(479, 177);
            button1.Name = "button1";
            button1.Size = new Size(141, 23);
            button1.TabIndex = 6;
            button1.Text = "Tính tong testLogic";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(ketqua);
            Controls.Add(label2);
            Controls.Add(so2);
            Controls.Add(label1);
            Controls.Add(so1);
            Controls.Add(loginbtn);
            Name = "DangNhap";
            Text = "DangNhap";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginbtn;
        private TextBox so1;
        private Label label1;
        private TextBox so2;
        private Label label2;
        private TextBox ketqua;
        private Button button1;
    }
}