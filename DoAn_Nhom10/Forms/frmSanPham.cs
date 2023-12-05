using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace DoAn_Nhom10.Forms
{
    public partial class frmSanPham : Form
    {
        DBConnect dbConnect = new DBConnect();
        DataTable dt_DanhMuc = new DataTable();
        DataTable dt_SanPham = new DataTable();
        DataColumn[] key = new DataColumn[1];

        public frmSanPham()
        {
            InitializeComponent();
        }

        //Data binding
        private void dataBinding(DataTable dt)
        {
            txtMaSP.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            txtChatLieu.DataBindings.Clear();
            txtKieuDang.DataBindings.Clear();
            cbboxDanhMuc.DataBindings.Clear();

            txtMaSP.DataBindings.Add("Text", dt, "MaSP");
            txtTenSP.DataBindings.Add("Text", dt, "TenSP");
            txtChatLieu.DataBindings.Add("Text", dt, "ChatLieu");
            txtKieuDang.DataBindings.Add("Text", dt, "KieuDang");
            cbboxDanhMuc.DataBindings.Add("SelectedValue", dt, "MaDM");
        }

        //Load danh mục
        private void loadCbBoxDanhMuc()
        {
            string sqlQuery = "Select * From DanhMuc";


            dt_DanhMuc = dbConnect.getDataTable(sqlQuery);
            cbboxDanhMuc.DataSource = dt_DanhMuc;
            cbboxDanhMuc.DisplayMember = "TenDM";
            cbboxDanhMuc.ValueMember = "MaDM";
        }

        //Load sản phẩm
        private void loadDGVSanPham()
        {
            string sqlQuery = "Select MaSP, TenSP, ChatLieu, KieuDang, GiaBan, SanPham.MaDM, SoLuong, DanhMuc.TenDM " +
                               "From SanPham LEFT JOIN DanhMuc ON SanPham.MaDM = DanhMuc.MaDM";
 
            dt_SanPham = dbConnect.getDataTable(sqlQuery);
            dgvSanPham.DataSource = dt_SanPham;
            dgvSanPham.Columns["MaDM"].Visible = false;
            dataBinding(dt_SanPham);
            key[0] = dt_SanPham.Columns[0];
            dt_SanPham.PrimaryKey = key;
        }

        //--
        private void frmSanPham_Load(object sender, EventArgs e)
        {
            loadCbBoxDanhMuc();
            loadDGVSanPham();
        }

        //--Kiểm tra xem sản phẩm đã tồn tại chưa
        private bool ktTonTaiSP(string maSP)
        {
            string sqlQuery = "Select Count(*) From SanPham Where MaSP = '" + maSP + "'";

            int result = dbConnect.getScalar(sqlQuery);

            if (result != 0)
            {
                return true;
            }

            return false;
        }

        private bool ktSanPhamTrong_HD_PN(string maSP)
        {
            string sql1 = "Select Count(*) From ChiTietHD Where MaSP = '" + maSP + "'";
            string sql2 = "Select Count(*) From ChiTietPN Where MaSP = '" + maSP + "'";

            int demSPTrongCTHD = dbConnect.getScalar(sql1);
            int demSPTrongCTPN = dbConnect.getScalar(sql2);

            if (demSPTrongCTHD > 0 || demSPTrongCTPN > 0)
            {
                return true;
            }

            return false;
        }

        //Xóa sản phẩm ---------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ktSanPhamTrong_HD_PN(txtMaSP.Text))
            {
                MessageBox.Show("Không thể xóa sản phẩm này.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult r = MessageBox.Show("Xóa sản phẩm này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                DataRow row = dt_SanPham.Rows.Find(txtMaSP.Text);

                if (row != null)
                {
                    row.Delete();
                    MessageBox.Show("Xóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }  
            }  
        }

        //Sửa -------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt_SanPham.Rows.Find(txtMaSP.Text);

            if (row != null)
            {
                row["TenSP"] = txtTenSP.Text;
                row["KieuDang"] = txtKieuDang.Text;
                row["ChatLieu"] = txtChatLieu.Text;
                row["MaDM"] = cbboxDanhMuc.SelectedValue.ToString();
                row["TenDM"] = cbboxDanhMuc.Text;
                MessageBox.Show("Sửa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }  
        }


        //Thêm sản phẩm  ------------------------------------
        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaSP.Clear();
            txtTenSP.Clear();
            txtChatLieu.Clear();
            txtKieuDang.Clear();
            txtMaSP.DataBindings.Clear();
            txtTenSP.DataBindings.Clear();
            txtChatLieu.DataBindings.Clear();
            txtKieuDang.DataBindings.Clear();

            txtMaSP.Enabled = true;
            txtMaSP.ReadOnly = false;

            dgvSanPham.ClearSelection();

            btnThem.Enabled = true;
            btnThem.BackColor = Color.FromArgb(0, 148, 50);

            btnThemMoi.IconChar = IconChar.Xmark;
            btnThemMoi.BackColor = Color.Red;
            btnThemMoi.IconFont = IconFont.Solid;

            btnThemMoi.Click -= btnThemMoi_Click;
            btnThemMoi.Click += btnHuy_Click;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaSP.Text.Length <= 0 || txtTenSP.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ktTonTaiSP(txtMaSP.Text) || dt_SanPham.Rows.Find(txtMaSP.Text) != null)
            {
                MessageBox.Show("Sản phẩm này này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow newRow = dt_SanPham.NewRow();
            newRow["MaSP"] = txtMaSP.Text;
            newRow["TenSP"] = txtTenSP.Text;
            newRow["MaDM"] = cbboxDanhMuc.SelectedValue.ToString();
            newRow["TenDM"] = cbboxDanhMuc.Text;
            newRow["ChatLieu"] = txtChatLieu.Text;
            newRow["KieuDang"] = txtKieuDang.Text;
            dt_SanPham.Rows.Add(newRow);


            txtMaSP.Clear();
            txtTenSP.Clear();
            txtChatLieu.Clear();
            txtKieuDang.Clear();
            txtMaSP.ReadOnly = true;
            txtMaSP.Enabled = false;
            btnThem.Enabled = false;
            btnThem.BackColor = Color.Silver;
            dataBinding(dt_SanPham);

            btnThemMoi.IconChar = IconChar.PlusSquare;
            btnThemMoi.BackColor = Color.FromArgb(0, 148, 50);
            btnThemMoi.IconFont = IconFont.Regular;
            btnThemMoi.Click -= btnHuy_Click;
            btnThemMoi.Click += btnThemMoi_Click;

            MessageBox.Show("Thêm thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaSP.ReadOnly = true;
            txtMaSP.Enabled = false;
            btnThem.Enabled = false;
            btnThem.BackColor = Color.Silver;

            btnThemMoi.IconChar = IconChar.PlusSquare;
            btnThemMoi.BackColor = Color.FromArgb(0, 148, 50);
            btnThemMoi.IconFont = IconFont.Regular;
            btnThemMoi.Click -= btnHuy_Click;
            btnThemMoi.Click += btnThemMoi_Click;

            dataBinding(dt_SanPham);
        }

        //-- Lưu thay đổi vào CSDL -----------------
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "Select * From SanPham";
            int kq = dbConnect.updateDataTable(dt_SanPham, sql);

            if (kq > 0)
            {
                MessageBox.Show("Lưu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

    }
}
