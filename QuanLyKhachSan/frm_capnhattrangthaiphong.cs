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
    public partial class frm_capnhatphong : Form
    {
        private frm_Phong frmphong;
        private Phong_DTO phongdto;
        public frm_capnhatphong(frm_Phong frmphong, Phong_DTO phong)
        {
            InitializeComponent();
            this.frmphong = frmphong;
            this.phongdto = phong;
        }

        private void btn_capnhatphong_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_capnhatphong_Load(object sender, EventArgs e)
        {
            LoadCbb_loaiphong();
            LoadCbb_Tang();
            LoadCbb_trangthai();
            txt_tenphong.Text = phongdto.TenPhong;
            cbb_trangthai.Text = phongdto.TenTrangThai;
            cbb_tang.Text = phongdto.SoTang;
            cbb_loaiphong.Text = phongdto.TenLoaiPhong;   
        }
        private void LoadCbb_trangthai()
        {
            List<TrangThai_Phong_DTO> list = Phong_BUS.LayDanhSachTrangThai();
            cbb_trangthai.DataSource = list;
        }
        private void LoadCbb_loaiphong()
        {
            List<Loai_Phong_DTO> list = LoaiPhong_BUS.LayDSLOAIPHONG();
            cbb_loaiphong.DataSource = list;
        }
        private void LoadCbb_Tang()
        {
            List<Tang_DTO> list = Phong_BUS.LayDanhSachTang();
            cbb_tang.DataSource = list;
        }
    }
}
