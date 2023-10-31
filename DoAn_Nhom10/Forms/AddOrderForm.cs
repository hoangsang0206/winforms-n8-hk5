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
    public partial class AddOrderForm : Form
    {
        //--Khai báo biến cần thiết
        float totalPrice = 0;
        DBConnect dbConnect = new DBConnect();
        DataTable dt;

        //---------------

        public AddOrderForm()
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
            if (radioNewCustomer.Checked)
            {
                txtCustomerPhoneSearch.Enabled = false;
                txtCustomerPhoneSearch.ReadOnly = true;
                btnSearchCustomer.Enabled = false;
            }
            else
            {
                txtCustomerName.ReadOnly = true;
                txtCustomerPhone.ReadOnly = true;
                txtCustomerAddress.ReadOnly = true;
                txtCustomerEmail.ReadOnly = true;
            }
        }

        private void radioNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (radioNewCustomer.Checked)
            {
                txtCustomerPhoneSearch.Enabled = false;
                txtCustomerPhoneSearch.ReadOnly = true;
                btnSearchCustomer.Enabled = false;
            }
            else
            {
                txtCustomerPhoneSearch.Enabled = true;
                txtCustomerPhoneSearch.ReadOnly = false;
                btnSearchCustomer.Enabled = true;

                txtCustomerName.ReadOnly = true;
                txtCustomerName.Clear();
                txtCustomerPhone.ReadOnly = true;
                txtCustomerPhone.Clear();
                txtCustomerAddress.ReadOnly = true;
                txtCustomerAddress.Clear();
                txtCustomerEmail.ReadOnly = true;
                txtCustomerEmail.Clear();
            }
        }
    }
}
