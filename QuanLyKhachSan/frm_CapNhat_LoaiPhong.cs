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
    public partial class frm_CapNhat_LoaiPhong : Form
    {
       
        public frm_CapNhat_LoaiPhong()
        {
            InitializeComponent();
        }
        private void LoadDL()
        {
            Loai_Phong_DTO lp = new Loai_Phong_DTO();
            lp.TenLoaiP = txt_tenLoai.Text;
            lp.SoNguoi = nume_songuoi.Bottom;
            lp.SoGiuong = numer_sogiuong.Bottom;
            lp.Dongia_Time_LP = float.Parse(txt_dongiaGio.Text);
            lp.DongiaLP_ngay = float.Parse(txt_dongiaNgay.Text);
        }
        private void Updateloaiphong()
        {
            Loai_Phong_DTO loaiphong = new Loai_Phong_DTO();
            loaiphong.SoNguoi = nume_songuoi.Bottom;
            loaiphong.SoGiuong = numer_sogiuong.Bottom;
            loaiphong.Dongia_Time_LP = float.Parse(txt_dongiaGio.Text);
            loaiphong.DongiaLP_ngay = float.Parse(txt_dongiaNgay.Text);
            LoaiPhong_BUS.Update(loaiphong);
        }

        private void btn_capnhat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn cập nhật ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Updateloaiphong();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn muốn hủy ?","Thông báo",MessageBoxButtons.YesNo,MessageBoxIcon.Question)== DialogResult.Yes)
            {
                Application.Exit();
            }    
        }
    }
}
