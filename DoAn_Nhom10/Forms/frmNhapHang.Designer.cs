namespace DoAn_Nhom10.Forms
{
    partial class frmNhapHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNhapHang));
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnSaveImport = new FontAwesome.Sharp.IconButton();
            this.btnCreateImport = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDateImport = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtImportID = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPriceSum = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cbboxCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvImportDetail = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaPN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelEmpPhone = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelEmpName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.txtType = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaterial = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportDetail)).BeginInit();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.groupBox1, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1047, 192);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Controls.Add(this.btnSaveImport);
            this.groupBox1.Controls.Add(this.btnCreateImport);
            this.groupBox1.Controls.Add(this.tableLayoutPanel3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(9);
            this.groupBox1.Size = new System.Drawing.Size(1041, 186);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Phiếu nhập";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(92)))), ((int)(((byte)(254)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(476, 131);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(207, 50);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Hủy phiếu nhập";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSaveImport
            // 
            this.btnSaveImport.BackColor = System.Drawing.Color.Silver;
            this.btnSaveImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveImport.Enabled = false;
            this.btnSaveImport.FlatAppearance.BorderSize = 0;
            this.btnSaveImport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveImport.ForeColor = System.Drawing.Color.White;
            this.btnSaveImport.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnSaveImport.IconColor = System.Drawing.Color.White;
            this.btnSaveImport.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSaveImport.IconSize = 25;
            this.btnSaveImport.Location = new System.Drawing.Point(241, 131);
            this.btnSaveImport.Name = "btnSaveImport";
            this.btnSaveImport.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSaveImport.Size = new System.Drawing.Size(207, 50);
            this.btnSaveImport.TabIndex = 20;
            this.btnSaveImport.Text = "Lưu phiếu nhập";
            this.btnSaveImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveImport.UseVisualStyleBackColor = false;
            this.btnSaveImport.Click += new System.EventHandler(this.btnSaveImport_Click);
            // 
            // btnCreateImport
            // 
            this.btnCreateImport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(92)))), ((int)(((byte)(254)))));
            this.btnCreateImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateImport.FlatAppearance.BorderSize = 0;
            this.btnCreateImport.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateImport.ForeColor = System.Drawing.Color.White;
            this.btnCreateImport.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            this.btnCreateImport.IconColor = System.Drawing.Color.White;
            this.btnCreateImport.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnCreateImport.IconSize = 25;
            this.btnCreateImport.Location = new System.Drawing.Point(11, 131);
            this.btnCreateImport.Name = "btnCreateImport";
            this.btnCreateImport.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnCreateImport.Size = new System.Drawing.Size(202, 50);
            this.btnCreateImport.TabIndex = 19;
            this.btnCreateImport.Text = "Tạo phiếu nhập";
            this.btnCreateImport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCreateImport.UseVisualStyleBackColor = false;
            this.btnCreateImport.Click += new System.EventHandler(this.btnCreateImport_Click);
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 4;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34F));
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.txtDateImport, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.label7, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtImportID, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.txtPriceSum, 3, 0);
            this.tableLayoutPanel3.Controls.Add(this.label5, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(9, 29);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 2;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 49.27536F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.72464F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1023, 96);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Location = new System.Drawing.Point(3, 47);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label9.Size = new System.Drawing.Size(157, 39);
            this.label9.TabIndex = 4;
            this.label9.Text = "Ngày nhập";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtDateImport
            // 
            this.txtDateImport.BorderColor = System.Drawing.Color.DarkGray;
            this.txtDateImport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDateImport.DefaultText = "";
            this.txtDateImport.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtDateImport.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtDateImport.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateImport.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtDateImport.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateImport.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateImport.ForeColor = System.Drawing.Color.Black;
            this.txtDateImport.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtDateImport.Location = new System.Drawing.Point(167, 53);
            this.txtDateImport.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtDateImport.Name = "txtDateImport";
            this.txtDateImport.PasswordChar = '\0';
            this.txtDateImport.PlaceholderText = "";
            this.txtDateImport.ReadOnly = true;
            this.txtDateImport.SelectedText = "";
            this.txtDateImport.Size = new System.Drawing.Size(236, 34);
            this.txtDateImport.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Top;
            this.label7.Location = new System.Drawing.Point(3, 0);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label7.Size = new System.Drawing.Size(157, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Mã phiếu nhập";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtImportID
            // 
            this.txtImportID.BorderColor = System.Drawing.Color.DarkGray;
            this.txtImportID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtImportID.DefaultText = "";
            this.txtImportID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtImportID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtImportID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImportID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtImportID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImportID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtImportID.ForeColor = System.Drawing.Color.Black;
            this.txtImportID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtImportID.Location = new System.Drawing.Point(167, 6);
            this.txtImportID.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtImportID.Name = "txtImportID";
            this.txtImportID.PasswordChar = '\0';
            this.txtImportID.PlaceholderText = "";
            this.txtImportID.ReadOnly = true;
            this.txtImportID.SelectedText = "";
            this.txtImportID.Size = new System.Drawing.Size(236, 34);
            this.txtImportID.TabIndex = 1;
            // 
            // txtPriceSum
            // 
            this.txtPriceSum.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPriceSum.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPriceSum.DefaultText = "";
            this.txtPriceSum.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPriceSum.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPriceSum.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceSum.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPriceSum.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceSum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPriceSum.ForeColor = System.Drawing.Color.Black;
            this.txtPriceSum.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPriceSum.Location = new System.Drawing.Point(677, 6);
            this.txtPriceSum.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPriceSum.Name = "txtPriceSum";
            this.txtPriceSum.PasswordChar = '\0';
            this.txtPriceSum.PlaceholderText = "";
            this.txtPriceSum.ReadOnly = true;
            this.txtPriceSum.SelectedText = "";
            this.txtPriceSum.Size = new System.Drawing.Size(276, 34);
            this.txtPriceSum.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(513, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label5.Size = new System.Drawing.Size(157, 39);
            this.label5.TabIndex = 7;
            this.label5.Text = "Tổng giá trị";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Location = new System.Drawing.Point(502, 97);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label8.Size = new System.Drawing.Size(166, 39);
            this.label8.TabIndex = 2;
            this.label8.Text = "Danh mục";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cbboxCategories
            // 
            this.cbboxCategories.BackColor = System.Drawing.Color.Transparent;
            this.cbboxCategories.BorderColor = System.Drawing.Color.DarkGray;
            this.cbboxCategories.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbboxCategories.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbboxCategories.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxCategories.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbboxCategories.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbboxCategories.ForeColor = System.Drawing.Color.Black;
            this.cbboxCategories.ItemHeight = 30;
            this.cbboxCategories.Location = new System.Drawing.Point(674, 100);
            this.cbboxCategories.Name = "cbboxCategories";
            this.cbboxCategories.Size = new System.Drawing.Size(303, 36);
            this.cbboxCategories.TabIndex = 9;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Top;
            this.label10.Location = new System.Drawing.Point(502, 50);
            this.label10.Name = "label10";
            this.label10.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label10.Size = new System.Drawing.Size(166, 39);
            this.label10.TabIndex = 31;
            this.label10.Text = "Số lượng";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 202);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 4, 0, 0);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 438);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tableLayoutPanel5);
            this.groupBox2.Controls.Add(this.tableLayoutPanel4);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.Location = new System.Drawing.Point(3, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1041, 428);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thêm sản phẩm";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 274F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.dgvImportDetail, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel6, 0, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 170);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(1035, 255);
            this.tableLayoutPanel5.TabIndex = 25;
            // 
            // dgvImportDetail
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvImportDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvImportDetail.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvImportDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvImportDetail.ColumnHeadersHeight = 35;
            this.dgvImportDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPN,
            this.MaSP,
            this.GiaBan,
            this.SoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvImportDetail.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvImportDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvImportDetail.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvImportDetail.Location = new System.Drawing.Point(277, 3);
            this.dgvImportDetail.Name = "dgvImportDetail";
            this.dgvImportDetail.RowHeadersVisible = false;
            this.dgvImportDetail.RowTemplate.Height = 24;
            this.dgvImportDetail.Size = new System.Drawing.Size(755, 249);
            this.dgvImportDetail.TabIndex = 21;
            this.dgvImportDetail.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvImportDetail.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvImportDetail.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvImportDetail.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvImportDetail.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvImportDetail.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvImportDetail.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvImportDetail.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvImportDetail.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvImportDetail.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvImportDetail.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvImportDetail.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvImportDetail.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvImportDetail.ThemeStyle.ReadOnly = false;
            this.dgvImportDetail.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvImportDetail.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvImportDetail.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvImportDetail.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvImportDetail.ThemeStyle.RowsStyle.Height = 24;
            this.dgvImportDetail.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvImportDetail.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaPN
            // 
            this.MaPN.DataPropertyName = "MaPN";
            this.MaPN.FillWeight = 104.322F;
            this.MaPN.HeaderText = "Mã phiếu nhập";
            this.MaPN.Name = "MaPN";
            this.MaPN.ReadOnly = true;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.FillWeight = 177.5453F;
            this.MaSP.HeaderText = "Mã sản phẩm";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.FillWeight = 123.6163F;
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            this.GiaBan.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.FillWeight = 81.56455F;
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 1;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btnAdd, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.groupBox3, 0, 1);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 2;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.39274F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 72.60726F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(268, 249);
            this.tableLayoutPanel6.TabIndex = 22;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.Silver;
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Enabled = false;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnAdd.IconSize = 25;
            this.btnAdd.Location = new System.Drawing.Point(3, 3);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnAdd.Size = new System.Drawing.Size(175, 50);
            this.btnAdd.TabIndex = 20;
            this.btnAdd.Text = "Thêm sản phẩm";
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelEmpPhone);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.labelEmpName);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(3, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(262, 175);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin nhân viên";
            // 
            // labelEmpPhone
            // 
            this.labelEmpPhone.AutoSize = true;
            this.labelEmpPhone.Location = new System.Drawing.Point(69, 72);
            this.labelEmpPhone.Name = "labelEmpPhone";
            this.labelEmpPhone.Size = new System.Drawing.Size(49, 20);
            this.labelEmpPhone.TabIndex = 7;
            this.labelEmpPhone.Text = "Số ĐT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "SĐT: ";
            // 
            // labelEmpName
            // 
            this.labelEmpName.AutoSize = true;
            this.labelEmpName.Location = new System.Drawing.Point(69, 37);
            this.labelEmpName.Name = "labelEmpName";
            this.labelEmpName.Size = new System.Drawing.Size(56, 20);
            this.labelEmpName.TabIndex = 5;
            this.labelEmpName.Text = "Tên NV";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Họ tên:";
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 4;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.20538F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.69866F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel4.Controls.Add(this.txtType, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.label12, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtPrice, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.txtMaterial, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.label8, 2, 2);
            this.tableLayoutPanel4.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.label11, 0, 2);
            this.tableLayoutPanel4.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.cbboxCategories, 3, 2);
            this.tableLayoutPanel4.Controls.Add(this.txtProductName, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.txtQuantity, 3, 1);
            this.tableLayoutPanel4.Controls.Add(this.label10, 2, 1);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 23);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 34.13334F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.53333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1035, 147);
            this.tableLayoutPanel4.TabIndex = 24;
            // 
            // txtType
            // 
            this.txtType.BorderColor = System.Drawing.Color.DarkGray;
            this.txtType.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtType.DefaultText = "";
            this.txtType.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtType.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtType.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtType.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtType.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.ForeColor = System.Drawing.Color.Black;
            this.txtType.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtType.Location = new System.Drawing.Point(675, 6);
            this.txtType.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.PlaceholderText = "";
            this.txtType.SelectedText = "";
            this.txtType.Size = new System.Drawing.Size(302, 34);
            this.txtType.TabIndex = 35;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Location = new System.Drawing.Point(502, 0);
            this.label12.Name = "label12";
            this.label12.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label12.Size = new System.Drawing.Size(166, 39);
            this.label12.TabIndex = 21;
            this.label12.Text = "Kiểu dáng";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrice
            // 
            this.txtPrice.BorderColor = System.Drawing.Color.DarkGray;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.DefaultText = "";
            this.txtPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPrice.Location = new System.Drawing.Point(159, 56);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(286, 34);
            this.txtPrice.TabIndex = 24;
            // 
            // txtMaterial
            // 
            this.txtMaterial.BorderColor = System.Drawing.Color.DarkGray;
            this.txtMaterial.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaterial.DefaultText = "";
            this.txtMaterial.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaterial.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaterial.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaterial.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaterial.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaterial.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaterial.ForeColor = System.Drawing.Color.Black;
            this.txtMaterial.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaterial.Location = new System.Drawing.Point(159, 103);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.PasswordChar = '\0';
            this.txtMaterial.PlaceholderText = "";
            this.txtMaterial.SelectedText = "";
            this.txtMaterial.Size = new System.Drawing.Size(286, 34);
            this.txtMaterial.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(3, 50);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label6.Size = new System.Drawing.Size(149, 39);
            this.label6.TabIndex = 28;
            this.label6.Text = "Giá bán";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Top;
            this.label11.Location = new System.Drawing.Point(3, 97);
            this.label11.Name = "label11";
            this.label11.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label11.Size = new System.Drawing.Size(149, 39);
            this.label11.TabIndex = 32;
            this.label11.Text = "Chất liệu";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label3.Size = new System.Drawing.Size(149, 39);
            this.label3.TabIndex = 11;
            this.label3.Text = "Tên sản phẩm";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductName
            // 
            this.txtProductName.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProductName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductName.DefaultText = "";
            this.txtProductName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.ForeColor = System.Drawing.Color.Black;
            this.txtProductName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductName.Location = new System.Drawing.Point(159, 6);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(286, 34);
            this.txtProductName.TabIndex = 31;
            // 
            // txtQuantity
            // 
            this.txtQuantity.BorderColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.DefaultText = "";
            this.txtQuantity.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtQuantity.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtQuantity.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtQuantity.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.ForeColor = System.Drawing.Color.Black;
            this.txtQuantity.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtQuantity.Location = new System.Drawing.Point(675, 56);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(302, 34);
            this.txtQuantity.TabIndex = 26;
            // 
            // frmNhapHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 653);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmNhapHang";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Thêm sản phẩm mới";
            this.Load += new System.EventHandler(this.AddProductsForm_Load);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvImportDetail)).EndInit();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtImportID;
        private System.Windows.Forms.Label label9;
        private Guna.UI2.WinForms.Guna2TextBox txtDateImport;
        private System.Windows.Forms.Label label8;
        private FontAwesome.Sharp.IconButton btnSaveImport;
        private FontAwesome.Sharp.IconButton btnCreateImport;
        private System.Windows.Forms.Label label5;
        private Guna.UI2.WinForms.Guna2TextBox txtPriceSum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2DataGridView dgvImportDetail;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Label label11;
        private Guna.UI2.WinForms.Guna2TextBox txtMaterial;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxCategories;
        private System.Windows.Forms.Label label12;
        private Guna.UI2.WinForms.Guna2TextBox txtType;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label labelEmpPhone;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelEmpName;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaPN;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}