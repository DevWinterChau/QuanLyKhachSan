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
    public partial class frm_TienNghi : Form
    {
        public frm_TienNghi()
        {
            InitializeComponent();
            LoadTN();
        }
        private void LoadTN()
        {
            List<TienNghi_DTO> tn = TienNghi_BUS.LayDSTienNghi();
            dgv_TienNghi.DataSource = tn;
        }

        private void btn_themTN_Click(object sender, EventArgs e)
        {
            try
            {
                TienNghi_DTO tn = new TienNghi_DTO();
                tn.TenTN = txt_TenTN.Text;
                tn.Dongia = double.Parse( txt_Dongia.Text);
                TienNghi_BUS.add(tn);
                LoadTN();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống 1!", ex.Message);
            }
        }

        private void btn_Thoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_TimTN_Leave(object sender, EventArgs e)
        {
            if (txt_TimTN.Text != "")
            {

            }
            else
                txt_TimTN.Text = "Nhập để tìm";
        }

        private void txt_TimTN_Click(object sender, EventArgs e)
        {
            if (txt_TimTN.Text == "Nhập để tìm")
                txt_TimTN.Clear();
        }

        private void btn_TimTn_Click(object sender, EventArgs e)
        {
            try
            {
                if (cbb_chon.SelectedIndex == 0)
                {
                    if (txt_TimTN.Text == "Nhập để tìm")
                    {
                        LoadTN();
                    }
                    else
                    {
                        dgv_TienNghi.DataSource = TienNghi_BUS.TimTNtheoIDTN(txt_TimTN.Text);
                    }
                }
                if (cbb_chon.SelectedIndex == 1)
                {
                    if (txt_TimTN.Text == "Nhập để tìm")
                    {
                        LoadTN();
                    }
                    else
                    {
                        dgv_TienNghi.DataSource = TienNghi_BUS.TimTNtheoTenTN(txt_TimTN.Text);
                    }
                }
           }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống !", "Thông báo");
            }
        }

        private void dgv_TienNghi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_TienNghi_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow dr = dgv_TienNghi.SelectedRows[0];
                if (dr.Cells[0].Value != null && dr.Cells[1].Value != null && dr.Cells[2].Value != null && dr.Cells[3].Value != null)
                {
                    txt_IDTN.Text = dr.Cells[0].Value.ToString();
                    txt_TenTN.Text = dr.Cells[1].Value.ToString();
                    txt_Dongia.Text = dr.Cells[2].Value.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi hệ thống 3!", ex.Message);
            }
        }

        private void btn_Capnhat_Click(object sender, EventArgs e)
        {
            TienNghi_DTO tn = new TienNghi_DTO();
            tn.TenTN = txt_TenTN.Text;
            tn.Dongia =double.Parse( txt_Dongia.Text);
            TienNghi_BUS.Update(tn);
        }

        private void btn_Loadlai_Click(object sender, EventArgs e)
        {
            LoadTN();
        }

        private void frm_TienNghi_Load(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
