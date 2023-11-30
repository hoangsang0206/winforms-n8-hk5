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
    public partial class frmDanhMuc : Form
    {
        DBConnect dbConnect = new DBConnect();
        DataTable dt;
        DataColumn[] key = new DataColumn[1];

        public frmDanhMuc()
        {
            InitializeComponent();
        }

        //Data binding
        private void dataBinding(DataTable dt)
        {
            txtCategoryID.DataBindings.Clear();
            txtCategoryName.DataBindings.Clear();

            txtCategoryID.DataBindings.Add("Text", dt, "MaDM");
            txtCategoryName.DataBindings.Add("Text", dt, "TenDM");
        }

        //Load danh mục
        private void loadCategories()
        {
            string sqlQuery = "Select DanhMuc.MaDM, TenDM, Count(SanPham.MaSP) As DemSP From DanhMuc " +
                              "Left Join SanPham ON DanhMuc.MaDM = SanPham.MaDM " +
                              "Group By DanhMuc.MaDM, TenDM";


            dt = dbConnect.getDataTable(sqlQuery);
            dgvCategories.DataSource = dt;
            dataBinding(dt);
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
        }
        
        //------------------
        private void CategoriesForm_Load(object sender, EventArgs e)
        {
            loadCategories();
        }

        //--Kiểm tra xem danh mục có chứa sản phẩm không
        private bool checkProductInCategory(string cateID)
        {
            string sqlQuery = "Select Count(*) From SanPham Where MaDM = '" +cateID+ "'";

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
            string sqlQuery = "Select Count(*) From DanhMuc Where MaDM = '" +cateID+ "'";

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

            DialogResult r = MessageBox.Show("Xóa danh mục này?", "Xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                string sql = "Delete From DanhMuc Where MaDM = '" + txtCategoryID.Text + "'";
                int result = dbConnect.getNonQuery(sql);
                if (result != 1)
                {
                    MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Xóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                loadCategories();
            }
           
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
            newRow["MaDM"] = txtCategoryID.Text;
            newRow["TenDM"] = txtCategoryName.Text;

            dt.Rows.Add(newRow);

            string sqlQuery = "Select * From DanhMuc";
            int result = dbConnect.updateDataTable(dt, sqlQuery);

            if (result != 1)
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

            string sql = "Update DanhMuc Set TenDM = N'" + txtCategoryName.Text + "' Where MaDM = '" + txtCategoryID.Text + "'";
            int result = dbConnect.getNonQuery(sql);

            if (result != 1)
            {
                MessageBox.Show("Không thể sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            loadCategories();
        }
    }
}
