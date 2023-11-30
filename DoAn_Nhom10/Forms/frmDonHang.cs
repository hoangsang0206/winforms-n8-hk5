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
    public partial class frmDonHang : Form
    {
        DBConnect dbConnect = new DBConnect();
        DataTable dt = new DataTable();

        public frmDonHang()
        {
            InitializeComponent();
        }

        //Load danh sách đơn hàng
        private void loadOrders()
        {
            string sql = "Select MaHD, TenKH, TenNV, TongTien, NgayTao " + 
                        "From HoaDon HD, NhanVien NV, KhachHang KH Where HD.MaNV = NV.MaNV And HD.MaKH = KH.MaKH";
            dt = dbConnect.getDataTable(sql);

            dgvOrders.DataSource = dt;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmTaoHD addOrderForm = new frmTaoHD();
            addOrderForm.Show();
        }

        private void dgvOrders_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            // Lấy được dòng và cột của cell được click
            int row = e.RowIndex;
            int column = e.ColumnIndex;

            // Tạo một ContextMenuStrip mới
            ContextMenu contextMenu = new ContextMenu();

            // Thêm hai button sửa và xóa vào ContextMenuStrip
            contextMenu.MenuItems.Add("Sửa");
            contextMenu.MenuItems.Add("Xóa");

            // Hiển thị ContextMenuStrip tại vị trí của cell được click
            contextMenu.Show(dgvOrders, e.Location);
        }

        private void OrdersForm_Load(object sender, EventArgs e)
        {
            loadOrders();
        }
    }
}
