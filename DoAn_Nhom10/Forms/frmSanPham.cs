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
    public partial class frmSanPham : Form
    {
        DBConnect dbConnect = new DBConnect();
        DataTable dt_cate = new DataTable();
        DataTable dt_product = new DataTable();
        DataColumn[] key = new DataColumn[1];

        public frmSanPham()
        {
            InitializeComponent();
        }

        //Data binding
        private void dataBinding(DataTable dt)
        {
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            txtMaterial.DataBindings.Clear();
            txtType.DataBindings.Clear();
            txtQuantity.DataBindings.Clear();
            cbboxCategories.DataBindings.Clear();

            txtProductID.DataBindings.Add("Text", dt, "MaSP");
            txtProductName.DataBindings.Add("Text", dt, "TenSP");
            txtPrice.DataBindings.Add("Text", dt, "GiaBan");
            txtMaterial.DataBindings.Add("Text", dt, "ChatLieu");
            txtType.DataBindings.Add("Text", dt, "KieuDang");
            txtQuantity.DataBindings.Add("Text", dt, "SoLuong");
            cbboxCategories.DataBindings.Add("SelectedValue", dt, "MaDM");
        }

        //Load danh mục
        private void loadCategories()
        {
            string sqlQuery = "Select * From DanhMuc";


            dt_cate = dbConnect.getDataTable(sqlQuery);
            cbboxCategories.DataSource = dt_cate;
            cbboxCategories.DisplayMember = "TenDM";
            cbboxCategories.ValueMember = "MaDM";
        }

        //Load sản phẩm
        private void loadProducts()
        {
            string sqlQuery = "Select MaSP, TenSP, ChatLieu, KieuDang, GiaBan, SanPham.MaDM, SoLuong, DanhMuc.TenDM " +
                               "From SanPham LEFT JOIN DanhMuc ON SanPham.MaDM = DanhMuc.MaDM";
 
            dt_product = dbConnect.getDataTable(sqlQuery);
            dgvProducts.DataSource = dt_product;
            dgvProducts.Columns["MaDM"].Visible = false;
            dataBinding(dt_product);
            key[0] = dt_product.Columns[0];
            dt_product.PrimaryKey = key;
        }

        //--
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            loadCategories();
            loadProducts();
        }

        //--Kiểm tra xem sản phẩm đã tồn tại chưa
        private bool checkProductExist(string ProductID)
        {
            string sqlQuery = "Select Count(*) From SanPham Where MaSP = '" + ProductID + "'";

            int result = dbConnect.getScalar(sqlQuery);

            if (result != 0)
            {
                return true;
            }

            return false;
        }

        //Xóa sản phẩm ---------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkProductExist(txtProductID.Text) == false)
            {
                MessageBox.Show("Sản phẩm này không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult r = MessageBox.Show("Xóa sản phẩm này?", "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                string sql = "Delete From SanPham Where MaSP = '" + txtProductID.Text + "'";
                int result = dbConnect.getNonQuery(sql);

                if (result == 0)
                {
                    MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Xóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadProducts();
                }  
            }  
        }

        //Sửa -------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn sản phẩm muốn sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkProductExist(txtProductID.Text) == false)
            {
                MessageBox.Show("Sản phẩm này không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sql = "Update SanPham Set TenSP = N'" + txtProductName.Text + "', " +
                        "ChatLieu = N'" + txtMaterial.Text + "', GiaBan = " + txtPrice.Text + ", KieuDang = N'" + txtType.Text + "', " +
                        "MaDM = '" + cbboxCategories.SelectedValue.ToString() + "', SoLuong = " + txtQuantity.Text + "Where MaSP = " + txtProductID.Text;

            int result = dbConnect.getNonQuery(sql);

            if (result == 0)
            {
                MessageBox.Show("Sửa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Sửa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadProducts();
            }  
        }

    }
}
