namespace PresentationLayer
{
    partial class fAdmin
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
            abAdmin = new TabControl();
            tpTable = new TabPage();
            dtgvTable = new DataGridView();
            panel13 = new Panel();
            panel15 = new Panel();
            txtNameTable = new TextBox();
            label11 = new Label();
            panel14 = new Panel();
            txbIdTable = new TextBox();
            label10 = new Label();
            panel12 = new Panel();
            btnShowTable = new Button();
            btnDeleteTable = new Button();
            btnEditTable = new Button();
            btnAddTable = new Button();
            tpFood = new TabPage();
            panel6 = new Panel();
            cbFoodCategory = new ComboBox();
            nmFoodPrice = new NumericUpDown();
            label8 = new Label();
            label7 = new Label();
            txbFoodName = new TextBox();
            label6 = new Label();
            txbFoodID = new TextBox();
            label5 = new Label();
            panel5 = new Panel();
            txbSearchFoodName = new TextBox();
            btnSearchFood = new Button();
            panel4 = new Panel();
            dtgvFood = new DataGridView();
            panel3 = new Panel();
            button3 = new Button();
            btnDeleteFood = new Button();
            btnEditfood = new Button();
            btnAddFood = new Button();
            tabFoodcategory = new TabPage();
            dtgvCategory = new DataGridView();
            panel17 = new Panel();
            panel19 = new Panel();
            txbCategoryName = new TextBox();
            label14 = new Label();
            panel18 = new Panel();
            txbCategoryID = new TextBox();
            label12 = new Label();
            panel16 = new Panel();
            btnShowCategory = new Button();
            btnDeleteCategory = new Button();
            btnEditCategory = new Button();
            btnAddCategory = new Button();
            tpBill = new TabPage();
            panel2 = new Panel();
            label9 = new Label();
            txtDoanhThu = new TextBox();
            dtgvBill = new DataGridView();
            panel1 = new Panel();
            btnViewBill = new Button();
            dtpkToDate = new DateTimePicker();
            dtpkFromDate = new DateTimePicker();
            tpAccount = new TabPage();
            label13 = new Label();
            panel11 = new Panel();
            nmAccountType = new NumericUpDown();
            label4 = new Label();
            panel10 = new Panel();
            txtDisplayName = new TextBox();
            label3 = new Label();
            panel9 = new Panel();
            txtUserName = new TextBox();
            label2 = new Label();
            panel8 = new Panel();
            dtgvAccount = new DataGridView();
            panel7 = new Panel();
            btnShowAccount = new Button();
            btnEditAccout = new Button();
            btnDeletwAccount = new Button();
            btnAddAccount = new Button();
            label1 = new Label();
            abAdmin.SuspendLayout();
            tpTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvTable).BeginInit();
            panel13.SuspendLayout();
            panel15.SuspendLayout();
            panel14.SuspendLayout();
            panel12.SuspendLayout();
            tpFood.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvFood).BeginInit();
            panel3.SuspendLayout();
            tabFoodcategory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).BeginInit();
            panel17.SuspendLayout();
            panel19.SuspendLayout();
            panel18.SuspendLayout();
            panel16.SuspendLayout();
            tpBill.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).BeginInit();
            panel1.SuspendLayout();
            tpAccount.SuspendLayout();
            panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountType).BeginInit();
            panel10.SuspendLayout();
            panel9.SuspendLayout();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).BeginInit();
            panel7.SuspendLayout();
            SuspendLayout();
            // 
            // abAdmin
            // 
            abAdmin.Controls.Add(tpTable);
            abAdmin.Controls.Add(tpFood);
            abAdmin.Controls.Add(tabFoodcategory);
            abAdmin.Controls.Add(tpBill);
            abAdmin.Controls.Add(tpAccount);
            abAdmin.Location = new Point(-3, 1);
            abAdmin.Name = "abAdmin";
            abAdmin.SelectedIndex = 0;
            abAdmin.Size = new Size(800, 450);
            abAdmin.TabIndex = 0;
            // 
            // tpTable
            // 
            tpTable.Controls.Add(dtgvTable);
            tpTable.Controls.Add(panel13);
            tpTable.Controls.Add(panel12);
            tpTable.Location = new Point(4, 24);
            tpTable.Name = "tpTable";
            tpTable.Padding = new Padding(3);
            tpTable.Size = new Size(792, 422);
            tpTable.TabIndex = 0;
            tpTable.Text = "Bàn ăn";
            tpTable.UseVisualStyleBackColor = true;
            // 
            // dtgvTable
            // 
            dtgvTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvTable.Location = new Point(3, 75);
            dtgvTable.Name = "dtgvTable";
            dtgvTable.Size = new Size(431, 338);
            dtgvTable.TabIndex = 2;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel15);
            panel13.Controls.Add(panel14);
            panel13.Location = new Point(440, 36);
            panel13.Name = "panel13";
            panel13.Size = new Size(352, 377);
            panel13.TabIndex = 1;
            // 
            // panel15
            // 
            panel15.Controls.Add(txtNameTable);
            panel15.Controls.Add(label11);
            panel15.Location = new Point(2, 125);
            panel15.Name = "panel15";
            panel15.Size = new Size(350, 70);
            panel15.TabIndex = 1;
            // 
            // txtNameTable
            // 
            txtNameTable.Location = new Point(133, 24);
            txtNameTable.Name = "txtNameTable";
            txtNameTable.Size = new Size(195, 23);
            txtNameTable.TabIndex = 2;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label11.Location = new Point(38, 26);
            label11.Name = "label11";
            label11.Size = new Size(74, 18);
            label11.TabIndex = 1;
            label11.Text = "Tên bàn :";
            // 
            // panel14
            // 
            panel14.Controls.Add(txbIdTable);
            panel14.Controls.Add(label10);
            panel14.Location = new Point(3, 49);
            panel14.Name = "panel14";
            panel14.Size = new Size(350, 70);
            panel14.TabIndex = 0;
            // 
            // txbIdTable
            // 
            txbIdTable.Location = new Point(132, 21);
            txbIdTable.Name = "txbIdTable";
            txbIdTable.ReadOnly = true;
            txbIdTable.Size = new Size(195, 23);
            txbIdTable.TabIndex = 1;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label10.Location = new Point(37, 26);
            label10.Name = "label10";
            label10.Size = new Size(31, 18);
            label10.TabIndex = 0;
            label10.Text = "ID :";
            // 
            // panel12
            // 
            panel12.Controls.Add(btnShowTable);
            panel12.Controls.Add(btnDeleteTable);
            panel12.Controls.Add(btnEditTable);
            panel12.Controls.Add(btnAddTable);
            panel12.Location = new Point(3, 6);
            panel12.Name = "panel12";
            panel12.Size = new Size(431, 63);
            panel12.TabIndex = 0;
            // 
            // btnShowTable
            // 
            btnShowTable.Location = new Point(311, 3);
            btnShowTable.Name = "btnShowTable";
            btnShowTable.Size = new Size(95, 55);
            btnShowTable.TabIndex = 3;
            btnShowTable.Text = "Xem";
            btnShowTable.UseVisualStyleBackColor = true;
            btnShowTable.Click += btnShowTable_Click;
            // 
            // btnDeleteTable
            // 
            btnDeleteTable.Location = new Point(210, 3);
            btnDeleteTable.Name = "btnDeleteTable";
            btnDeleteTable.Size = new Size(95, 55);
            btnDeleteTable.TabIndex = 2;
            btnDeleteTable.Text = "Xóa";
            btnDeleteTable.UseVisualStyleBackColor = true;
            btnDeleteTable.Click += btnDeleteTable_Click;
            // 
            // btnEditTable
            // 
            btnEditTable.Location = new Point(109, 3);
            btnEditTable.Name = "btnEditTable";
            btnEditTable.Size = new Size(95, 55);
            btnEditTable.TabIndex = 1;
            btnEditTable.Text = "Sửa";
            btnEditTable.UseVisualStyleBackColor = true;
            btnEditTable.Click += btnEditTable_Click_1;
            // 
            // btnAddTable
            // 
            btnAddTable.Location = new Point(8, 3);
            btnAddTable.Name = "btnAddTable";
            btnAddTable.Size = new Size(95, 55);
            btnAddTable.TabIndex = 0;
            btnAddTable.Text = "Thêm";
            btnAddTable.UseVisualStyleBackColor = true;
            btnAddTable.Click += btnAddTable_Click_1;
            // 
            // tpFood
            // 
            tpFood.Controls.Add(panel6);
            tpFood.Controls.Add(panel5);
            tpFood.Controls.Add(panel4);
            tpFood.Controls.Add(panel3);
            tpFood.Location = new Point(4, 24);
            tpFood.Name = "tpFood";
            tpFood.Padding = new Padding(3);
            tpFood.Size = new Size(792, 422);
            tpFood.TabIndex = 1;
            tpFood.Text = "Thức ăn";
            tpFood.UseVisualStyleBackColor = true;
            // 
            // panel6
            // 
            panel6.Controls.Add(cbFoodCategory);
            panel6.Controls.Add(nmFoodPrice);
            panel6.Controls.Add(label8);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(txbFoodName);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(txbFoodID);
            panel6.Controls.Add(label5);
            panel6.Location = new Point(451, 69);
            panel6.Name = "panel6";
            panel6.Size = new Size(335, 347);
            panel6.TabIndex = 3;
            // 
            // cbFoodCategory
            // 
            cbFoodCategory.FormattingEnabled = true;
            cbFoodCategory.Location = new Point(113, 124);
            cbFoodCategory.Name = "cbFoodCategory";
            cbFoodCategory.Size = new Size(139, 23);
            cbFoodCategory.TabIndex = 8;
            // 
            // nmFoodPrice
            // 
            nmFoodPrice.Location = new Point(113, 163);
            nmFoodPrice.Maximum = new decimal(new int[] { 1215752192, 23, 0, 0 });
            nmFoodPrice.Name = "nmFoodPrice";
            nmFoodPrice.Size = new Size(139, 23);
            nmFoodPrice.TabIndex = 7;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label8.Location = new Point(16, 163);
            label8.Name = "label8";
            label8.Size = new Size(36, 18);
            label8.TabIndex = 6;
            label8.Text = "Giá:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label7.Location = new Point(16, 125);
            label7.Name = "label7";
            label7.Size = new Size(82, 18);
            label7.TabIndex = 4;
            label7.Text = "Danh mục:";
            // 
            // txbFoodName
            // 
            txbFoodName.Location = new Point(113, 83);
            txbFoodName.Name = "txbFoodName";
            txbFoodName.Size = new Size(139, 23);
            txbFoodName.TabIndex = 3;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label6.Location = new Point(16, 83);
            label6.Name = "label6";
            label6.Size = new Size(74, 18);
            label6.TabIndex = 2;
            label6.Text = "Tên món:";
            // 
            // txbFoodID
            // 
            txbFoodID.Location = new Point(113, 40);
            txbFoodID.Name = "txbFoodID";
            txbFoodID.ReadOnly = true;
            txbFoodID.Size = new Size(139, 23);
            txbFoodID.TabIndex = 1;
            txbFoodID.TextChanged += txbFoodID_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label5.Location = new Point(16, 40);
            label5.Name = "label5";
            label5.Size = new Size(27, 18);
            label5.TabIndex = 0;
            label5.Text = "ID:";
            // 
            // panel5
            // 
            panel5.Controls.Add(txbSearchFoodName);
            panel5.Controls.Add(btnSearchFood);
            panel5.Location = new Point(450, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(336, 60);
            panel5.TabIndex = 2;
            // 
            // txbSearchFoodName
            // 
            txbSearchFoodName.Location = new Point(3, 17);
            txbSearchFoodName.Name = "txbSearchFoodName";
            txbSearchFoodName.Size = new Size(228, 23);
            txbSearchFoodName.TabIndex = 5;
            // 
            // btnSearchFood
            // 
            btnSearchFood.Location = new Point(237, 0);
            btnSearchFood.Name = "btnSearchFood";
            btnSearchFood.Size = new Size(96, 54);
            btnSearchFood.TabIndex = 4;
            btnSearchFood.Text = "Tìm kiếm";
            btnSearchFood.UseVisualStyleBackColor = true;
            btnSearchFood.Click += btnSearchFood_Click;
            // 
            // panel4
            // 
            panel4.Controls.Add(dtgvFood);
            panel4.Location = new Point(3, 69);
            panel4.Name = "panel4";
            panel4.Size = new Size(441, 347);
            panel4.TabIndex = 1;
            // 
            // dtgvFood
            // 
            dtgvFood.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvFood.Location = new Point(3, 3);
            dtgvFood.Name = "dtgvFood";
            dtgvFood.Size = new Size(435, 341);
            dtgvFood.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(button3);
            panel3.Controls.Add(btnDeleteFood);
            panel3.Controls.Add(btnEditfood);
            panel3.Controls.Add(btnAddFood);
            panel3.Location = new Point(3, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(441, 60);
            panel3.TabIndex = 0;
            // 
            // button3
            // 
            button3.Location = new Point(309, 3);
            button3.Name = "button3";
            button3.Size = new Size(96, 54);
            button3.TabIndex = 3;
            button3.Text = "Xem";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btnDeleteFood
            // 
            btnDeleteFood.Location = new Point(207, 3);
            btnDeleteFood.Name = "btnDeleteFood";
            btnDeleteFood.Size = new Size(96, 54);
            btnDeleteFood.TabIndex = 2;
            btnDeleteFood.Text = "Xóa";
            btnDeleteFood.UseVisualStyleBackColor = true;
            btnDeleteFood.Click += btnDeleteFood_Click;
            // 
            // btnEditfood
            // 
            btnEditfood.Location = new Point(105, 3);
            btnEditfood.Name = "btnEditfood";
            btnEditfood.Size = new Size(96, 54);
            btnEditfood.TabIndex = 1;
            btnEditfood.Text = "Sửa";
            btnEditfood.UseVisualStyleBackColor = true;
            btnEditfood.Click += btnEditFood_Click;
            // 
            // btnAddFood
            // 
            btnAddFood.Location = new Point(3, 3);
            btnAddFood.Name = "btnAddFood";
            btnAddFood.Size = new Size(96, 54);
            btnAddFood.TabIndex = 0;
            btnAddFood.Text = "Thêm";
            btnAddFood.UseVisualStyleBackColor = true;
            btnAddFood.Click += btnAddFood_Click;
            // 
            // tabFoodcategory
            // 
            tabFoodcategory.Controls.Add(dtgvCategory);
            tabFoodcategory.Controls.Add(panel17);
            tabFoodcategory.Controls.Add(panel16);
            tabFoodcategory.Location = new Point(4, 24);
            tabFoodcategory.Name = "tabFoodcategory";
            tabFoodcategory.Padding = new Padding(3);
            tabFoodcategory.Size = new Size(792, 422);
            tabFoodcategory.TabIndex = 2;
            tabFoodcategory.Text = "Danh mục";
            tabFoodcategory.UseVisualStyleBackColor = true;
            // 
            // dtgvCategory
            // 
            dtgvCategory.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvCategory.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCategory.Location = new Point(6, 75);
            dtgvCategory.Name = "dtgvCategory";
            dtgvCategory.Size = new Size(431, 338);
            dtgvCategory.TabIndex = 2;
            // 
            // panel17
            // 
            panel17.Controls.Add(panel19);
            panel17.Controls.Add(panel18);
            panel17.Location = new Point(443, 45);
            panel17.Name = "panel17";
            panel17.Size = new Size(343, 345);
            panel17.TabIndex = 1;
            // 
            // panel19
            // 
            panel19.Controls.Add(txbCategoryName);
            panel19.Controls.Add(label14);
            panel19.Location = new Point(3, 89);
            panel19.Name = "panel19";
            panel19.Size = new Size(337, 70);
            panel19.TabIndex = 1;
            // 
            // txbCategoryName
            // 
            txbCategoryName.Location = new Point(130, 24);
            txbCategoryName.Name = "txbCategoryName";
            txbCategoryName.Size = new Size(191, 23);
            txbCategoryName.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label14.Location = new Point(12, 26);
            label14.Name = "label14";
            label14.Size = new Size(112, 18);
            label14.TabIndex = 1;
            label14.Text = "Tên danh mục:";
            // 
            // panel18
            // 
            panel18.Controls.Add(txbCategoryID);
            panel18.Controls.Add(label12);
            panel18.Location = new Point(3, 13);
            panel18.Name = "panel18";
            panel18.Size = new Size(337, 70);
            panel18.TabIndex = 0;
            // 
            // txbCategoryID
            // 
            txbCategoryID.Location = new Point(130, 24);
            txbCategoryID.Name = "txbCategoryID";
            txbCategoryID.ReadOnly = true;
            txbCategoryID.Size = new Size(191, 23);
            txbCategoryID.TabIndex = 1;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial", 11.25F, FontStyle.Bold);
            label12.Location = new Point(97, 26);
            label12.Name = "label12";
            label12.Size = new Size(27, 18);
            label12.TabIndex = 0;
            label12.Text = "ID:";
            // 
            // panel16
            // 
            panel16.Controls.Add(btnShowCategory);
            panel16.Controls.Add(btnDeleteCategory);
            panel16.Controls.Add(btnEditCategory);
            panel16.Controls.Add(btnAddCategory);
            panel16.Location = new Point(6, 6);
            panel16.Name = "panel16";
            panel16.Size = new Size(431, 63);
            panel16.TabIndex = 0;
            // 
            // btnShowCategory
            // 
            btnShowCategory.Location = new Point(308, 3);
            btnShowCategory.Name = "btnShowCategory";
            btnShowCategory.Size = new Size(95, 55);
            btnShowCategory.TabIndex = 3;
            btnShowCategory.Text = "Xem";
            btnShowCategory.UseVisualStyleBackColor = false;
            btnShowCategory.Click += btnShowCategory_Click;
            // 
            // btnDeleteCategory
            // 
            btnDeleteCategory.Location = new Point(207, 3);
            btnDeleteCategory.Name = "btnDeleteCategory";
            btnDeleteCategory.Size = new Size(95, 55);
            btnDeleteCategory.TabIndex = 2;
            btnDeleteCategory.Text = "Xóa";
            btnDeleteCategory.UseVisualStyleBackColor = false;
            btnDeleteCategory.Click += btnDeleteCategory_Click;
            // 
            // btnEditCategory
            // 
            btnEditCategory.Location = new Point(106, 3);
            btnEditCategory.Name = "btnEditCategory";
            btnEditCategory.Size = new Size(95, 55);
            btnEditCategory.TabIndex = 1;
            btnEditCategory.Text = "Sửa";
            btnEditCategory.UseVisualStyleBackColor = false;
            btnEditCategory.Click += btnEditCategory_Click;
            // 
            // btnAddCategory
            // 
            btnAddCategory.Location = new Point(5, 3);
            btnAddCategory.Name = "btnAddCategory";
            btnAddCategory.Size = new Size(95, 55);
            btnAddCategory.TabIndex = 0;
            btnAddCategory.Text = "Thêm";
            btnAddCategory.UseVisualStyleBackColor = false;
            btnAddCategory.Click += btnAddCategory_Click;
            // 
            // tpBill
            // 
            tpBill.Controls.Add(panel2);
            tpBill.Controls.Add(panel1);
            tpBill.Location = new Point(4, 24);
            tpBill.Name = "tpBill";
            tpBill.Padding = new Padding(3);
            tpBill.Size = new Size(792, 422);
            tpBill.TabIndex = 3;
            tpBill.Text = "Doanh thu";
            tpBill.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label9);
            panel2.Controls.Add(txtDoanhThu);
            panel2.Controls.Add(dtgvBill);
            panel2.Location = new Point(4, 52);
            panel2.Name = "panel2";
            panel2.Size = new Size(788, 370);
            panel2.TabIndex = 1;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(660, 320);
            label9.Name = "label9";
            label9.Size = new Size(65, 15);
            label9.TabIndex = 2;
            label9.Text = "Doanh Thu";
            // 
            // txtDoanhThu
            // 
            txtDoanhThu.Location = new Point(660, 338);
            txtDoanhThu.Name = "txtDoanhThu";
            txtDoanhThu.Size = new Size(100, 23);
            txtDoanhThu.TabIndex = 1;
            // 
            // dtgvBill
            // 
            dtgvBill.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvBill.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvBill.Location = new Point(2, 3);
            dtgvBill.Name = "dtgvBill";
            dtgvBill.Size = new Size(786, 301);
            dtgvBill.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnViewBill);
            panel1.Controls.Add(dtpkToDate);
            panel1.Controls.Add(dtpkFromDate);
            panel1.Location = new Point(4, 6);
            panel1.Name = "panel1";
            panel1.Size = new Size(783, 40);
            panel1.TabIndex = 0;
            // 
            // btnViewBill
            // 
            btnViewBill.Location = new Point(346, 6);
            btnViewBill.Name = "btnViewBill";
            btnViewBill.Size = new Size(75, 23);
            btnViewBill.TabIndex = 2;
            btnViewBill.Text = "Thống kê";
            btnViewBill.UseVisualStyleBackColor = true;
            btnViewBill.Click += btnViewBill_Click;
            // 
            // dtpkToDate
            // 
            dtpkToDate.Location = new Point(560, 3);
            dtpkToDate.Name = "dtpkToDate";
            dtpkToDate.Size = new Size(200, 23);
            dtpkToDate.TabIndex = 1;
            // 
            // dtpkFromDate
            // 
            dtpkFromDate.Location = new Point(3, 3);
            dtpkFromDate.Name = "dtpkFromDate";
            dtpkFromDate.Size = new Size(200, 23);
            dtpkFromDate.TabIndex = 0;
            // 
            // tpAccount
            // 
            tpAccount.Controls.Add(label13);
            tpAccount.Controls.Add(panel11);
            tpAccount.Controls.Add(panel10);
            tpAccount.Controls.Add(panel9);
            tpAccount.Controls.Add(panel8);
            tpAccount.Controls.Add(panel7);
            tpAccount.Location = new Point(4, 24);
            tpAccount.Name = "tpAccount";
            tpAccount.Padding = new Padding(3);
            tpAccount.Size = new Size(792, 422);
            tpAccount.TabIndex = 4;
            tpAccount.Text = "Tài khoản";
            tpAccount.UseVisualStyleBackColor = true;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label13.Location = new Point(431, 303);
            label13.Name = "label13";
            label13.Size = new Size(355, 15);
            label13.TabIndex = 5;
            label13.Text = "Loạii tài khoản 0 là nhân viên, 1 là admin, password mặc định là 1";
            // 
            // panel11
            // 
            panel11.Controls.Add(nmAccountType);
            panel11.Controls.Add(label4);
            panel11.Location = new Point(431, 230);
            panel11.Name = "panel11";
            panel11.Size = new Size(355, 70);
            panel11.TabIndex = 4;
            // 
            // nmAccountType
            // 
            nmAccountType.Location = new Point(141, 21);
            nmAccountType.Maximum = new decimal(new int[] { 1, 0, 0, 0 });
            nmAccountType.Name = "nmAccountType";
            nmAccountType.Size = new Size(120, 23);
            nmAccountType.TabIndex = 1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(17, 26);
            label4.Name = "label4";
            label4.Size = new Size(110, 18);
            label4.TabIndex = 0;
            label4.Text = "Loại tài khoản:";
            // 
            // panel10
            // 
            panel10.Controls.Add(txtDisplayName);
            panel10.Controls.Add(label3);
            panel10.Location = new Point(431, 154);
            panel10.Name = "panel10";
            panel10.Size = new Size(355, 70);
            panel10.TabIndex = 3;
            // 
            // txtDisplayName
            // 
            txtDisplayName.Location = new Point(141, 24);
            txtDisplayName.Name = "txtDisplayName";
            txtDisplayName.Size = new Size(194, 23);
            txtDisplayName.TabIndex = 1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(17, 26);
            label3.Name = "label3";
            label3.Size = new Size(118, 18);
            label3.TabIndex = 0;
            label3.Text = "Tên đăng nhập:";
            // 
            // panel9
            // 
            panel9.Controls.Add(txtUserName);
            panel9.Controls.Add(label2);
            panel9.Location = new Point(431, 78);
            panel9.Name = "panel9";
            panel9.Size = new Size(355, 70);
            panel9.TabIndex = 2;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(141, 24);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(194, 23);
            txtUserName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(17, 26);
            label2.Name = "label2";
            label2.Size = new Size(112, 18);
            label2.TabIndex = 0;
            label2.Text = "Tên tài khoản::";
            // 
            // panel8
            // 
            panel8.Controls.Add(dtgvAccount);
            panel8.Location = new Point(3, 78);
            panel8.Name = "panel8";
            panel8.Size = new Size(422, 338);
            panel8.TabIndex = 1;
            // 
            // dtgvAccount
            // 
            dtgvAccount.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dtgvAccount.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvAccount.Location = new Point(3, 3);
            dtgvAccount.Name = "dtgvAccount";
            dtgvAccount.Size = new Size(416, 332);
            dtgvAccount.TabIndex = 0;
            // 
            // panel7
            // 
            panel7.Controls.Add(btnShowAccount);
            panel7.Controls.Add(btnEditAccout);
            panel7.Controls.Add(btnDeletwAccount);
            panel7.Controls.Add(btnAddAccount);
            panel7.Location = new Point(3, 6);
            panel7.Name = "panel7";
            panel7.Size = new Size(422, 66);
            panel7.TabIndex = 0;
            // 
            // btnShowAccount
            // 
            btnShowAccount.Location = new Point(314, 3);
            btnShowAccount.Name = "btnShowAccount";
            btnShowAccount.Size = new Size(96, 60);
            btnShowAccount.TabIndex = 3;
            btnShowAccount.Text = "Xem";
            btnShowAccount.UseVisualStyleBackColor = true;
            btnShowAccount.Click += btnShowAccount_Click;
            // 
            // btnEditAccout
            // 
            btnEditAccout.Location = new Point(212, 3);
            btnEditAccout.Name = "btnEditAccout";
            btnEditAccout.Size = new Size(96, 60);
            btnEditAccout.TabIndex = 2;
            btnEditAccout.Text = "Sửa";
            btnEditAccout.UseVisualStyleBackColor = true;
            btnEditAccout.Click += btnEditAccout_Click;
            // 
            // btnDeletwAccount
            // 
            btnDeletwAccount.Location = new Point(110, 3);
            btnDeletwAccount.Name = "btnDeletwAccount";
            btnDeletwAccount.Size = new Size(96, 60);
            btnDeletwAccount.TabIndex = 1;
            btnDeletwAccount.Text = "Xóa";
            btnDeletwAccount.UseVisualStyleBackColor = true;
            btnDeletwAccount.Click += btnDeletwAccount_Click;
            // 
            // btnAddAccount
            // 
            btnAddAccount.Location = new Point(8, 3);
            btnAddAccount.Name = "btnAddAccount";
            btnAddAccount.Size = new Size(96, 60);
            btnAddAccount.TabIndex = 0;
            btnAddAccount.Text = "Thêm";
            btnAddAccount.UseVisualStyleBackColor = true;
            btnAddAccount.Click += btnAddAccount_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(16, 19);
            label1.Name = "label1";
            label1.Size = new Size(108, 18);
            label1.TabIndex = 0;
            label1.Text = "Tên tài khoản:";
            // 
            // fAdmin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(abAdmin);
            Name = "fAdmin";
            Text = "fAdmin";
            abAdmin.ResumeLayout(false);
            tpTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvTable).EndInit();
            panel13.ResumeLayout(false);
            panel15.ResumeLayout(false);
            panel15.PerformLayout();
            panel14.ResumeLayout(false);
            panel14.PerformLayout();
            panel12.ResumeLayout(false);
            tpFood.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmFoodPrice).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvFood).EndInit();
            panel3.ResumeLayout(false);
            tabFoodcategory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvCategory).EndInit();
            panel17.ResumeLayout(false);
            panel19.ResumeLayout(false);
            panel19.PerformLayout();
            panel18.ResumeLayout(false);
            panel18.PerformLayout();
            panel16.ResumeLayout(false);
            tpBill.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dtgvBill).EndInit();
            panel1.ResumeLayout(false);
            tpAccount.ResumeLayout(false);
            tpAccount.PerformLayout();
            panel11.ResumeLayout(false);
            panel11.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nmAccountType).EndInit();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtgvAccount).EndInit();
            panel7.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl abAdmin;
        private TabPage tpTable;
        private TabPage tpFood;
        private TabPage tabFoodcategory;
        private TabPage tpBill;
        private Panel panel2;
        private DataGridView dtgvBill;
        private Panel panel1;
        private Button btnViewBill;
        private DateTimePicker dtpkToDate;
        private DateTimePicker dtpkFromDate;
        private TabPage tpAccount;
        private Panel panel6;
        private Panel panel5;
        private Panel panel4;
        private DataGridView dtgvFood;
        private Panel panel3;
        private Button button3;
        private Button btnDeleteFood;
        private Button btnEditfood;
        private Button btnAddFood;
        private TextBox txbSearchFoodName;
        private Button btnSearchFood;
        private Panel panel8;
        private Panel panel7;
        private Button btnAddAccount;
        private TextBox txtUserName;
        private Label label1;
        private Button btnShowAccount;
        private Button btnEditAccout;
        private Button btnDeletwAccount;
        private DataGridView dtgvAccount;
        private Panel panel9;
        private Label label2;
        private Panel panel11;
        private Label label4;
        private Panel panel10;
        private TextBox txtDisplayName;
        private Label label3;
        private NumericUpDown nmFoodPrice;
        private Label label8;
        private Label label7;
        private TextBox txbFoodName;
        private Label label6;
        private TextBox txbFoodID;
        private Label label5;
        private ComboBox cbFoodCategory;
        private NumericUpDown nmAccountType;
        private Label label9;
        private TextBox txtDoanhThu;
        private DataGridView dtgvTable;
        private Panel panel12;
        private Button btnShowTable;
        private Button btnDeleteTable;
        private Button btnEditTable;
        private Button btnAddTable;
        private Label label13;
        private Panel panel13;
        private Panel panel15;
        private TextBox txtNameTable;
        private Label label11;
        private Panel panel14;
        private TextBox txbIdTable;
        private Label label10;
        private Panel panel17;
        private Panel panel16;
        private DataGridView dtgvCategory;
        private Panel panel19;
        private Panel panel18;
        private Label label12;
        private Button btnShowCategory;
        private Button btnDeleteCategory;
        private Button btnEditCategory;
        private Button btnAddCategory;
        private TextBox txbCategoryName;
        private Label label14;
        private TextBox txbCategoryID;
    }
}