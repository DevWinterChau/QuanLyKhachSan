using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_TrangChu : Form
    {
         private NguoiDung_DTO nguoidung;
        private Admin_DTO admin;
        public frm_TrangChu()
        {
            InitializeComponent();
        }
        public frm_TrangChu(NguoiDung_DTO ng)
        {
            InitializeComponent();
            this.nguoidung = ng;
        }
        public frm_TrangChu(Admin_DTO ng)
        {
            InitializeComponent();
            this.admin = ng;
        }
        private void Openformchild(Form childForm)
        {

            bool IsOpen = false;
            foreach (Form frm in Application.OpenForms)
            {
                if (childForm.Text == frm.Text)
                {
                    IsOpen = true;
                    lb_tenform.Text = frm.Text;
                    frm.BringToFront();
                    break;
                }
            }
            if (IsOpen == false)
            {
                childForm.TopLevel = false;
                childForm.FormBorderStyle = FormBorderStyle.None;
                childForm.Dock = DockStyle.Fill;
                panel_Home.Controls.Add(childForm);
                panel_Home.Tag = childForm;
                lb_tenform.Text = childForm.Text;
                childForm.BringToFront();
                childForm.Show();
            }

        }
        private void btn_AnForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_formnho_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                btn_formLon.BringToFront();
                this.WindowState = FormWindowState.Normal;
            }
        }

        private void btn_thugon_Click(object sender, EventArgs e)
        {
            int y = 0;
            y = panel_Home.Width;
            panel_Home.BringToFront();
            btn_phongto.BringToFront();
            panel_Menu.SendToBack();
            panel_Home.Location = new Point(35, 32);
            if (this.WindowState == FormWindowState.Maximized)
                panel_Home.Width = y + 130;
            else
                panel_Home.Width = y + 130;
            lb_banquyen.Visible = false;
            pictureBox_anh.Visible = false;
        }

        private void btn_phongto_Click(object sender, EventArgs e)
        {
            int y = 0;
            y = panel_Home.Width;
            btn_phongto.SendToBack();
            panel_Home.Location = new Point(130, 32);
            if (this.WindowState == FormWindowState.Maximized)
                panel_Home.Width = y - 134;
            else
                panel_Home.Width = y - 134;
           lb_banquyen.Visible = true;
            pictureBox_anh.Visible = true;
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       /* private void Openformchild_DASHBOARD(Form childForm)
        {

            frm_dashboard kh = new frm_dashboard();
            if (currentFomchild != null)
            {
                currentFomchild.Close();
            }
            currentFomchild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_home.Controls.Add(childForm);
            panel_home.Tag = childForm;
            lb_tenfrm.Text = childForm.Text;
            childForm.BringToFront();
            childForm.Show();
        }*/

        private void btn_formLon_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
            {
                btn_formnho.BringToFront();
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void btn_EXIT_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn thoát chương trình không ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void panel_TenForm_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel_Home_Paint(object sender, PaintEventArgs e)
        {

        }
        
        private void btn_p_Click(object sender, EventArgs e)
        {
            frm_Phong phong = new frm_Phong();
            Openformchild(phong);
            if(nguoidung != null)
            {
                phong.Nguoidung= nguoidung;
            }   
            else
            {
                phong.Nguoidung = nguoidung;
            }
        }
    }
}
