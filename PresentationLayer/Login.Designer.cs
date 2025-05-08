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
            label5 = new Label();
            btnExit = new Button();
            btnLogin = new Button();
            panel4 = new Panel();
            panel5 = new Panel();
            textBox2 = new TextBox();
            label3 = new Label();
            txtPassWord = new TextBox();
            label4 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            textBox1 = new TextBox();
            label2 = new Label();
            txtUserName = new TextBox();
            label1 = new Label();
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
            panel1.Location = new Point(85, 38);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 268);
            panel1.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(144, 24);
            label5.Name = "label5";
            label5.Size = new Size(313, 32);
            label5.TabIndex = 6;
            label5.Text = "Ứng dụng quản lý cafe";
            // 
            // btnExit
            // 
            btnExit.Location = new Point(383, 204);
            btnExit.Margin = new Padding(3, 2, 3, 2);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(160, 22);
            btnExit.TabIndex = 5;
            btnExit.Text = "Thoát";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += btnExit_Click;
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(203, 203);
            btnLogin.Margin = new Padding(3, 2, 3, 2);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(160, 22);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Đăng nhập";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(panel5);
            panel4.Controls.Add(txtPassWord);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(23, 140);
            panel4.Margin = new Padding(3, 2, 3, 2);
            panel4.Name = "panel4";
            panel4.Size = new Size(612, 50);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label3);
            panel5.Location = new Point(0, 89);
            panel5.Margin = new Padding(3, 2, 3, 2);
            panel5.Name = "panel5";
            panel5.Size = new Size(612, 85);
            panel5.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(180, 30);
            textBox2.Margin = new Padding(3, 2, 3, 2);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(309, 23);
            textBox2.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(39, 32);
            label3.Name = "label3";
            label3.Size = new Size(114, 18);
            label3.TabIndex = 0;
            label3.Text = "Tên đăng nhập";
            // 
            // txtPassWord
            // 
            txtPassWord.Location = new Point(180, 16);
            txtPassWord.Margin = new Padding(3, 2, 3, 2);
            txtPassWord.Name = "txtPassWord";
            txtPassWord.Size = new Size(309, 23);
            txtPassWord.TabIndex = 1;
            txtPassWord.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(39, 16);
            label4.Name = "label4";
            label4.Size = new Size(72, 18);
            label4.TabIndex = 0;
            label4.Text = "Mật khẩu";
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(23, 86);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(612, 49);
            panel2.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox1);
            panel3.Controls.Add(label2);
            panel3.Location = new Point(0, 89);
            panel3.Margin = new Padding(3, 2, 3, 2);
            panel3.Name = "panel3";
            panel3.Size = new Size(612, 85);
            panel3.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 30);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 23);
            textBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(39, 32);
            label2.Name = "label2";
            label2.Size = new Size(114, 18);
            label2.TabIndex = 0;
            label2.Text = "Tên đăng nhập";
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(180, 14);
            txtUserName.Margin = new Padding(3, 2, 3, 2);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(309, 23);
            txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(22, 18);
            label1.Name = "label1";
            label1.Size = new Size(114, 18);
            label1.TabIndex = 0;
            label1.Text = "Tên đăng nhập";
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 370);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
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
        private TextBox txtUserName;
        private Label label1;
        private Button btnExit;
        private Button btnLogin;
        private Panel panel4;
        private Panel panel5;
        private TextBox textBox2;
        private Label label3;
        private TextBox txtPassWord;
        private Label label4;
        private Label label5;
    }
}