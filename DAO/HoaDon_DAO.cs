using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class HoaDon_DAO
    {
        static SqlConnection con;
        public static List<HoaDon_DTO> LayDSHoadon()
        {
            string sTruyVan = "select hd.ID_HDTT ,hd.NGAYGD_HDTT , cty.TEN_CTY , nv.HOTEN_NV , kh.HOTEN_KH , hd.ID_DATPHONG , hd.TONG_HDTT " +
                "from HD_THANHTOAN hd, CTY cty, NHANVIEN nv, DATPHONG dp, KHang kh " +
                "where hd.ID_CTY = cty.ID_CTY and hd.ID_DATPHONG = dp.ID_DATPHONG and hd.ID_NV = nv.ID_NV and dp.ID_KH = kh.ID_KH";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> ltsDShoaDon = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.IDHD = int.Parse(dt.Rows[i]["ID_HDTT"].ToString());
                hd.NgayGD = DateTime.Parse(dt.Rows[i]["NGAYGD_HDTT"].ToString());
                hd.Tencty= dt.Rows[i]["TEN_CTY"].ToString();
                hd.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                hd.Tenkh = dt.Rows[i]["HOTEN_KH"].ToString();
                hd.IDDatphong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                hd.TongHD = float.Parse(dt.Rows[i]["TONG_HDTT"].ToString());
                ltsDShoaDon.Add(hd);
            }
            return ltsDShoaDon;
        }
        public static bool add(HoaDon_DTO hd)
        {
            string sTruyVan = string.Format(@"insert into HD_THANHTOAN values('{0}', {1}, {2},{3},{4})",
                hd.NgayGD, hd.IDCty,hd.IDNV ,hd.TongHD, hd.IDDatphong);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(HoaDon_DTO hd)
        {
            string sTruyVan = "update HD_THANHTOAN set TONG_HDTT = " + hd.TongHD + " , ID_NV = "+hd.IDNV+"" +
                    " where ID_HDTT = " +hd.IDHD + "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(HoaDon_DTO hd)
        {
            string sTruyVan = " delete HD_THANHTOAN where ID_HDTT = " + hd.IDHD+ "";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<HoaDon_DTO> TimHDtheoIDHD(int maHD)
        {
            string sTruyVan = string.Format(@"select hd.ID_HDTT ,hd.NGAYGD_HDTT , cty.TEN_CTY , nv.HOTEN_NV , kh.HOTEN_KH , hd.ID_DATPHONG , hd.TONG_HDTT "" +
                from HD_THANHTOAN hd, CTY cty, NHANVIEN nv, DATPHONG dp, KHang kh 
                where hd.ID_CTY = cty.ID_CTY and hd.ID_DATPHONG = dp.ID_DATPHONG and hd.ID_NV = nv.ID_NV and dp.ID_KH = kh.ID_KH and hd.ID_HDTT ='{0}'", maHD);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> ltsDShoaDon = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.IDHD = int.Parse(dt.Rows[i]["ID_HDTT"].ToString());
                hd.NgayGD = DateTime.Parse(dt.Rows[i]["NGAYGD_HDTT"].ToString());
                hd.Tencty = dt.Rows[i]["TEN_CTY"].ToString();
                hd.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                hd.Tenkh = dt.Rows[i]["HOTEN_KH"].ToString();
                hd.IDDatphong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                hd.TongHD = float.Parse(dt.Rows[i]["TONG_HDTT"].ToString());
                ltsDShoaDon.Add(hd);
            }
            return ltsDShoaDon;
        }
        public static List<HoaDon_DTO> TimHDtheoIDDATPHONG(int maDP)
        {
            string sTruyVan = string.Format(@"select hd.ID_HDTT ,hd.NGAYGD_HDTT , cty.TEN_CTY , nv.HOTEN_NV , kh.HOTEN_KH , hd.ID_DATPHONG , hd.TONG_HDTT "" +
                from HD_THANHTOAN hd, CTY cty, NHANVIEN nv, DATPHONG dp, KHang kh 
                where hd.ID_CTY = cty.ID_CTY and hd.ID_DATPHONG = dp.ID_DATPHONG and hd.ID_NV = nv.ID_NV and dp.ID_KH = kh.ID_KH and hd.ID_DATPHONG='{5}'", maDP);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> ltsDShoaDon = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.IDHD = int.Parse(dt.Rows[i]["ID_HDTT"].ToString());
                hd.NgayGD = DateTime.Parse(dt.Rows[i]["NGAYGD_HDTT"].ToString());
                hd.Tencty = dt.Rows[i]["TEN_CTY"].ToString();
                hd.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                hd.Tenkh = dt.Rows[i]["HOTEN_KH"].ToString();
                hd.IDDatphong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                hd.TongHD = float.Parse(dt.Rows[i]["TONG_HDTT"].ToString());
                ltsDShoaDon.Add(hd);
            }
            return ltsDShoaDon;
        }
        public static List<HoaDon_DTO> TimHDtheotenKH(string tenkh)
        {
            string sTruyVan = string.Format(@"select hd.ID_HDTT ,hd.NGAYGD_HDTT , cty.TEN_CTY , nv.HOTEN_NV , kh.HOTEN_KH , hd.ID_DATPHONG , hd.TONG_HDTT "" +
                from HD_THANHTOAN hd, CTY cty, NHANVIEN nv, DATPHONG dp, KHang kh 
                where hd.ID_CTY = cty.ID_CTY and hd.ID_DATPHONG = dp.ID_DATPHONG and hd.ID_NV = nv.ID_NV and dp.ID_KH = kh.ID_KH and kh.HOTEN_KH  ='{4}'", tenkh);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> ltsDShoaDon = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.IDHD = int.Parse(dt.Rows[i]["ID_HDTT"].ToString());
                hd.NgayGD = DateTime.Parse(dt.Rows[i]["NGAYGD_HDTT"].ToString());
                hd.Tencty = dt.Rows[i]["TEN_CTY"].ToString();
                hd.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                hd.Tenkh = dt.Rows[i]["HOTEN_KH"].ToString();
                hd.IDDatphong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                hd.TongHD = float.Parse(dt.Rows[i]["TONG_HDTT"].ToString());
                ltsDShoaDon.Add(hd);
            }
            return ltsDShoaDon;
        }
        public static List<HoaDon_DTO> TimHDtheoGianGD(DateTime thgian)
        {
            string sTruyVan = string.Format(@"select hd.ID_HDTT ,hd.NGAYGD_HDTT , cty.TEN_CTY , nv.HOTEN_NV , kh.HOTEN_KH , hd.ID_DATPHONG , hd.TONG_HDTT "" +
                from HD_THANHTOAN hd, CTY cty, NHANVIEN nv, DATPHONG dp, KHang kh 
                where hd.ID_CTY = cty.ID_CTY and hd.ID_DATPHONG = dp.ID_DATPHONG and hd.ID_NV = nv.ID_NV and dp.ID_KH = kh.ID_KH  and hd.NGAYGD_HDTT ='{1}'", thgian);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<HoaDon_DTO> ltsDShoaDon = new List<HoaDon_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                HoaDon_DTO hd = new HoaDon_DTO();
                hd.IDHD = int.Parse(dt.Rows[i]["ID_HDTT"].ToString());
                hd.NgayGD = DateTime.Parse(dt.Rows[i]["NGAYGD_HDTT"].ToString());
                hd.Tencty = dt.Rows[i]["TEN_CTY"].ToString();
                hd.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                hd.Tenkh = dt.Rows[i]["HOTEN_KH"].ToString();
                hd.IDDatphong = int.Parse(dt.Rows[i]["ID_DATPHONG"].ToString());
                hd.TongHD = float.Parse(dt.Rows[i]["TONG_HDTT"].ToString());
                ltsDShoaDon.Add(hd);
            }
            return ltsDShoaDon;
        }
        public static HoaDon_DTO TimHD_ID()
        {
            string sTruyVan = "select MAX(ID_DATPHONG) as ID_HDTT from DATPHONG";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
               HoaDon_DTO hd = new HoaDon_DTO();
               hd.IDDatphong = int.Parse(dt.Rows[0]["ID_HDTT"].ToString());
           
            return hd;
        }
    }
}
