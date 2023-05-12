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
    public partial class frm_Phong : Form
    {
        private NguoiDung_DTO nguoidung;
        public frm_Phong()
        {
            InitializeComponent();
        }

        private void frm_Phong_Load(object sender, EventArgs e)
        {
            flowLayoutPanel1.BorderStyle = BorderStyle.FixedSingle;
            LoadPhongAuTo();
            Timer MyTimer = new Timer();
            MyTimer.Interval = (1 * 60 * 1000); // 45 mins
            MyTimer.Tick += new EventHandler(MyTimer_Tick);
            MyTimer.Start();
            loadLoaiPhong();
            flowLayoutPanel1.ContextMenu = CreateContextMenu_Themphong(); 
        }
        private void Check_NgayDenNhan()
        {
            KhachHang_DTO kh = new KhachHang_DTO();
            bool capnhattrngahthai = false;
            foreach(Phong_DTO p in listphong)
            {
                kh = DatPhong_BUS.TimKH_DatPhong(p.IDPhong.ToString());
                if (kh != null)
                {
                    if (p.IDPhong == kh.Id_phong)
                    {
                        int days = GetDaysBetween(DateTime.Now, kh.Ngaydatphong);
                        TimeSpan ts = kh.Ngaydatphong - DateTime.Now;
                        float hours = (float)ts.TotalHours;
                        float minites = (float)ts.TotalMinutes;
                        float remainder = hours % 24;
                        // MessageBox.Show(days.ToString() + " " + hours.ToString() + " " + minites.ToString() + " " + remainder.ToString());
                        if (days < 1 && minites < -30)
                        {
                            if (DatPhong_BUS.HuyDatPhong_KH(kh.Id_datphongphong, p.IDPhong))
                            {
                                capnhattrngahthai = true;
                                MessageBox.Show("Đã cập nhật lại trạng thái phòng TRỐNG cho " + p.TenPhong + "\n"
                                    + "LÝ DO: QUÁ 30 PHÚT KHÁCH KHÔNG ĐẾN NHẬN", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            if(capnhattrngahthai)
            {
                DatPhong_DTO dp = new DatPhong_DTO();
                dp.IDDatPhong = kh.Id_datphongphong;
                DatPhong_BUS.Delete(dp);
            }    

        }
        private void MyTimer_Tick(object sender, EventArgs e)
        {
            Check_NgayDenNhan();
            LoadPhongAuTo();
        }
        List<Phong_DTO> listphong;

        public NguoiDung_DTO Nguoidung { get => nguoidung; set => nguoidung = value; }

        private ContextMenu CreateContextMenu_PhongTrong(Phong_DTO phongdto)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Cập nhật phòng", delegate (object sender, EventArgs e)
            {
                itemCNP_Click(sender, e, phongdto);
            });
            cm.MenuItems.Add("Đặt phòng", new EventHandler(itemDP_Click));
            cm.MenuItems.Add("Xóa phòng", new EventHandler(itemXoa_Click));
            return cm;
        }
        private ContextMenu CreateContextMenu_Themphong()
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Thêm phòng", new EventHandler(itemThemPhong_Click));
            return cm;
        }
        private ContextMenu CreateContextMenu_PhongCoKHachO(int id_datphong, KhachHang_DTO khthue, Phong_DTO phongdto)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Chi tiết đặt phòng", delegate (object sender, EventArgs e)
            {
                item_xemctdp_Click(sender, e,id_datphong, khthue.TenKH);
            });
            cm.MenuItems.Add("Chuyển phòng", delegate (object sender, EventArgs e)
            {
                item_xemcp_Click(sender, e, id_datphong, phongdto, khthue);
            });
            return cm;
        }
        private ContextMenu CreateContextMenu_PhongKhachDat(int id_datphong, Phong_DTO p)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Nhận phòng", new EventHandler(itemNhanphong_Click));
            cm.MenuItems.Add("Hủy đặt phòng", delegate (object sender, EventArgs e)
            {
                itemHuyDatPhong_Click(sender, e, id_datphong,p);
            });
            cm.MenuItems.Add("Xóa phòng", new EventHandler(itemXoa_Click));
            return cm;
        }
        private ContextMenu CreateContextMenu_PhongSuachua_Dondep(Phong_DTO phongdto)
        {
            ContextMenu cm = new ContextMenu();
            cm.MenuItems.Add("Cập nhật phòng", delegate (object sender, EventArgs e)
            {
                itemCNP_Click(sender, e,phongdto);
            });
            cm.MenuItems.Add("Xóa phòng", new EventHandler(itemXoa_Click));
            return cm;
        }
        private void itemDP_Click(object sender, EventArgs e)
        {
            frm_DatPhong dp = new frm_DatPhong(this);
            dp.ShowDialog();
        }
        private void itemCNP_Click(object sender, EventArgs e, Phong_DTO phongdto)
        {
            frm_capnhatphong dp = new frm_capnhatphong(this, phongdto);
            dp.ShowDialog();
        }

        private void itemThemPhong_Click(object sender, EventArgs e)
        {
            frm_DatPhong dp = new frm_DatPhong(this);
            dp.ShowDialog();
        }
        private void item_xemcp_Click(object sender, EventArgs e, int id_datphong,Phong_DTO phongdto, KhachHang_DTO khthue)
        {
            frm_chuyenphong chuyenphong = new frm_chuyenphong(id_datphong, phongdto, this, khthue);
            chuyenphong.ShowDialog();
        }
        private void item_xemctdp_Click(object sender, EventArgs e, int id_datphong, string tenkh)
        {
            frm_chitietdatphong chitietdatphong = new frm_chitietdatphong(id_datphong, tenkh, this,  nguoidung.TenNV);
            chitietdatphong.ShowDialog();
        }
        private void itemTTP_Click(object sender, EventArgs e)
        {
             
        }
        private void itemXoa_Click(object sender, EventArgs e)
        {

        }
        private void itemNhanphong_Click(object sender, EventArgs e)
        {

        }
        private void itemHuyDatPhong_Click(object sender, EventArgs e, int ID_Datphong,Phong_DTO p)
        {
            if(MessageBox.Show("Bạn có muốn hủy đặt phòng không ?","XÁC NHẬN HỦY", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                    if (DatPhong_BUS.HuyDatPhong_KH(ID_Datphong, p.IDPhong)){
                        DatPhong_DTO dp = new DatPhong_DTO();dp.IDDatPhong = ID_Datphong;
                        MessageBox.Show("Hủy đặt phòng thành công.","THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (DatPhong_BUS.DemSoLuongPhongDat(ID_Datphong) == null)
                            DatPhong_BUS.Delete(dp);
                        LoadPhongAuTo();
                    }
                    else
                        MessageBox.Show("Lỗi. Vui lòng thử lại.", "THÔNG BÁO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            }
        }

        public void LoadPhongAuTo() // LOAD GHE TỰ ĐỘNG BẰNG CODE
        {
            flowLayoutPanel1.Controls.Clear();
            listphong = new List<Phong_DTO>();
            listphong = Phong_BUS.LayDSPHongAll();
            int i = 1;
            foreach (Phong_DTO phongdto in listphong)
            {
                KhachHang_DTO kh_dat = DatPhong_BUS.TimKH_DatPhong(phongdto.IDPhong.ToString());
                KhachHang_DTO kh_thue = DatPhong_BUS.TimKH_ThuePhong(phongdto.IDPhong.ToString());

                if (phongdto.IDTrangThai == 1)//phong trong
                {
                    Button PHONG = new Button();
                    PHONG = new System.Windows.Forms.Button();
                    PHONG.BackColor = System.Drawing.Color.White;
                    PHONG.ContextMenu = CreateContextMenu_PhongTrong(phongdto);
                    PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongchuadat.png");
                    PHONG.ImageAlign = ContentAlignment.MiddleLeft;
                    PHONG.TextAlign = ContentAlignment.MiddleRight;
                    //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    PHONG.Name = phongdto.IDPhong.ToString();
                    PHONG.TabIndex = i;
                    string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                    string tienphonggio = phongdto.DongiaGio1.ToString("c", new CultureInfo("vi-VN"));
                    PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                        "Giá ngày: " + tienphong + "\n" +
                        "Giá giờ: " + tienphonggio + "\n" +
                        "Loại: " + phongdto.TenLoaiPhong.ToString() + "\n"+
                        "Tầng: " + phongdto.SoTang.ToString();
                    
                    PHONG.ForeColor = Color.Teal;
                    PHONG.Click += new EventHandler(frm_Phong_Click);
                    //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    PHONG.Size = new System.Drawing.Size(150, 80);
                    PHONG.TabIndex = i;
                    flowLayoutPanel1.Controls.Add(PHONG);
                    flowLayoutPanel1.Update();
                }
                else if (phongdto.IDTrangThai == 2)//phong đag sửa chữa
                {
                    Button PHONG = new Button();
                    PHONG = new System.Windows.Forms.Button();
                    PHONG.BackColor = System.Drawing.Color.GreenYellow;
                    PHONG.ContextMenu = CreateContextMenu_PhongSuachua_Dondep(phongdto);
                    PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongdangsuachua.png");
                    PHONG.ImageAlign = ContentAlignment.MiddleLeft;
                    PHONG.TextAlign = ContentAlignment.MiddleRight;
                    //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    PHONG.Name = phongdto.IDPhong.ToString();
                    PHONG.TabIndex = i;
                    string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                    string tienphonggio = phongdto.DongiaGio1.ToString("c", new CultureInfo("vi-VN"));
                    PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                        "Giá ngày: " + tienphong + "\n" +
                        "Giá giờ: " + tienphonggio + "\n" +
                        "Loại: " + phongdto.TenLoaiPhong.ToString()+"\n"+
                        "Tầng: " + phongdto.SoTang.ToString();
                    PHONG.ForeColor = Color.Teal;
                    PHONG.Click += new EventHandler(frm_Phong_Click);
                    //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    PHONG.Size = new System.Drawing.Size(150, 80);
                    PHONG.TabIndex = i;
                    flowLayoutPanel1.Controls.Add(PHONG);
                    flowLayoutPanel1.Update();
                }
                else if (phongdto.IDTrangThai == 3)//phong chưa dọn dẹp
                {
                    Button PHONG = new Button();
                    PHONG = new System.Windows.Forms.Button();
                    PHONG.ContextMenu = CreateContextMenu_PhongSuachua_Dondep(phongdto);
                    PHONG.BackColor = System.Drawing.Color.LightGoldenrodYellow;
                    PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongchuadon.png");
                    PHONG.ImageAlign = ContentAlignment.MiddleLeft;
                    PHONG.TextAlign = ContentAlignment.MiddleRight;
                    //PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    PHONG.Name = phongdto.IDPhong.ToString();
                    PHONG.TabIndex = i;
                    string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                    string tienphonggio = phongdto.DongiaGio1.ToString("c", new CultureInfo("vi-VN"));
                    PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                        "Giá ngày: " + tienphong + "\n" +
                        "Giá giờ: " + tienphonggio + "\n" +
                        "Loại: " + phongdto.TenLoaiPhong.ToString()+ "\n" +
                        "Tầng: " + phongdto.SoTang.ToString();

                    PHONG.ForeColor = Color.Teal;
                    PHONG.Click += new EventHandler(frm_Phong_Click);
                    //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                    PHONG.Size = new System.Drawing.Size(150, 80);
                    PHONG.TabIndex = i;
                    flowLayoutPanel1.Controls.Add(PHONG);
                    flowLayoutPanel1.Update();
                }

                else if (phongdto.IDTrangThai == 4)// phong da co khach DAG O
                {

                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.BackColor = System.Drawing.Color.Green;
                        PHONG.ContextMenu = CreateContextMenu_PhongCoKHachO(kh_thue.Id_datphongphong, kh_thue, phongdto);
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongcokhacho.png");
                        PHONG.ImageAlign = ContentAlignment.MiddleLeft;
                        PHONG.TextAlign = ContentAlignment.TopRight;
                        PHONG.ForeColor = Color.Black;
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;               
                        //  string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        int days = GetDaysBetween(DateTime.Now, kh_thue.Ngaytraphong);
                        TimeSpan ts = kh_thue.Ngaytraphong - DateTime.Now;
                        float hours = (float)ts.TotalHours;
                        float minites = (float)ts.TotalMinutes;
                        float remainder = hours % 24;
                        if (days <= 0 && remainder <= 12)
                        {
                            PHONG.BackColor = Color.AntiqueWhite;
                            PHONG.ForeColor = Color.Black;
                        }
                        else
                        {
                            PHONG.ForeColor = Color.Black;

                        }
                        PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                         if ((int)(remainder) > 0)
                         {

                            PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            kh_thue.TenKH + "\n"
                            + "SĐT: " + kh_thue.SDT_Kh + "\n"
                            + "Còn: " + days + " ngày " + (int)remainder + " giờ.";
                          }
                         else
                          {
                            PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            kh_thue.TenKH + "\n"
                            + "SĐT: " + kh_thue.SDT_Kh + "\n"
                            + "Còn: " + days + " ngày " + (int)minites + " phút.";
                         }    
                        PHONG.Click += new EventHandler(frm_Phong_Click);
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(150, 80);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                       flowLayoutPanel1.Update();
                    
                }
                else if (phongdto.IDTrangThai == 5)// phong da co khach dat
                {

                        Button PHONG = new Button();
                        PHONG = new System.Windows.Forms.Button();
                        PHONG.ContextMenu = CreateContextMenu_PhongKhachDat(kh_dat.Id_datphongphong, phongdto);
                        PHONG.BackColor = System.Drawing.Color.MediumPurple;
                        PHONG.Image = System.Drawing.Image.FromFile(@"D:\DABC_LTQL\phongdadat.png");
                        PHONG.ImageAlign = ContentAlignment.MiddleLeft;
                        PHONG.TextAlign = ContentAlignment.TopRight;
                        PHONG.ForeColor = Color.Black;
                        PHONG.Name = phongdto.IDPhong.ToString();
                        PHONG.TabIndex = i;
                        //  string tienphong = phongdto.DongiaPhong1.ToString("c", new CultureInfo("vi-VN"));
                        PHONG.ForeColor = Color.White;
                        PHONG.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        PHONG.Text = "Phòng: " + phongdto.TenPhong.ToString() + "\n" +
                            kh_dat.TenKH + "\n"
                            + "SĐT: " + kh_dat.SDT_Kh + "\n"
                            + "Ngày đến nhận:\n" + kh_dat.Ngaydatphong + "";
                        PHONG.Click += new EventHandler(frm_Phong_Click);
                        //  PHONG.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
                        PHONG.Size = new System.Drawing.Size(150, 80);
                        PHONG.TabIndex = i;
                        flowLayoutPanel1.Controls.Add(PHONG);
                        flowLayoutPanel1.Update();
                    
                }
                i++;

            }
        }

        public int GetDaysBetween(DateTime n1, DateTime n2)
        {
            TimeSpan ts = n2 - n1;
            return (int)ts.TotalDays;
        }



        private void frm_Phong_Click(object sender, EventArgs e)
        {

        }

    

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
       

        private void btn_themphong_Click(object sender, EventArgs e)
        {

        }

        private void btn_timphong_Click(object sender, EventArgs e)
        {

        }

        private void txt_timphong_Click(object sender, EventArgs e)
        {
            if (txt_timphong.Text == "Nhập phòng để tìm")
                txt_timphong.Clear();
        }

        private void txt_timphong_Leave(object sender, EventArgs e)
        {
            if (txt_timphong.Text != "")
            {

            }
            else
                txt_timphong.Text = "Nhập phòng để tìm";
        }
         
        private void loadLoaiPhong()
        {
            List<Loai_Phong_DTO> loaiphong = LoaiPhong_BUS.LayDSLOAIPHONG();
            dgv_loaiPhong.DataSource = loaiphong;
            cbb_loaiphong.DataSource = loaiphong;
        }

        private void btn_sualoai_Click(object sender, EventArgs e)
        {
            frm_CapNhat_LoaiPhong f1 = new frm_CapNhat_LoaiPhong();
            f1.ShowDialog();
        }
    }
}
