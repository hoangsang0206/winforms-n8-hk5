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
    public partial class ProductsForm : Form
    {
        DBConnect dbConnect = new DBConnect();
        DataTable dt_cate;
        DataTable dt_brand;
        DataTable dt_product;
        DataColumn[] key = new DataColumn[1];

        public ProductsForm()
        {
            InitializeComponent();
        }

        //Data binding
        private void dataBinding(DataTable dt)
        {
            txtProductID.DataBindings.Clear();
            txtProductName.DataBindings.Clear();
            txtPrice.DataBindings.Clear();
            cbboxCategories.DataBindings.Clear();
            cbboxBrands.DataBindings.Clear();

            txtProductID.DataBindings.Add("Text", dt, "ProductID");
            txtProductName.DataBindings.Add("Text", dt, "ProductName");
            txtPrice.DataBindings.Add("Text", dt, "Price");
            cbboxCategories.DataBindings.Add("SelectedValue", dt, "CateName");
            cbboxBrands.DataBindings.Add("SelectedValue", dt, "BrandName");
        }

        //Load danh mục
        private void loadCategories()
        {
            string sqlQuery = "Select * From Categories";


            dt_cate = dbConnect.getDataTable(sqlQuery);
            cbboxCategories.DataSource = dt_cate;
            cbboxCategories.DisplayMember = "CateName";
            cbboxCategories.ValueMember = "CateID";

        }

        //Load hãng
        private void loadBrands()
        {
            string sqlQuery = "Select * From Brands";

            dt_brand = dbConnect.getDataTable(sqlQuery);
            cbboxBrands.DataSource = dt_brand;
            cbboxBrands.DisplayMember = "BrandName";
            cbboxBrands.ValueMember = "BrandID";
        }

        //Load sản phẩm
        private void loadProducts()
        {
            string sqlQuery = "Select ProductID, ProductName, Price, Products.CateID, Products.BrandID, DateAdded, Categories.CateName, Brands.BrandName From Products " +
                              "LEFT JOIN Categories ON Products.CateID = Categories.CateID " +
                              "LEFT JOIN Brands ON Products.BrandID = Brands.BrandID";


            dt_product = dbConnect.getDataTable(sqlQuery);
            dgvProducts.DataSource = dt_product;
            dgvProducts.Columns["CateID"].Visible = false;
            dgvProducts.Columns["BrandID"].Visible = false;

            dataBinding(dt_product);
            key[0] = dt_product.Columns[0];
            dt_product.PrimaryKey = key;

        }

        //--
        private void ProductsForm_Load(object sender, EventArgs e)
        {
            loadCategories();
            loadBrands();
            loadProducts();
        }

        //--Kiểm tra xem sản phẩm đã tồn tại chưa
        private bool checkProductExist(string ProductID)
        {
            string sqlQuery = "Select Count(*) From Products Where ProductID = '" + ProductID + "'";

            int result = dbConnect.getScalar(sqlQuery);

            if (result != 0)
            {
                return true;
            }

            return false;
        }

        //Thêm sản phẩm ------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Length <= 0 || txtProductName.Text.Length <= 0 || txtPrice.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkProductExist(txtProductID.Text))
            {
                MessageBox.Show("Sản phẩm này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            DataRow newRow = dt_product.NewRow();
            DataRow lastRow;

            if (dt_product.Rows.Count > 0)
            {
                lastRow = dt_product.Rows[dt_product.Rows.Count - 1];
                newRow["ProductID"] = (int)lastRow["ProductID"] + 1;
            }
            else
            {
                newRow["ProductID"] = 1;
            }

            newRow["ProductName"] = txtProductName.Text;
            newRow["Price"] = txtPrice.Text;
            newRow["CateID"] = cbboxCategories.SelectedValue;
            newRow["BrandID"] = cbboxBrands.SelectedValue;

            dt_product.Rows.Add(newRow);

            string sqlQuery = "Select * From Products";
            int result = dbConnect.updateDataTable(dt_product, sqlQuery);

            if (result < 1)
            {
                MessageBox.Show("Không thể thêm mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            loadProducts();
        }

        //Xóa sản phẩm ---------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtProductID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã sản phẩm muốn xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkProductExist(txtProductID.Text) == false)
            {
                MessageBox.Show("Sản phẩm này không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt_product.Rows.Find(txtProductID.Text);
            if (row != null)
            {
                row.Delete();
            }
            else
            {
                return;
            }

            string sqlQuery = "Select * From Products";
            int result = dbConnect.updateDataTable(dt_product, sqlQuery);

            if (result < 1)
            {
                MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loadProducts();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadProducts();
        }

        //Sửa -------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

    }
}
