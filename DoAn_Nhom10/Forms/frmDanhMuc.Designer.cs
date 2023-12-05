namespace DoAn_Nhom10.Forms
{
    partial class frmDanhMuc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMaDM = new Guna.UI2.WinForms.Guna2TextBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnThem = new FontAwesome.Sharp.IconButton();
            this.btnXoa = new FontAwesome.Sharp.IconButton();
            this.btnSua = new FontAwesome.Sharp.IconButton();
            this.btnLuu = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dgvDanhMuc = new Guna.UI2.WinForms.Guna2DataGridView();
            this.MaDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenDM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DemSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtTenDM = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnThemMoi = new FontAwesome.Sharp.IconButton();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label1.Size = new System.Drawing.Size(109, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "Mã danh mục";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(328, 0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 9, 0);
            this.label2.Size = new System.Drawing.Size(110, 45);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên danh mục";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMaDM
            // 
            this.txtMaDM.BorderRadius = 3;
            this.txtMaDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaDM.DefaultText = "";
            this.txtMaDM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMaDM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMaDM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMaDM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaDM.ForeColor = System.Drawing.Color.Black;
            this.txtMaDM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMaDM.Location = new System.Drawing.Point(118, 5);
            this.txtMaDM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtMaDM.Name = "txtMaDM";
            this.txtMaDM.PasswordChar = '\0';
            this.txtMaDM.PlaceholderText = "";
            this.txtMaDM.SelectedText = "";
            this.txtMaDM.Size = new System.Drawing.Size(198, 35);
            this.txtMaDM.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.28935F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24.22503F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.43284F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.25373F));
            this.tableLayoutPanel1.Controls.Add(this.txtMaDM, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(20, 19);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(871, 59);
            this.tableLayoutPanel1.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnThem);
            this.panel1.Controls.Add(this.btnXoa);
            this.panel1.Controls.Add(this.btnSua);
            this.panel1.Controls.Add(this.btnLuu);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(20, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(871, 56);
            this.panel1.TabIndex = 24;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.Silver;
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.Enabled = false;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnThem.IconColor = System.Drawing.Color.White;
            this.btnThem.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnThem.IconSize = 21;
            this.btnThem.Location = new System.Drawing.Point(3, 6);
            this.btnThem.Name = "btnThem";
            this.btnThem.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnThem.Size = new System.Drawing.Size(100, 45);
            this.btnThem.TabIndex = 26;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnThem.UseVisualStyleBackColor = false;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(92)))), ((int)(((byte)(254)))));
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnXoa.IconColor = System.Drawing.Color.White;
            this.btnXoa.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnXoa.IconSize = 21;
            this.btnXoa.Location = new System.Drawing.Point(130, 6);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnXoa.Size = new System.Drawing.Size(100, 45);
            this.btnXoa.TabIndex = 27;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(92)))), ((int)(((byte)(254)))));
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.FlatAppearance.BorderSize = 0;
            this.btnSua.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.ForeColor = System.Drawing.Color.White;
            this.btnSua.IconChar = FontAwesome.Sharp.IconChar.PenToSquare;
            this.btnSua.IconColor = System.Drawing.Color.White;
            this.btnSua.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnSua.IconSize = 21;
            this.btnSua.Location = new System.Drawing.Point(261, 6);
            this.btnSua.Name = "btnSua";
            this.btnSua.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnSua.Size = new System.Drawing.Size(100, 45);
            this.btnSua.TabIndex = 28;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSua.UseVisualStyleBackColor = false;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(92)))), ((int)(((byte)(254)))));
            this.btnLuu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnLuu.IconColor = System.Drawing.Color.White;
            this.btnLuu.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnLuu.IconSize = 21;
            this.btnLuu.Location = new System.Drawing.Point(379, 6);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Padding = new System.Windows.Forms.Padding(9, 0, 0, 0);
            this.btnLuu.Size = new System.Drawing.Size(147, 45);
            this.btnLuu.TabIndex = 29;
            this.btnLuu.Text = "Lưu thay đổi";
            this.btnLuu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLuu.UseVisualStyleBackColor = false;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.White;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel2.Controls.Add(this.dgvDanhMuc, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(20, 134);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 23, 0, 0);
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(871, 361);
            this.tableLayoutPanel2.TabIndex = 25;
            // 
            // dgvDanhMuc
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDanhMuc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Padding = new System.Windows.Forms.Padding(6);
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDanhMuc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDanhMuc.ColumnHeadersHeight = 35;
            this.dgvDanhMuc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDM,
            this.TenDM,
            this.DemSP});
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDanhMuc.DefaultCellStyle = dataGridViewCellStyle12;
            this.dgvDanhMuc.Dock = System.Windows.Forms.DockStyle.Top;
            this.dgvDanhMuc.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.Location = new System.Drawing.Point(3, 26);
            this.dgvDanhMuc.Name = "dgvDanhMuc";
            this.dgvDanhMuc.RowHeadersVisible = false;
            this.dgvDanhMuc.RowTemplate.Height = 24;
            this.dgvDanhMuc.Size = new System.Drawing.Size(865, 332);
            this.dgvDanhMuc.TabIndex = 17;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvDanhMuc.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvDanhMuc.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDanhMuc.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvDanhMuc.ThemeStyle.ReadOnly = false;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.01739F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvDanhMuc.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvDanhMuc.ThemeStyle.RowsStyle.Height = 24;
            this.dgvDanhMuc.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvDanhMuc.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // MaDM
            // 
            this.MaDM.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.MaDM.DataPropertyName = "MaDM";
            this.MaDM.FillWeight = 127.9011F;
            this.MaDM.HeaderText = "Mã danh mục";
            this.MaDM.Name = "MaDM";
            this.MaDM.ReadOnly = true;
            this.MaDM.Width = 270;
            // 
            // TenDM
            // 
            this.TenDM.DataPropertyName = "TenDM";
            this.TenDM.FillWeight = 217.6746F;
            this.TenDM.HeaderText = "Tên danh mục";
            this.TenDM.Name = "TenDM";
            // 
            // DemSP
            // 
            this.DemSP.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.DemSP.DataPropertyName = "DemSP";
            this.DemSP.FillWeight = 41.47238F;
            this.DemSP.HeaderText = "Số sản phẩm";
            this.DemSP.Name = "DemSP";
            this.DemSP.ReadOnly = true;
            this.DemSP.Width = 210;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnThemMoi);
            this.panel2.Controls.Add(this.txtTenDM);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(444, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(424, 53);
            this.panel2.TabIndex = 15;
            // 
            // txtTenDM
            // 
            this.txtTenDM.BorderRadius = 3;
            this.txtTenDM.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDM.DefaultText = "";
            this.txtTenDM.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtTenDM.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtTenDM.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDM.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtTenDM.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDM.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDM.ForeColor = System.Drawing.Color.Black;
            this.txtTenDM.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtTenDM.Location = new System.Drawing.Point(3, 2);
            this.txtTenDM.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.txtTenDM.Name = "txtTenDM";
            this.txtTenDM.PasswordChar = '\0';
            this.txtTenDM.PlaceholderText = "";
            this.txtTenDM.SelectedText = "";
            this.txtTenDM.Size = new System.Drawing.Size(332, 35);
            this.txtTenDM.TabIndex = 16;
            // 
            // btnThemMoi
            // 
            this.btnThemMoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(92)))), ((int)(((byte)(254)))));
            this.btnThemMoi.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThemMoi.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemMoi.ForeColor = System.Drawing.Color.White;
            this.btnThemMoi.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            this.btnThemMoi.IconColor = System.Drawing.Color.White;
            this.btnThemMoi.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnThemMoi.IconSize = 20;
            this.btnThemMoi.Location = new System.Drawing.Point(341, 0);
            this.btnThemMoi.Name = "btnThemMoi";
            this.btnThemMoi.Size = new System.Drawing.Size(38, 38);
            this.btnThemMoi.TabIndex = 30;
            this.btnThemMoi.UseVisualStyleBackColor = false;
            this.btnThemMoi.Click += new System.EventHandler(this.btnThemMoi_Click);
            // 
            // frmDanhMuc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 505);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmDanhMuc";
            this.Padding = new System.Windows.Forms.Padding(20, 19, 10, 10);
            this.Text = "Danh mục";
            this.Load += new System.EventHandler(this.frmDanhMuc_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDanhMuc)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtMaDM;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnThem;
        private FontAwesome.Sharp.IconButton btnXoa;
        private FontAwesome.Sharp.IconButton btnSua;
        private FontAwesome.Sharp.IconButton btnLuu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private Guna.UI2.WinForms.Guna2DataGridView dgvDanhMuc;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenDM;
        private System.Windows.Forms.DataGridViewTextBoxColumn DemSP;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnThemMoi;
        private Guna.UI2.WinForms.Guna2TextBox txtTenDM;
    }
}