namespace DoAn_Nhom10.Forms
{
    partial class frmSanPham
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label13 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtProductName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtProductID = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbboxCategories = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtType = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtMaterial = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtQuantity = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnDelete = new FontAwesome.Sharp.IconButton();
            this.btnUpdate = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvProducts = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KieuDang = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChatLieu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GiaBan = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.35851F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.55225F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.01297F));
            this.tableLayoutPanel1.Controls.Add(this.label13, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.label6, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtPrice, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtProductName, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtProductID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbboxCategories, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.label5, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtType, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtMaterial, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtQuantity, 3, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(10, 10);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25.6F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 24.4F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1047, 202);
            this.tableLayoutPanel1.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.Dock = System.Windows.Forms.DockStyle.Top;
            this.label13.Location = new System.Drawing.Point(3, 150);
            this.label13.Name = "label13";
            this.label13.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label13.Size = new System.Drawing.Size(119, 45);
            this.label13.TabIndex = 32;
            this.label13.Text = "Kiểu dáng";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(3, 100);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label6.Size = new System.Drawing.Size(119, 45);
            this.label6.TabIndex = 28;
            this.label6.Text = "Chất liệu";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtPrice.Location = new System.Drawing.Point(128, 55);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.PasswordChar = '\0';
            this.txtPrice.PlaceholderText = "";
            this.txtPrice.SelectedText = "";
            this.txtPrice.Size = new System.Drawing.Size(274, 35);
            this.txtPrice.TabIndex = 25;
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
            this.txtProductName.Location = new System.Drawing.Point(560, 4);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.PasswordChar = '\0';
            this.txtProductName.PlaceholderText = "";
            this.txtProductName.SelectedText = "";
            this.txtProductName.Size = new System.Drawing.Size(384, 35);
            this.txtProductName.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label1.Size = new System.Drawing.Size(119, 45);
            this.label1.TabIndex = 9;
            this.label1.Text = "Mã sản phẩm";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtProductID
            // 
            this.txtProductID.BorderColor = System.Drawing.Color.DarkGray;
            this.txtProductID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtProductID.DefaultText = "";
            this.txtProductID.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtProductID.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtProductID.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductID.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtProductID.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductID.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductID.ForeColor = System.Drawing.Color.Black;
            this.txtProductID.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtProductID.Location = new System.Drawing.Point(128, 4);
            this.txtProductID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.PasswordChar = '\0';
            this.txtProductID.PlaceholderText = "";
            this.txtProductID.ReadOnly = true;
            this.txtProductID.SelectedText = "";
            this.txtProductID.Size = new System.Drawing.Size(274, 35);
            this.txtProductID.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(408, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label2.Size = new System.Drawing.Size(146, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tên sản phẩm";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(408, 51);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label4.Size = new System.Drawing.Size(146, 45);
            this.label4.TabIndex = 19;
            this.label4.Text = "Danh mục";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(3, 51);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label3.Size = new System.Drawing.Size(119, 45);
            this.label3.TabIndex = 16;
            this.label3.Text = "Giá bán";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.cbboxCategories.ItemHeight = 33;
            this.cbboxCategories.Location = new System.Drawing.Point(560, 54);
            this.cbboxCategories.Name = "cbboxCategories";
            this.cbboxCategories.Size = new System.Drawing.Size(384, 39);
            this.cbboxCategories.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(408, 100);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.label5.Size = new System.Drawing.Size(146, 45);
            this.label5.TabIndex = 30;
            this.label5.Text = "Số lượng:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.txtType.Location = new System.Drawing.Point(128, 154);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtType.Name = "txtType";
            this.txtType.PasswordChar = '\0';
            this.txtType.PlaceholderText = "";
            this.txtType.SelectedText = "";
            this.txtType.Size = new System.Drawing.Size(274, 35);
            this.txtType.TabIndex = 29;
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
            this.txtMaterial.Location = new System.Drawing.Point(128, 104);
            this.txtMaterial.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMaterial.Name = "txtMaterial";
            this.txtMaterial.PasswordChar = '\0';
            this.txtMaterial.PlaceholderText = "";
            this.txtMaterial.SelectedText = "";
            this.txtMaterial.Size = new System.Drawing.Size(274, 35);
            this.txtMaterial.TabIndex = 33;
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
            this.txtQuantity.Location = new System.Drawing.Point(561, 106);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.PlaceholderText = "";
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(383, 38);
            this.txtQuantity.TabIndex = 34;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel3.Controls.Add(this.btnDelete, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.btnUpdate, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(10, 212);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1047, 65);
            this.tableLayoutPanel3.TabIndex = 27;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(92)))), ((int)(((byte)(254)))));
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnDelete.IconColor = System.Drawing.Color.White;
            this.btnDelete.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnDelete.IconSize = 25;
            this.btnDelete.Location = new System.Drawing.Point(3, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnDelete.Size = new System.Drawing.Size(197, 50);
            this.btnDelete.TabIndex = 19;
            this.btnDelete.Text = "Xóa sản phẩm";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(92)))), ((int)(((byte)(254)))));
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnUpdate.IconColor = System.Drawing.Color.White;
            this.btnUpdate.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnUpdate.IconSize = 25;
            this.btnUpdate.Location = new System.Drawing.Point(241, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnUpdate.Size = new System.Drawing.Size(197, 50);
            this.btnUpdate.TabIndex = 20;
            this.btnUpdate.Text = "Sửa sản phẩm";
            this.btnUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel2.Controls.Add(this.dgvProducts, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(10, 277);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 772F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1047, 329);
            this.tableLayoutPanel2.TabIndex = 28;
            // 
            // dgvProducts
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvProducts.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProducts.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProducts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProducts.ColumnHeadersHeight = 35;
            this.dgvProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.KieuDang,
            this.TenDM,
            this.ChatLieu,
            this.GiaBan,
            this.SoLuong});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProducts.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvProducts.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.Location = new System.Drawing.Point(3, 3);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowHeadersVisible = false;
            this.dgvProducts.RowTemplate.Height = 24;
            this.dgvProducts.Size = new System.Drawing.Size(1041, 323);
            this.dgvProducts.TabIndex = 17;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvProducts.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvProducts.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvProducts.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvProducts.ThemeStyle.ReadOnly = false;
            this.dgvProducts.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvProducts.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvProducts.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvProducts.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvProducts.ThemeStyle.RowsStyle.Height = 24;
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvProducts.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaSP
            // 
            this.MaSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaSP.DataPropertyName = "MaSP";
            this.MaSP.FillWeight = 12.95209F;
            this.MaSP.HeaderText = "Mã SP";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Width = 80;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "TenSP";
            this.TenSP.FillWeight = 127.9011F;
            this.TenSP.HeaderText = "Tên sản phẩm";
            this.TenSP.Name = "TenSP";
            // 
            // KieuDang
            // 
            this.KieuDang.DataPropertyName = "KieuDang";
            this.KieuDang.HeaderText = "Kiểu dáng";
            this.KieuDang.Name = "KieuDang";
            // 
            // TenDM
            // 
            this.TenDM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.TenDM.DataPropertyName = "TenDM";
            this.TenDM.FillWeight = 217.6746F;
            this.TenDM.HeaderText = "Danh mục";
            this.TenDM.Name = "TenDM";
            this.TenDM.Width = 200;
            // 
            // ChatLieu
            // 
            this.ChatLieu.DataPropertyName = "ChatLieu";
            this.ChatLieu.HeaderText = "Chất liệu";
            this.ChatLieu.Name = "ChatLieu";
            // 
            // GiaBan
            // 
            this.GiaBan.DataPropertyName = "GiaBan";
            this.GiaBan.HeaderText = "Giá bán";
            this.GiaBan.Name = "GiaBan";
            // 
            // SoLuong
            // 
            this.SoLuong.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Tồn kho";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.Width = 90;
            // 
            // frmSanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1067, 619);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.765218F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmSanPham";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Sản phẩm";
            this.Load += new System.EventHandler(this.ProductsForm_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPrice;
        private Guna.UI2.WinForms.Guna2TextBox txtProductName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2TextBox txtProductID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2ComboBox cbboxCategories;
        private Guna.UI2.WinForms.Guna2TextBox txtType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private FontAwesome.Sharp.IconButton btnDelete;
        private FontAwesome.Sharp.IconButton btnUpdate;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2TextBox txtMaterial;
        private Guna.UI2.WinForms.Guna2TextBox txtQuantity;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn KieuDang;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChatLieu;
        private System.Windows.Forms.DataGridViewTextBoxColumn GiaBan;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
    }
}