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
    public partial class frm_DS_DatPhong : Form
    {
        public frm_DS_DatPhong()
        {
            InitializeComponent();
        }

        private void frm_DS_DatPhong_Load(object sender, EventArgs e)
        {
            LOADDSDP();
        }
        private void LOADDSDP()
        {
            List<DatPhong_DTO> lstDSDP = DatPhong_BUS.LayDSDatPhong();
            dgv_DSdatphong.DataSource = lstDSDP;
        }

        private void dateTime_ngaylap_ValueChanged(object sender, EventArgs e)
        {
            dgv_DSdatphong.DataSource = DatPhong_BUS.TimDPtheoNgaylap(dateTime_ngaylap.Text);
        }

        private void txt_Tìm_Leave(object sender, EventArgs e)
        {
            if (txt_Tìm.Text != "")
            {

            }
            else
                txt_Tìm.Text = "Nhập điều kiện để tìm kiếm";
        }

        private void txt_Tìm_Click(object sender, EventArgs e)
        {
            if (txt_Tìm.Text == "Nhập điều kiện để tìm kiếm")
                txt_Tìm.Clear();
        }

        private void btn_Tim_Click(object sender, EventArgs e)
        {
            try
            {
                if(cbb_Chon.SelectedIndex == 0)
                {
                    if (txt_Tìm.Text == "Nhập điều kiện để tìm kiếm")
                    {
                        LOADDSDP();
                    }
                    else
                    {
                        dgv_DSdatphong.DataSource = DatPhong_BUS.TimDPtheoMaDP(txt_Tìm.Text.Trim());
                    }
                }    
                if(cbb_Chon.SelectedIndex == 1)
                {
                    if (txt_Tìm.Text == "Nhập điều kiện để tìm kiếm")
                    {
                        LOADDSDP();
                    }
                    else
                    {
                        dgv_DSdatphong.DataSource = DatPhong_BUS.TimDPtheoTenKH(txt_Tìm.Text.Trim());
                    }
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi!", "Thông báo");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txt_Tìm_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_DatPhong_Click(object sender, EventArgs e)
        {
            frm_DatPhong DP = new frm_DatPhong();
            DP.Show();
        }

        private void dgv_DSdatphong_DoubleClick(object sender, EventArgs e)
        {
            frm_chitietdatphong CTDP = new frm_chitietdatphong();
            CTDP.Show();    
        }
    }
}
