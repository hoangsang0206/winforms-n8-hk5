using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom10.Forms
{
    public partial class frmNhapHang : Form
    {
        DataTable dtUser = UserLogged.dtUser;

        DBConnect dbConnect = new DBConnect();
        DataTable dt_PN = new DataTable();
        DataTable dt_CTPN = new DataTable();
        DataTable dt_SP = new DataTable();
        DataColumn[] key = new DataColumn[1];

        public frmNhapHang()
        {
            InitializeComponent();
        }

        //Load combobox danh mục
        private void loadCbBoxDanhMuc()
        {
            DataTable dt = new DataTable();
            string sql = "Select * From DanhMuc";

            dt = dbConnect.getDataTable(sql);
            cbboxDanhMuc.DataSource = dt;
            cbboxDanhMuc.DisplayMember = "TenDM";
            cbboxDanhMuc.ValueMember = "MaDM";
        }

        //Load combobox sản phẩm dựa vào mã danh mục
        private void loadCbBoxSanPham(string maDM)
        {
            cbboxSanPham.DataSource = null;
            string sql = "Select * From SanPham Where MaDM = '" + maDM + "'";

            DataTable dt = new DataTable();
            dt = dbConnect.getDataTable(sql);
            cbboxSanPham.DataSource = dt;
            cbboxSanPham.DisplayMember = "TenSP";
            cbboxSanPham.ValueMember = "MaSP";
        }

        private void frmNhapHang_Load(object sender, EventArgs e)
        {
            labelEmpName.Text = dtUser.Rows[0]["TenNV"].ToString();
            labelEmpPhone.Text = dtUser.Rows[0]["SoDT"].ToString();
        }

        //Thêm sản phẩm ------------------
        private void btnNhapHang_Click(object sender, EventArgs e)
        {
            if (cbboxSanPham.SelectedIndex < 0 || txtSoLuong.Text.Length <= 0 || txtTongTien.Text.Length <= 0)
            {
                MessageBox.Show("Dữ liệu không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow ctpnNewRow = dt_CTPN.NewRow();
            ctpnNewRow["MaPN"] = txtMaPN.Text;
            ctpnNewRow["MaSP"] = cbboxSanPham.SelectedValue.ToString();
            ctpnNewRow["SoLuong"] = txtSoLuong.Text;
            ctpnNewRow["GiaNhap"] = txtGiaNhap.Text;
            dt_CTPN.Rows.Add(ctpnNewRow);

            DataRow row = dt_SP.Rows.Find(ctpnNewRow["MaSP"].ToString());
            if (row != null)
            {
                row["GiaBan"] = ctpnNewRow["GiaNhap"];
                row["SoLuong"] = Convert.ToInt32(row["SoLuong"].ToString()) + Convert.ToInt32(ctpnNewRow["SoLuong"].ToString());
            }

            txtTongTien.Text = ((Convert.ToDecimal(txtTongTien.Text) + 
                Convert.ToDecimal(ctpnNewRow["GiaNhap"]) * Convert.ToInt32(ctpnNewRow["SoLuong"]))).ToString();

            txtSoLuong.Clear();
            txtGiaNhap.Clear();
            cbboxSanPham.SelectedIndex = -1;
            dgvChiTietPN.DataSource = dt_CTPN;
        }

        //
        private void btnTaoPN_Click(object sender, EventArgs e)
        {
            string sql = "Select * From PhieuNhap";
            dt_PN = dbConnect.getDataTable(sql);
            dt_CTPN.Columns.Add("MaPN");
            dt_CTPN.Columns.Add("MaSP");
            dt_CTPN.Columns.Add("SoLuong");
            dt_CTPN.Columns.Add("GiaNhap");

            txtTongTien.Text = "0";
            string dateNow = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            txtNgayNhap.Text = dateNow;
            string dateNowText = dateNow.Replace("/", "");

            DataTable dtt = new DataTable();
            string sql1 = "Select Top 1 * From PhieuNhap Where MaPN Like '%" + dateNowText + "%'Order By MaPN Desc";
            dtt = dbConnect.getDataTable(sql1);
            string maPN = "";

            if (dtt.Rows.Count <= 0)
            {
                maPN = "PN" + dateNowText + "001";
            }
            else
            {
                string maPNCuoi = dtt.Rows[0]["MaPN"].ToString();
                string kituCuoi = maPNCuoi.Substring(10, 3);
                int soPN = int.Parse(kituCuoi) + 1;
                string sPN = soPN.ToString().PadLeft(3, '0');

                maPN = "PN" + dateNowText + sPN;
            }

            txtMaPN.Text = maPN;
            loadCbBoxDanhMuc();
            cbboxDanhMuc.SelectedIndex = -1;

            string sql2 = "Select * From SanPham";
            dt_SP = dbConnect.getDataTable(sql2);
            key[0] = dt_SP.Columns[0];
            dt_SP.PrimaryKey = key;

            btnTaoPN.Enabled = false;
            btnTaoPN.BackColor = Color.LightGray;

            btnLuuPN.Enabled = true;
            btnNhapHang.Enabled = true;
            btnLuuPN.BackColor = Color.FromArgb(105, 92, 254);
            btnNhapHang.BackColor = Color.FromArgb(10, 148, 50);
        }   

        //
        private void btnLuuPN_Click(object sender, EventArgs e)
        {
            if (dt_CTPN.Rows.Count <= 0)
            {
                MessageBox.Show("Chưa nhập sản phẩm nào.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow newRow = dt_PN.NewRow();
            newRow["MaPN"] = txtMaPN.Text;
            newRow["NgayNhap"] = DateTime.Now;
            newRow["MaNV"] = UserLogged.dtUser.Rows[0]["MaNV"].ToString();
            newRow["TongTien"] = txtTongTien.Text;
            dt_PN.Rows.Add(newRow);

            string sql1 = "Select * From PhieuNhap";
            string sql2 = "Select * From ChiTietPN";
            string sql3 = "Select * From SanPham";

            int kq1 = dbConnect.updateDataTable(dt_PN, sql1);
            int kq2 = dbConnect.updateDataTable(dt_CTPN, sql2);
            int kq3 = dbConnect.updateDataTable(dt_SP, sql3);

            if (kq1 != 0 && kq2 != 0 && kq3 != 0)
            {
                MessageBox.Show("Lưu phiếu nhập thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            btnHuyPN_Click(btnHuyPN, EventArgs.Empty);
        }

        private void btnHuyPN_Click(object sender, EventArgs e)
        {
            txtMaPN.Clear();
            txtTongTien.Clear();
            txtSoLuong.Clear();
            txtGiaNhap.Clear();
            txtTongTien.Clear();
            txtNgayNhap.Clear();

            cbboxDanhMuc.DataSource = null;
            cbboxSanPham.DataSource = null;

            btnTaoPN.Enabled = true;
            btnTaoPN.BackColor = Color.FromArgb(0, 148, 50);

            btnLuuPN.Enabled = false;
            btnNhapHang.Enabled = false;
            btnLuuPN.BackColor = Color.LightGray;
            btnNhapHang.BackColor = Color.LightGray;

            dt_CTPN.Rows.Clear();

            dt_PN = new DataTable();
            dt_CTPN = new DataTable();
            dt_SP = new DataTable();

        }

        private void cbboxDanhMuc_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbboxDanhMuc.SelectedIndex >= 0)
            {
                loadCbBoxSanPham(cbboxDanhMuc.SelectedValue.ToString());
            }
        }
    }
}
