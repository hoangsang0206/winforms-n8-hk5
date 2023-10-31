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
    public partial class AddProductsForm : Form
    {
        public AddProductsForm()
        {
            InitializeComponent();
        }

        private void AddProductsForm_Load(object sender, EventArgs e)
        {
            txtDateImport.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        //Thêm sản phẩm ------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //if (txtProductID.Text.Length <= 0 || txtProductName.Text.Length <= 0 || txtPrice.Text.Length <= 0)
            //{
            //    MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            //if (checkProductExist(txtProductID.Text))
            //{
            //    MessageBox.Show("Sản phẩm này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}


            //DataRow newRow = dt_product.NewRow();
            //DataRow lastRow;

            //if (dt_product.Rows.Count > 0)
            //{
            //    lastRow = dt_product.Rows[dt_product.Rows.Count - 1];
            //    newRow["ProductID"] = (int)lastRow["ProductID"] + 1;
            //}
            //else
            //{
            //    newRow["ProductID"] = 1;
            //}

            //newRow["ProductName"] = txtProductName.Text;
            //newRow["Price"] = txtPrice.Text;
            //newRow["CateID"] = cbboxCategories.SelectedValue;
            //newRow["BrandID"] = cbboxBrands.SelectedValue;

            //dt_product.Rows.Add(newRow);

            //string sqlQuery = "Select * From Products";
            //int result = dbConnect.updateDataTable(dt_product, sqlQuery);

            //if (result < 1)
            //{
            //    MessageBox.Show("Không thể thêm mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}

            //loadProducts();
        }

    }
}
