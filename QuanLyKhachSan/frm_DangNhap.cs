using BUS;
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
    public partial class frm_DangNhap : Form
    {
        public frm_DangNhap()
        {
            InitializeComponent();
        }

        private void txt_user_Leave(object sender, EventArgs e)
        {
            if (txt_user.Text != "")
            {

            }
            else
                txt_user.Text = "Tên tài khoản";
        }

        private void txt_user_Click(object sender, EventArgs e)
        {
            if (txt_user.Text == "Tên tài khoản")
                txt_user.Clear();
        }

        private void txt_pass_Leave(object sender, EventArgs e)
        {
            if (txt_pass.Text != "")
            {

            }
            else
                txt_pass.Text = "Password";
        }

        private void txt_pass_Click(object sender, EventArgs e)
        {
            if (txt_pass.Text == "Password")
                txt_pass.Clear();
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt_user.Text.ToUpper() != "ADMIN1")
                {
                    if (txt_user.Text != "" && txt_pass.Text != "")
                    {
                        NguoiDung_DTO nd = NguoiDung_BUS.checkTK(txt_user.Text, txt_pass.Text);
                        if (nd != null )
                        {
                            frm_TrangChu trangchu = new frm_TrangChu(nd);
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công. Quyền: " + nd.TenQuyen, "THÔNG BÁO");
                            trangchu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tên đăng nhập và mật khẩu không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                if (txt_user.Text.ToUpper() == "ADMIN1")
                {
                    if (txt_user.Text != "" && txt_pass.Text != "")
                    {
                        Admin_DTO nd = NguoiDung_BUS.checkAdmin(txt_user.Text, txt_pass.Text);
                        if (nd!= null)
                        {
                            frm_TrangChu trangchu = new frm_TrangChu();
                            this.Hide();
                            MessageBox.Show("Đăng nhập thành công. Quyền: " + nd.TenQuyen, "THÔNG BÁO");
                            trangchu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Tên đăng nhập và mật khẩu không được trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
