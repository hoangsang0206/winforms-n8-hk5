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
            txtMaDM.DataBindings.Clear();
            txtTenDM.DataBindings.Clear();

            txtMaDM.DataBindings.Add("Text", dt, "MaDM");
            txtTenDM.DataBindings.Add("Text", dt, "TenDM");
        }

        //Load danh mục
        private void loadDanhMuc()
        {
            string sqlQuery = "Select DanhMuc.MaDM, TenDM, Count(SanPham.MaSP) As DemSP From DanhMuc " +
                              "Left Join SanPham ON DanhMuc.MaDM = SanPham.MaDM " +
                              "Group By DanhMuc.MaDM, TenDM";


            dt = dbConnect.getDataTable(sqlQuery);
            dgvDanhMuc.DataSource = dt;
            dataBinding(dt);
            key[0] = dt.Columns[0];
            dt.PrimaryKey = key;
        }
        
        //------------------
        private void frmDanhMuc_Load(object sender, EventArgs e)
        {
            loadDanhMuc();
        }

        //--Kiểm tra xem danh mục có chứa sản phẩm không
        private bool ktSanPhamTrongDM(string cateID)
        {
            string sqlQuery = "Select Count(*) From SanPham Where MaDM = '" +cateID+ "'";

            int result = dbConnect.getScalar(sqlQuery);
            
            if(result > 0)
            {
                return true;
            }
            return false;
        }

        //--Kiểm tra xem danh mục đã tồn tại chưa
        private bool ktDanhMucDaTonTai(string cateID)
        {
            string sqlQuery = "Select Count(*) From DanhMuc Where MaDM = '" +cateID+ "'";

            int result = dbConnect.getScalar(sqlQuery);

            if (result > 0)
            {
                return true;
            }
            return false;
        }

        //Xóa danh mục----------------------------
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaDM.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục muốn xóa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult r = MessageBox.Show("Xóa danh mục này?", "Xóa danh mục", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.Yes)
            {
                DataRow row = dt.Rows.Find(txtMaDM.Text);
                if (row != null)
                {
                    if (ktSanPhamTrongDM(row["MaDM"].ToString()) == false)
                    {
                        row.Delete();
                        MessageBox.Show("Xóa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Xóa thất bại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        //Thêm danh mục----------------------------
        private void btnThem_Click(object sender, EventArgs e)
        {
            if (txtMaDM.Text.Length <= 0 || txtTenDM.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (ktDanhMucDaTonTai(txtMaDM.Text) || dt.Rows.Find(txtMaDM.Text) != null)
            {
                MessageBox.Show("Danh mục này đã tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow newRow = dt.NewRow();
            newRow["MaDM"] = txtMaDM.Text;
            newRow["TenDM"] = txtTenDM.Text;
            dt.Rows.Add(newRow);
            txtMaDM.Clear();
            txtTenDM.Clear();

            btnThem.Enabled = false;
            btnThem.BackColor = Color.Silver;
            dataBinding(dt);
            MessageBox.Show("Thêm thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Sửa danh mục----------------------------
        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtMaDM.Text.Length <= 0)
            {
                MessageBox.Show("Vui lòng chọn danh mục muốn sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = dt.Rows.Find(txtMaDM.Text);
            if (row != null)
            {
                row["TenDM"] = txtTenDM.Text;
                MessageBox.Show("Sửa thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Không thể sửa.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "Select * From DanhMuc";
            int kq = dbConnect.updateDataTable(dt, sql);

            if (kq > 0)
            {
                MessageBox.Show("Lưu thành công.", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Lưu thất bại.", "Thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            txtMaDM.Clear();
            txtTenDM.Clear();
            txtMaDM.DataBindings.Clear();
            txtTenDM.DataBindings.Clear();
            dgvDanhMuc.ClearSelection();

            btnThem.Enabled = true;
            btnThem.BackColor = Color.FromArgb(105, 92, 254);
        }
    }
}
