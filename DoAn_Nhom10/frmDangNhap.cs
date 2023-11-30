using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAn_Nhom10
{
    public partial class frmDangNhap : Form
    {
        DBConnect dbConnect = new DBConnect();
        DataTable dt = new DataTable();
        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUserName.Text;
            string password = txtPassword.Text;

            string sql = "Select TOP 1 * From NhanVien Where TaiKhoan = '" + username + "' And MatKhau = '" + password + "'";
            dt = dbConnect.getDataTable(sql);

            if (dt.Rows.Count > 0 && (username == dt.Rows[0]["TaiKhoan"].ToString() && password == dt.Rows[0]["MatKhau"].ToString()))
            {
                UserLogged.dtUser = dt;
                frmQL frm = new frmQL();
                frm.Show();

                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu", "Đăng nhập thất bại", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }        

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.AcceptButton = btnLogin;
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void btnLeave_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
