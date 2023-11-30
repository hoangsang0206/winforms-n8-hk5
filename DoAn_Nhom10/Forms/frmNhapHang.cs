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
        DataTable dt = new DataTable();
        DataTable dt_product = new DataTable();
        DataTable dt_import = new DataTable();
        DataTable dt_impDetail = new DataTable();

        public frmNhapHang()
        {
            InitializeComponent();
        }

        //Load combobox danh mục
        private void loadCbBoxCategories()
        {
            DataTable dtt = new DataTable();
            string sql = "Select * From DanhMuc";

            dtt = dbConnect.getDataTable(sql);
            cbboxCategories.DataSource = dtt;
            cbboxCategories.DisplayMember = "TenDM";
            cbboxCategories.ValueMember = "MaDM";
        }

        private void AddProductsForm_Load(object sender, EventArgs e)
        {
            labelEmpName.Text = dtUser.Rows[0]["TenNV"].ToString();
            labelEmpPhone.Text = dtUser.Rows[0]["SoDT"].ToString();
        }

        //Thêm sản phẩm ------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            decimal totalPrice = Convert.ToDecimal(txtPriceSum.Text.ToString());
            DataRow pNewRow = dt_product.NewRow();
            if (dt_product.Rows.Count <= 0)
            {
                pNewRow["MaSP"] = "SP000001";
            }
            else
            {
                int lasPID = Convert.ToInt32(dt_product.Rows[dt_product.Rows.Count - 1]["MaSP"].ToString().Substring(2, 6));
                pNewRow["MaSP"] = "SP" + (lasPID + 1).ToString().PadLeft(6, '0');
            }
            pNewRow["TenSP"] = txtProductName.Text;
            pNewRow["GiaBan"] = txtPrice.Text;
            pNewRow["ChatLieu"] = txtMaterial.Text;
            pNewRow["KieuDang"] = txtType.Text;
            pNewRow["SoLuong"] = txtQuantity.Text;
            pNewRow["MaDM"] = cbboxCategories.SelectedValue.ToString();
            dt_product.Rows.Add(pNewRow);

            DataRow impDNewRow = dt_impDetail.NewRow();
            impDNewRow["MaPN"] = txtImportID.Text;
            impDNewRow["MaSP"] = pNewRow["MaSP"];
            impDNewRow["SoLuong"] = txtQuantity.Text;
            impDNewRow["GiaBan"] = txtPrice.Text;
            impDNewRow["ThanhTien"] = Convert.ToInt32(txtQuantity.Text) * Convert.ToDecimal(txtPrice.Text);
            dt_impDetail.Rows.Add(impDNewRow);

            dt_import.Rows[0]["TongTien"] = txtPriceSum.Text;

            txtPriceSum.Text = (totalPrice + Convert.ToDecimal(txtPrice.Text)).ToString();

            txtProductName.Clear();
            txtPrice.Clear();
            txtMaterial.Clear();
            txtType.Clear();
            txtQuantity.Clear();

            dgvImportDetail.DataSource = dt_impDetail;
            dgvImportDetail.Columns["ThanhTien"].Visible = false;
        }

        //
        private void btnCreateImport_Click(object sender, EventArgs e)
        {
            string sql1 = "Select * From SanPham";
            string sql2 = "Select * From PhieuNhap";
            dt_product = dbConnect.getDataTable(sql1);
            dt_import = dbConnect.getDataTable(sql2);
            dt_impDetail.Columns.Add("MaPN");
            dt_impDetail.Columns.Add("MaSP");
            dt_impDetail.Columns.Add("SoLuong");
            dt_impDetail.Columns.Add("GiaBan");
            dt_impDetail.Columns.Add("ThanhTien");

            txtPriceSum.Text = "0";
            string dateNow = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            txtDateImport.Text = dateNow;
            string dateNowText = dateNow.Replace("/", "");

            DataTable dtt = new DataTable();
            string sql = "Select Top 1 * From PhieuNhap Where MaPN Like '%" + dateNowText + "%'Order By MaPN Desc";
            dtt = dbConnect.getDataTable(sql);
            string maPN = "";

            if (dtt.Rows.Count <= 0)
            {
                maPN = "PN" + dateNowText + "001";
            }
            else
            {
                string maPNCuoi = dtt.Rows[0]["MAPHIEUNHAP"].ToString();
                string kituCuoi = maPNCuoi.Substring(10, 3);
                int soPN = int.Parse(kituCuoi) + 1;
                string sPN = soPN.ToString().PadLeft(3, '0');

                maPN = "PN" + dateNowText + sPN;
            }

            txtImportID.Text = maPN;
            loadCbBoxCategories();

            DataRow newRow = dt_import.NewRow();
            newRow["MaPN"] = maPN;
            newRow["NgayNhap"] = DateTime.Now;
            newRow["MaNV"] = UserLogged.dtUser.Rows[0]["MaNV"].ToString();
            dt_import.Rows.Add(newRow);

            btnCreateImport.Enabled = false;
            btnCreateImport.BackColor = Color.LightGray;

            btnSaveImport.Enabled = true;
            btnAdd.Enabled = true;
            btnSaveImport.BackColor = Color.FromArgb(105, 92, 254);
            btnAdd.BackColor = Color.FromArgb(105, 92, 254);
        }   

        //
        private void btnSaveImport_Click(object sender, EventArgs e)
        {
            string sql1 = "Select * From SanPham";
            string sql2 = "Select * From PhieuNhap";
            string sql3 = "Select * From ChiTietPN";

            dt_impDetail.Columns.Remove("GiaBan");

            dbConnect.updateDataTable(dt_product, sql1);
            dbConnect.updateDataTable(dt_import, sql2);
            dbConnect.updateDataTable(dt_impDetail, sql3);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dt_product = new DataTable();
            dt_import = new DataTable();
            dt_impDetail = new DataTable();

            txtImportID.Clear();
            txtPriceSum.Clear();
            txtProductName.Clear();
            txtPrice.Clear();
            txtQuantity.Clear();
            txtType.Clear();
            txtMaterial.Clear();
            cbboxCategories.SelectedIndex = -1;

            btnCreateImport.Enabled = true;
            btnCreateImport.BackColor = Color.FromArgb(105, 92, 254);
            btnCreateImport.IconColor = Color.White;

            btnSaveImport.Enabled = false;
            btnAdd.Enabled = false;
            btnSaveImport.BackColor = Color.LightGray;
            btnAdd.BackColor = Color.LightGray;

            dgvImportDetail.DataSource = null;
        }   
    }
}
