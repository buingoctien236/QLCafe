namespace PresentationLayer
{
    partial class Login
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
            btnExit = new Button();
            btnLogin = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            txbPassword = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            txbUserName = new TextBox();
            label1 = new Label();
            label5 = new Label();
            panel1.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnExit);
            panel1.Controls.Add(btnLogin);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel2);
            panel1.Location = new Point(97, 50);
            panel1.Name = "panel1";
            panel1.Size = new Size(747, 357);
            panel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(438, 272);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(183, 29);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(232, 271);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(183, 29);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(txbPassword);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(26, 186);
            panel4.Name = "panel4";
            panel4.Size = new Size(699, 67);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(0, 119);
            panel5.Name = "panel5";
            panel5.Size = new Size(699, 113);
            panel5.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(206, 40);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(353, 27);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(45, 42);
            label3.Name = "label3";
            label3.Size = new Size(138, 21);
            label3.TabIndex = 0;
            label3.Text = "Tên đăng nhập";
            // 
            // txbPassword
            // 
            txbPassword.Location = new Point(206, 22);
            txbPassword.Name = "txbPassword";
            txbPassword.Size = new Size(353, 27);
            txbPassword.TabIndex = 1;
            txbPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(45, 22);
            label4.Name = "label4";
            label4.Size = new Size(88, 21);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txbUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(26, 115);
            panel2.Name = "panel2";
            panel2.Size = new Size(699, 65);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 119);
            panel3.Name = "panel3";
            panel3.Size = new Size(699, 113);
            panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(206, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(353, 27);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(45, 42);
            label2.Name = "label2";
            label2.Size = new Size(138, 21);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // txbUserName
            // 
            txbUserName.Location = new Point(206, 18);
            txbUserName.Name = "txbUserName";
            txbUserName.Size = new Size(353, 27);
            txbUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 24);
            label1.Name = "label1";
            label1.Size = new Size(138, 21);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(165, 32);
            label5.Name = "label5";
            label5.Size = new Size(380, 40);
            label5.TabIndex = 6;
            label5.Text = "Ứng dụng quản lý cafe";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(961, 494);
            Controls.Add(panel1);
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            FormClosing += Login_FormClosing;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private TextBox textBox1;
        private Label label2;
        private TextBox txbUserName;
        private Label label1;
        private Button btnExit;
        private Button btnLogin;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox2;
        private Label label3;
        private TextBox txbPassword;
        private Label label4;
        private Label label5;
    }
}