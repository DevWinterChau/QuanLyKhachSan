using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyKhachSan
{
    public partial class frm_chitietdatphong : Form
    {
        public frm_chitietdatphong()
        {
            InitializeComponent();
        }
        private frm_Phong frmphong;
        private string tennv;
        public frm_chitietdatphong(int iddatphong, string tenkh, frm_Phong frmphong,string tennv )
        {
            InitializeComponent();
            this.iddatphong = iddatphong;
            this.tenkh = tenkh;
            this.frmphong = frmphong;
            this.tennv = tennv;
        }
        private int iddatphong; private string tenkh;
        private List<DatPhong_DichVu_DTO> datPhong_DichVu_list = new List<DatPhong_DichVu_DTO>();

        private void itemThemDV_Click(object sender, EventArgs e)
        {
            frm_themdichvu_datphong themdichvu_Datphong = new frm_themdichvu_datphong(this, dgv_danhsachdichvu, iddatphong);
            themdichvu_Datphong.Show();
        }

        private void itemXoaDV_Click(object sender, EventArgs e)
        {
                DataGridViewRow rowselected = dgv_danhsachdichvu.CurrentRow;
                if (rowselected.Cells[0].Value != null && rowselected.Cells[1].Value != null && rowselected.Cells[2].Value != null && rowselected.Cells[3].Value != null && rowselected.Cells[4].Value != null && rowselected.Cells[5].Value != null && rowselected.Cells[6].Value != null)
                {
                    DatPhong_DichVu_DTO dpdv = new DatPhong_DichVu_DTO();
                    dpdv.IDDP = iddatphong;
                    dpdv.ID_PHONG1 = int.Parse(rowselected.Cells[0].Value.ToString());
                    dpdv.IDDV = int.Parse(rowselected.Cells[1].Value.ToString());
                    dpdv.SoluongDV = int.Parse(rowselected.Cells[3].Value.ToString());
                    dpdv.DongiaDV = double.Parse(rowselected.Cells[4].Value.ToString());
                    dpdv.ThanhtienDV = int.Parse(rowselected.Cells[5].Value.ToString());
                    dpdv.NgaySD_DV = DateTime.Parse(rowselected.Cells[6].Value.ToString());
                    dpdv.TenDV = rowselected.Cells[2].Value.ToString();
                    if (MessageBox.Show("Bạn có muốn xóa dịch vụ " + dpdv.TenDV + " không?", "XÁC NHẬN XÓA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (DatPhong_DichVu_BUS.Delete(dpdv))
                        {
                            LoadDanhSachDichVu_Dat();
                            ShowTienThanhToan();
                            MessageBox.Show("Đã xóa dịch vụ thành công", "THÔNG BÁO");
                        }
                        else
                            MessageBox.Show("Xóa không thành công. Vui lòng thử lại!", "THÔNG BÁO");
                    }
            }
        }

        private void itemCapNhatDV_Click(object sender, EventArgs e)
        {
                DataGridViewRow rowselected = dgv_danhsachdichvu.CurrentRow;
                if (rowselected.Cells[0].Value != null && rowselected.Cells[1].Value != null && rowselected.Cells[2].Value != null && rowselected.Cells[3].Value != null && rowselected.Cells[4].Value != null && rowselected.Cells[5].Value != null && rowselected.Cells[6].Value != null)
                {
                    DatPhong_DichVu_DTO dpdv = new DatPhong_DichVu_DTO();
                    dpdv.IDDP = iddatphong;
                    dpdv.ID_PHONG1 = int.Parse(rowselected.Cells[0].Value.ToString());
                    dpdv.IDDV = int.Parse(rowselected.Cells[1].Value.ToString());
                    dpdv.SoluongDV = int.Parse(rowselected.Cells[3].Value.ToString());
                    dpdv.DongiaDV = double.Parse(rowselected.Cells[4].Value.ToString());
                    dpdv.ThanhtienDV = int.Parse(rowselected.Cells[5].Value.ToString());
                    dpdv.NgaySD_DV = DateTime.Parse(rowselected.Cells[6].Value.ToString());
                    dpdv.TenDV = rowselected.Cells[2].Value.ToString();
                    frm_capnhatsoluongdichvu cnsldichvu = new frm_capnhatsoluongdichvu(this, dpdv, dgv_danhsachdichvu, dpdv.SoluongDV, rowselected.Index);
                    cnsldichvu.Show();
            }
        }


        private void btn_dong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_chitietdatphong_Load(object sender, EventArgs e)
        {
            LoadDanhSachPhongDat();
            LoadDanhSachDichVu_Dat();
            txt_iddatphong.Text += " " + iddatphong.ToString();
            txttenkh.Text += " " + tenkh;
            ShowTienThanhToan();
        }
        public double ShowTienThanhToan()
        {
                double TongTienThanhToan;
                TongTienThanhToan = TongTienDV() + TongTienPhong();
                txt_tongtien.Text = TongTienThanhToan.ToString("c", new CultureInfo("vi-VN"));
                return TongTienThanhToan;
        }
        private void dgv_danhsachdichvu_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenu cm = new ContextMenu();
                cm.MenuItems.Add("Thêm dịch vụ", new EventHandler(itemThemDV_Click));
                cm.MenuItems.Add("Chỉnh sửa", new EventHandler(itemCapNhatDV_Click));
                cm.MenuItems.Add("Xóa", new EventHandler(itemXoaDV_Click));
                //int currentMouseOverRow = dgv_danhsachdichvu.HitTest(e.X, e.Y).RowIndex;
                cm.Show(dgv_danhsachdichvu, new Point(e.X, e.Y));

            }

        }
        private double TongTienDV()
        {
            double tongtien = 0;
                foreach (DataGridViewRow row in dgv_danhsachdichvu.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null && row.Cells[5].Value != null && row.Cells[6].Value != null)
                    {
                        tongtien += double.Parse(row.Cells[5].Value.ToString());
                    }
                
            }
            return tongtien;
        }
        private double TongTienPhong()
        {
            double tongtien = 0;
                foreach (DataGridViewRow row in dgv_danhsachphongdat.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null && row.Cells[5].Value != null)
                    {
                        tongtien += double.Parse(row.Cells[5].Value.ToString());
                    }
                
            }
            return tongtien;
        }
        private void LoadDanhSachPhongDat()
        {
            List<ChiTiet_DatPhong_DTO> listctdp = Chitiet_DatPhong_BUS.LayCT_DATPHONG_THEOID(iddatphong);
            dgv_danhsachphongdat.DataSource = listctdp;
        }
        public void LoadDanhSachDichVu_Dat()
        {
            List<DatPhong_DichVu_DTO> listdvdp = DatPhong_DichVu_BUS.LayDSDichVu_DatPhong(iddatphong);
            dgv_danhsachdichvu.DataSource = listdvdp;
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_dong_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_thanhtoan_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Bạn có muốn thanh toán phiếu đặt phòng không ?", "Xác nhận thanh toán đặt phòng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    HoaDon_DTO hdtt = new HoaDon_DTO();
                    hdtt.IDCty = 1;
                    hdtt.IDNV = 4;
                    hdtt.Tenkh = tenkh;
                    hdtt.NgayGD = DateTime.Now;
                    hdtt.TongHD = ShowTienThanhToan();
                    hdtt.IDDatphong = iddatphong;
                    hdtt.TenNV = tennv;
                    if (HoaDon_BUS.add(hdtt))
                    {
                        MessageBox.Show("Đã thanh toán cho khách hàng!", "THÔNG BÁO");
                        CapNhatTrangThaiPhong();
                        frm_inhoadonthanhtoan inhoadonthanhtoan = new frm_inhoadonthanhtoan(iddatphong);
                        inhoadonthanhtoan.Show();
                        frmphong.LoadPhongAuTo();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

        }
        private void CapNhatTrangThaiPhong()
        {
            foreach (DataGridViewRow row in dgv_danhsachphongdat.Rows)
            {
                if (row.Cells[0].Value != null && row.Cells[1].Value != null && row.Cells[2].Value != null && row.Cells[3].Value != null && row.Cells[4].Value != null && row.Cells[5].Value != null)
                {
                    Phong_DTO p = new Phong_DTO();
                    p.IDPhong = int.Parse(row.Cells[0].Value.ToString());
                    Phong_BUS.UpdateTrangThaiPhong_trangthai(p, 3);
                }
            }
        }
    }
}
