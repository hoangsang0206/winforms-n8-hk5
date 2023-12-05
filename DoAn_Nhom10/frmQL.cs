using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;
using DoAn_Nhom10.Forms;

namespace DoAn_Nhom10
{
    public partial class frmQL : Form
    {
        DataTable dtUser = UserLogged.dtUser;
        //-------------------
        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        //-------------------
        public frmQL()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 55);
            panelSidebar.Controls.Add(leftBorderBtn);
        }

        //Color list
        private struct Colors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(249, 88, 155);
            public static Color color6 = Color.FromArgb(24, 161, 251);
        }

        //------------------
        private void ActiveBtn(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableBtn();

                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(227, 233, 247);
                currentBtn.ForeColor = color;
                //currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                //currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();

                titleIcon.IconChar = currentBtn.IconChar;
                titleIcon.IconColor = color;
            }
        }

        //
        private void DisableBtn()
        {
            if (currentBtn!= null)
            {
                currentBtn.BackColor = Color.FromArgb(227, 233, 247);
                currentBtn.ForeColor = Color.Black;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.Black;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        //------------------
        private void OpenChildForm(Form form)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(form);
            panelChildForm.Tag = form;
            form.BringToFront();
            form.Show();
            titleLabel.Text = form.Text;
        }

        //------------------
        private void frmQL_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult r = MessageBox.Show("Bạn chắc chắn muốn thoát?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                
                if (r == DialogResult.Yes)
                {
                    Application.Exit();
                }
                else
                {
                    e.Cancel = true;
                }
            }

           
        }

        //---------------------
        private void btnHome_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color1);
            OpenChildForm(new frmTongQuan());
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color2);
            OpenChildForm(new frmDanhMuc());
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color3);
            OpenChildForm(new frmSanPham());
        }
        private void btnOrders_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color4);
            OpenChildForm(new frmDonHang());
        }

        private void btnImportProducts_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color6);
            OpenChildForm(new frmNhapHang());
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color1);
            OpenChildForm(new frmKhachHang());
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            ActiveBtn(sender, Colors.color2);
            OpenChildForm(new frmNhanVien());
        }

        private void frmQL_Load(object sender, EventArgs e)
        {
            if (dtUser != null)
            {
                iconUser.Text = dtUser.Rows[0]["TenNV"].ToString();
                ActiveBtn((IconButton)btnHome, Colors.color1);
                OpenChildForm(new frmTongQuan());
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            dtUser = null;
            frmDangNhap login = new frmDangNhap();
            this.Hide();
            login.Show();
        }

        private void frmQL_Shown(object sender, EventArgs e)
        {
            if (dtUser == null || dtUser.Rows.Count <= 0)
            {
                frmDangNhap login = new frmDangNhap();
                this.Hide();
                login.Show();
            }
        }
    }
}
