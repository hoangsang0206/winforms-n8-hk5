using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom10.Forms
{
    public partial class CategoriesForm : Form
    {
        DBConnect dbConnect = new DBConnect();
        DataTable dt;
        DataColumn[] key = new DataColumn[1];

        public CategoriesForm()
        {
            InitializeComponent();
        }

        //Data binding
        private void dataBinding(DataTable dt)
        {
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();

            txtCategoryID.DataBindings.Add("Text", dt, "CateID");
            txtCategoryName.DataBindings.Add("Text", dt, "CateName");
        }

        //Load danh mục
        private void loadCategories()
        {
            string sqlQuery = "Select Categories.CateID, CateName, Count(Products.ProductID) As ProductCount From Categories " +
                              "Left Join Products ON Categories.CateID = Products.CateID " +
                              "Group By Categories.CateID, CateName";


            dt = dbConnect.getDataTable(sqlQuery);
            dgvCategories.DataSource = dt;
            dataBinding(dt);
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;

            //-------------------
            int stt = 1;
            foreach (DataGridViewRow row in dgvCategories.Rows)
            {
                row.Cells["STT"].Value = stt;
                stt++;
            }

        }
        
        //------------------
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        //--Kiểm tra xem danh mục có chứa sản phẩm không
        private bool checkProductInCategory(string cateID)
        {
            string sqlQuery = "Select Count(*) From Products Where CateID = '" +cateID+ "'";

            int result = dbConnect.getScalar(sqlQuery);
            
            if(result != 0)
            {
                return true;
            }
            return false;
        }

        //--Kiểm tra xem danh mục đã tồn tại chưa
        private bool checkCateExist(string cateID)
        {
            string sqlQuery = "Select Count(*) From Categories Where CateID = '" +cateID+ "'";

            int result = dbConnect.getScalar(sqlQuery);

            if (result != 0)
            {
                return true;
            }
            return false;
        }

        //Xóa danh mục----------------------------
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã danh mục muốn xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkCateExist(txtCategoryID.Text) == false)
            {
                MessageBox.Show("Danh mục này không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt.Rows.Find(txtCategoryID.Text);
            if (row != null)
            {
                row.Delete();
            }
            else {
                return;
            }

            string sqlQuery = "Select * From Categories";
            int result = dbConnect.updateDataTable(dt, sqlQuery);

            if (result < 1)
            {
                MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            loadCategories();
        }

        //Thêm danh mục----------------------------
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text.Length <= 0 || txtCategoryName.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkCateExist(txtCategoryID.Text))
            {
                MessageBox.Show("Danh mục này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow newRow = dt.NewRow();
            newRow["CateID"] = txtCategoryID.Text;
            newRow["CateName"] = txtCategoryName.Text;

            dt.Rows.Add(newRow);

            string sqlQuery = "Select * From Categories";
            int result = dbConnect.updateDataTable(dt, sqlQuery);

            if (result < 1)
            {
                MessageBox.Show("Không thể thêm mới.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            loadCategories();
        }

        //Sửa danh mục----------------------------
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtCategoryID.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập mã danh mục muốn sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (checkCateExist(txtCategoryID.Text) == false)
            {
                MessageBox.Show("Danh mục này không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt.Rows.Find(txtCategoryID.Text);
            if (row != null)
            {
                row["CateName"] = txtCategoryName.Text;
                
            }

            string sqlQuery = "Select * From Categories";

            int result = dbConnect.updateDataTable(dt, sqlQuery);

            if (result < 1)
            {
                MessageBox.Show("Không thể sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            loadCategories();
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            loadCategories();
        }


    }
}
