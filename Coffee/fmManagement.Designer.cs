namespace Coffee
{
    partial class fmManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fmManagement));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dtgvTable = new System.Windows.Forms.DataGridView();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txbTableID = new System.Windows.Forms.TextBox();
            this.txbTableName = new System.Windows.Forms.TextBox();
            this.txbTableStatus = new System.Windows.Forms.TextBox();
            this.btnTableAdd = new System.Windows.Forms.Button();
            this.btnTableEdit = new System.Windows.Forms.Button();
            this.btnTableDel = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dtgvCategory = new System.Windows.Forms.DataGridView();
            this.btnCateAdd = new System.Windows.Forms.Button();
            this.btnCateEdit = new System.Windows.Forms.Button();
            this.btnCateDel = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txbCateID = new System.Windows.Forms.TextBox();
            this.txbCateName = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtgvFood = new System.Windows.Forms.DataGridView();
            this.btnFoodAdd = new System.Windows.Forms.Button();
            this.btnFoodEdit = new System.Windows.Forms.Button();
            this.btnFoodDel = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txbFoodID = new System.Windows.Forms.TextBox();
            this.txbFoodName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbbFoodCate = new System.Windows.Forms.ComboBox();
            this.nbuFoodPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbuFoodPrice)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackgroundImage = global::Coffee.Properties.Resources.color7;
            this.tabPage3.Controls.Add(this.btnTableDel);
            this.tabPage3.Controls.Add(this.btnTableEdit);
            this.tabPage3.Controls.Add(this.btnTableAdd);
            this.tabPage3.Controls.Add(this.txbTableStatus);
            this.tabPage3.Controls.Add(this.txbTableName);
            this.tabPage3.Controls.Add(this.txbTableID);
            this.tabPage3.Controls.Add(this.label16);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.dtgvTable);
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1156, 717);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Bàn ăn";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dtgvTable
            // 
            this.dtgvTable.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvTable.Location = new System.Drawing.Point(3, 226);
            this.dtgvTable.Name = "dtgvTable";
            this.dtgvTable.RowHeadersWidth = 51;
            this.dtgvTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvTable.Size = new System.Drawing.Size(1150, 488);
            this.dtgvTable.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(17, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 26);
            this.label14.TabIndex = 1;
            this.label14.Text = "ID";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(17, 68);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 26);
            this.label15.TabIndex = 3;
            this.label15.Text = "Tên bàn";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(17, 120);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(97, 26);
            this.label16.TabIndex = 5;
            this.label16.Text = "Trạng thái";
            // 
            // txbTableID
            // 
            this.txbTableID.Enabled = false;
            this.txbTableID.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTableID.Location = new System.Drawing.Point(162, 9);
            this.txbTableID.Name = "txbTableID";
            this.txbTableID.Size = new System.Drawing.Size(439, 33);
            this.txbTableID.TabIndex = 2;
            // 
            // txbTableName
            // 
            this.txbTableName.Enabled = false;
            this.txbTableName.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTableName.Location = new System.Drawing.Point(162, 61);
            this.txbTableName.Name = "txbTableName";
            this.txbTableName.Size = new System.Drawing.Size(439, 33);
            this.txbTableName.TabIndex = 4;
            // 
            // txbTableStatus
            // 
            this.txbTableStatus.Enabled = false;
            this.txbTableStatus.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbTableStatus.Location = new System.Drawing.Point(162, 113);
            this.txbTableStatus.Name = "txbTableStatus";
            this.txbTableStatus.Size = new System.Drawing.Size(439, 33);
            this.txbTableStatus.TabIndex = 6;
            // 
            // btnTableAdd
            // 
            this.btnTableAdd.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.btnTableAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTableAdd.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnTableAdd.Location = new System.Drawing.Point(162, 165);
            this.btnTableAdd.Name = "btnTableAdd";
            this.btnTableAdd.Size = new System.Drawing.Size(127, 55);
            this.btnTableAdd.TabIndex = 7;
            this.btnTableAdd.Text = "Thêm";
            this.btnTableAdd.UseVisualStyleBackColor = true;
            this.btnTableAdd.Click += new System.EventHandler(this.btnTableAdd_Click);
            // 
            // btnTableEdit
            // 
            this.btnTableEdit.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.btnTableEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTableEdit.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnTableEdit.Location = new System.Drawing.Point(307, 165);
            this.btnTableEdit.Name = "btnTableEdit";
            this.btnTableEdit.Size = new System.Drawing.Size(139, 55);
            this.btnTableEdit.TabIndex = 8;
            this.btnTableEdit.Text = "Sửa";
            this.btnTableEdit.UseVisualStyleBackColor = true;
            this.btnTableEdit.Click += new System.EventHandler(this.btnTableEdit_Click);
            // 
            // btnTableDel
            // 
            this.btnTableDel.BackgroundImage = global::Coffee.Properties.Resources.color6;
            this.btnTableDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTableDel.Font = new System.Drawing.Font("Calibri", 15F);
            this.btnTableDel.Location = new System.Drawing.Point(468, 165);
            this.btnTableDel.Name = "btnTableDel";
            this.btnTableDel.Size = new System.Drawing.Size(133, 55);
            this.btnTableDel.TabIndex = 9;
            this.btnTableDel.Text = "Xóa";
            this.btnTableDel.UseVisualStyleBackColor = true;
            this.btnTableDel.Click += new System.EventHandler(this.btnTableDel_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackgroundImage = global::Coffee.Properties.Resources.color7;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1156, 717);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh mục";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.BackgroundImage = global::Coffee.Properties.Resources.color7;
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txbCateName);
            this.groupBox1.Controls.Add(this.txbCateID);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.btnCateDel);
            this.groupBox1.Controls.Add(this.btnCateEdit);
            this.groupBox1.Controls.Add(this.btnCateAdd);
            this.groupBox1.Controls.Add(this.dtgvCategory);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 711);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách danh mục";
            // 
            // dtgvCategory
            // 
            this.dtgvCategory.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvCategory.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvCategory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvCategory.Location = new System.Drawing.Point(3, 253);
            this.dtgvCategory.Name = "dtgvCategory";
            this.dtgvCategory.RowHeadersWidth = 51;
            this.dtgvCategory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvCategory.Size = new System.Drawing.Size(291, 455);
            this.dtgvCategory.TabIndex = 0;
            this.dtgvCategory.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvCategory_CellClick);
            // 
            // btnCateAdd
            // 
            this.btnCateAdd.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCateAdd.BackgroundImage = global::Coffee.Properties.Resources.image4;
            this.btnCateAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCateAdd.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCateAdd.Location = new System.Drawing.Point(11, 28);
            this.btnCateAdd.Name = "btnCateAdd";
            this.btnCateAdd.Size = new System.Drawing.Size(280, 40);
            this.btnCateAdd.TabIndex = 1;
            this.btnCateAdd.Text = "Thêm";
            this.btnCateAdd.UseVisualStyleBackColor = false;
            this.btnCateAdd.Click += new System.EventHandler(this.btnCateAdd_Click);
            // 
            // btnCateEdit
            // 
            this.btnCateEdit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnCateEdit.BackgroundImage = global::Coffee.Properties.Resources.image4;
            this.btnCateEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCateEdit.Location = new System.Drawing.Point(11, 74);
            this.btnCateEdit.Name = "btnCateEdit";
            this.btnCateEdit.Size = new System.Drawing.Size(280, 40);
            this.btnCateEdit.TabIndex = 2;
            this.btnCateEdit.Text = "Sửa";
            this.btnCateEdit.UseVisualStyleBackColor = false;
            this.btnCateEdit.Click += new System.EventHandler(this.btnCateEdit_Click);
            // 
            // btnCateDel
            // 
            this.btnCateDel.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnCateDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCateDel.Location = new System.Drawing.Point(11, 121);
            this.btnCateDel.Name = "btnCateDel";
            this.btnCateDel.Size = new System.Drawing.Size(280, 40);
            this.btnCateDel.TabIndex = 3;
            this.btnCateDel.Text = "Xóa";
            this.btnCateDel.UseVisualStyleBackColor = false;
            this.btnCateDel.Click += new System.EventHandler(this.btnCateDel_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Location = new System.Drawing.Point(6, 175);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(23, 19);
            this.label8.TabIndex = 13;
            this.label8.Text = "ID";
            // 
            // txbCateID
            // 
            this.txbCateID.Enabled = false;
            this.txbCateID.Location = new System.Drawing.Point(52, 167);
            this.txbCateID.Name = "txbCateID";
            this.txbCateID.Size = new System.Drawing.Size(239, 27);
            this.txbCateID.TabIndex = 14;
            // 
            // txbCateName
            // 
            this.txbCateName.Enabled = false;
            this.txbCateName.Location = new System.Drawing.Point(52, 210);
            this.txbCateName.Name = "txbCateName";
            this.txbCateName.Size = new System.Drawing.Size(239, 27);
            this.txbCateName.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Location = new System.Drawing.Point(3, 218);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(32, 19);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tên";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.BackgroundImage = global::Coffee.Properties.Resources.color7;
            this.groupBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox2.Controls.Add(this.groupBox5);
            this.groupBox2.Controls.Add(this.nbuFoodPrice);
            this.groupBox2.Controls.Add(this.cbbFoodCate);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txbFoodName);
            this.groupBox2.Controls.Add(this.txbFoodID);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnFoodDel);
            this.groupBox2.Controls.Add(this.btnFoodEdit);
            this.groupBox2.Controls.Add(this.btnFoodAdd);
            this.groupBox2.Controls.Add(this.dtgvFood);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBox2.Location = new System.Drawing.Point(306, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(847, 711);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách món ăn";
            // 
            // dtgvFood
            // 
            this.dtgvFood.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgvFood.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgvFood.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvFood.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgvFood.Location = new System.Drawing.Point(3, 253);
            this.dtgvFood.Name = "dtgvFood";
            this.dtgvFood.RowHeadersWidth = 51;
            this.dtgvFood.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgvFood.Size = new System.Drawing.Size(841, 455);
            this.dtgvFood.TabIndex = 1;
            this.dtgvFood.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgvFood_CellClick);
            // 
            // btnFoodAdd
            // 
            this.btnFoodAdd.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnFoodAdd.BackgroundImage = global::Coffee.Properties.Resources.image4;
            this.btnFoodAdd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoodAdd.Location = new System.Drawing.Point(6, 28);
            this.btnFoodAdd.Name = "btnFoodAdd";
            this.btnFoodAdd.Size = new System.Drawing.Size(271, 40);
            this.btnFoodAdd.TabIndex = 4;
            this.btnFoodAdd.Text = "Thêm";
            this.btnFoodAdd.UseVisualStyleBackColor = false;
            this.btnFoodAdd.Click += new System.EventHandler(this.btnFoodAdd_Click);
            // 
            // btnFoodEdit
            // 
            this.btnFoodEdit.BackColor = System.Drawing.Color.LemonChiffon;
            this.btnFoodEdit.BackgroundImage = global::Coffee.Properties.Resources.image4;
            this.btnFoodEdit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoodEdit.Location = new System.Drawing.Point(6, 73);
            this.btnFoodEdit.Name = "btnFoodEdit";
            this.btnFoodEdit.Size = new System.Drawing.Size(271, 40);
            this.btnFoodEdit.TabIndex = 5;
            this.btnFoodEdit.Text = "Sửa";
            this.btnFoodEdit.UseVisualStyleBackColor = false;
            this.btnFoodEdit.Click += new System.EventHandler(this.btnFoodEdit_Click);
            // 
            // btnFoodDel
            // 
            this.btnFoodDel.BackColor = System.Drawing.Color.DarkSalmon;
            this.btnFoodDel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoodDel.Location = new System.Drawing.Point(6, 121);
            this.btnFoodDel.Name = "btnFoodDel";
            this.btnFoodDel.Size = new System.Drawing.Size(271, 40);
            this.btnFoodDel.TabIndex = 6;
            this.btnFoodDel.Text = "Xóa";
            this.btnFoodDel.UseVisualStyleBackColor = false;
            this.btnFoodDel.Click += new System.EventHandler(this.btnFoodDel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(426, 44);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 19);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID";
            // 
            // txbFoodID
            // 
            this.txbFoodID.Enabled = false;
            this.txbFoodID.Location = new System.Drawing.Point(459, 36);
            this.txbFoodID.Name = "txbFoodID";
            this.txbFoodID.Size = new System.Drawing.Size(311, 27);
            this.txbFoodID.TabIndex = 8;
            // 
            // txbFoodName
            // 
            this.txbFoodName.Enabled = false;
            this.txbFoodName.Location = new System.Drawing.Point(459, 79);
            this.txbFoodName.Name = "txbFoodName";
            this.txbFoodName.Size = new System.Drawing.Size(311, 27);
            this.txbFoodName.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(414, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 19);
            this.label4.TabIndex = 12;
            this.label4.Text = "Tên";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(359, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "Danh mục";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(415, 170);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 19);
            this.label6.TabIndex = 14;
            this.label6.Text = "Giá";
            // 
            // cbbFoodCate
            // 
            this.cbbFoodCate.Enabled = false;
            this.cbbFoodCate.FormattingEnabled = true;
            this.cbbFoodCate.Location = new System.Drawing.Point(459, 123);
            this.cbbFoodCate.Name = "cbbFoodCate";
            this.cbbFoodCate.Size = new System.Drawing.Size(311, 27);
            this.cbbFoodCate.TabIndex = 15;
            // 
            // nbuFoodPrice
            // 
            this.nbuFoodPrice.Enabled = false;
            this.nbuFoodPrice.Increment = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nbuFoodPrice.Location = new System.Drawing.Point(459, 168);
            this.nbuFoodPrice.Maximum = new decimal(new int[] {
            1000000000,
            0,
            0,
            0});
            this.nbuFoodPrice.Name = "nbuFoodPrice";
            this.nbuFoodPrice.Size = new System.Drawing.Size(311, 27);
            this.nbuFoodPrice.TabIndex = 18;
            this.nbuFoodPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.Transparent;
            this.groupBox5.Controls.Add(this.txbSearch);
            this.groupBox5.Location = new System.Drawing.Point(6, 167);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(271, 80);
            this.groupBox5.TabIndex = 19;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tìm kiếm";
            // 
            // txbSearch
            // 
            this.txbSearch.Location = new System.Drawing.Point(0, 31);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(271, 27);
            this.txbSearch.TabIndex = 16;
            this.txbSearch.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txbSearch_KeyPress);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1164, 749);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // fmManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1164, 749);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fmManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
         
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvTable)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvCategory)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvFood)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nbuFoodPrice)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btnTableDel;
        private System.Windows.Forms.Button btnTableEdit;
        private System.Windows.Forms.Button btnTableAdd;
        private System.Windows.Forms.TextBox txbTableStatus;
        private System.Windows.Forms.TextBox txbTableName;
        private System.Windows.Forms.TextBox txbTableID;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DataGridView dtgvTable;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.NumericUpDown nbuFoodPrice;
        private System.Windows.Forms.ComboBox cbbFoodCate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbFoodName;
        private System.Windows.Forms.TextBox txbFoodID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFoodDel;
        private System.Windows.Forms.Button btnFoodEdit;
        private System.Windows.Forms.Button btnFoodAdd;
        private System.Windows.Forms.DataGridView dtgvFood;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txbCateName;
        private System.Windows.Forms.TextBox txbCateID;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnCateDel;
        private System.Windows.Forms.Button btnCateEdit;
        private System.Windows.Forms.Button btnCateAdd;
        private System.Windows.Forms.DataGridView dtgvCategory;
        private System.Windows.Forms.TabControl tabControl1;
    }
}