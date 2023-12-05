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
    public partial class frmTongQuan : Form
    {
        DBConnect dbConnect = new DBConnect();

        public frmTongQuan()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            string sql1 = "Select Count(*) From HoaDon";
            string sql2 = "Select Sum(TongTien) From HoaDon";
            string sql3 = "Select Count(*) From SanPham";
            string sql4 = "Select Count(*) From KhachHang";
            string sql5 = "Select Count(*) From NhanVien";

            labelTongDH.Text = dbConnect.getScalar(sql1).ToString();
            labelTongDoanhThu.Text = (dbConnect.getSum(sql2) / 1000000 ).ToString("#.##") + " triệu";
            labelTongSP.Text = dbConnect.getScalar(sql3).ToString();
            labelTongKH.Text = dbConnect.getScalar(sql4).ToString();
            labelTongNV.Text = dbConnect.getScalar(sql5).ToString();
        }
    }
}
