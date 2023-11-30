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
    public partial class frmTaoHD : Form
    {
        //--Khai báo biến cần thiết
        float totalPrice = 0;
        DBConnect dbConnect = new DBConnect();
        DataTable dt;

        //---------------

        public frmTaoHD()
        {
            InitializeComponent();
        }

        private void AddOrderForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (r == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void AddOrderForm_Load(object sender, EventArgs e)
        {
            
        }

        private void radioNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
