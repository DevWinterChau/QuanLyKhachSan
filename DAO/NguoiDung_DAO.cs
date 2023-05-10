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
    public class NguoiDung_DAO
    {
        static SqlConnection con;
        public static List<NguoiDung_DTO> LayDSNguoiDung()
        {
            string sTruyVan = "select nv.ID_NV, nv.HOTEN_NV , nd.username , nd.pass , pq.TEN_QUYEN from NguoiDung nd, PHANQUYEN pq, NHANVIEN nv where nd.ID_NV = nv.ID_NV and nd.ID_QUYEN = pq.ID_QUYEN";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NguoiDung_DTO> ltsNguoiDung = new List<NguoiDung_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.IDNV = int.Parse(dt.Rows[i]["ID_NV"].ToString());
                nd.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                nd.USERName= dt.Rows[i]["username"].ToString();
                nd.Password = dt.Rows[i]["pass"].ToString();
                nd.TenQuyen = dt.Rows[i]["TEN_QUYEN"].ToString();
                ltsNguoiDung.Add(nd);
            }
            return ltsNguoiDung;
        }
        public static bool add(NguoiDung_DTO nd)
        {
            string sTruyVan = string.Format(@"insert into NguoiDung values('{0}','{1}','{2}','{3}')",
               nd.IDNV, nd.USERName , nd.Password , nd.IDQuyen);
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            KetNoi.Dongketnoi();
            return kq;

        }
        public static bool update(NguoiDung_DTO nd)
        {
            string sTruyVan = "update NguoiDung set ID_NV =N'" + nd.IDNV+
                    "', pass = '" +nd.Password+ "', ID_QUYEN= '" +nd.IDQuyen +
                    "' where username = '"+ nd.USERName+"'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static bool Delete(NguoiDung_DTO nd)
        {
            string sTruyVan = " delete NguoiDung where username = '" + nd.USERName+ "'";
            con = KetNoi.MoKetNoi();
            bool kq = KetNoi.TruyVanKhongLayDuLieu(sTruyVan, con);
            return kq;
        }
        public static List<NguoiDung_DTO> TimPhongtheoMaNV(int ma)
        {
            string sTruyVan = string.Format(@"select nv.ID_NV, nv.HOTEN_NV , nd.username , nd.pass , pq.TEN_QUYEN from NguoiDung nd, PHANQUYEN pq, NHANVIEN nv where nd.ID_NV = nv.ID_NV and nd.ID_QUYEN = pq.ID_QUYEN and nv.ID_NV='{0}'", ma);
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NguoiDung_DTO> ltsNguoiDung = new List<NguoiDung_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.IDNV = int.Parse(dt.Rows[i]["ID_NV"].ToString());
                nd.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                nd.USERName = dt.Rows[i]["username"].ToString();
                nd.Password = dt.Rows[i]["pass"].ToString();
                nd.TenQuyen = dt.Rows[i]["TEN_QUYEN"].ToString();
                ltsNguoiDung.Add(nd);
            }
            return ltsNguoiDung;
        }
        public static List<NguoiDung_DTO> TimPhongtheoTenNV(string ten)
        {
            string sTruyVan = "select nv.ID_NV, nv.HOTEN_NV , nd.username , nd.pass , pq.TEN_QUYEN from NguoiDung nd, PHANQUYEN pq, NHANVIEN nv where nd.ID_NV = nv.ID_NV and nd.ID_QUYEN = pq.ID_QUYEN and nv.HOTEN_NV like N'%"+ten+"%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NguoiDung_DTO> ltsNguoiDung = new List<NguoiDung_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.IDNV = int.Parse(dt.Rows[i]["ID_NV"].ToString());
                nd.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                nd.USERName = dt.Rows[i]["username"].ToString();
                nd.Password = dt.Rows[i]["pass"].ToString();
                nd.TenQuyen = dt.Rows[i]["TEN_QUYEN"].ToString();
                ltsNguoiDung.Add(nd);
            }
            return ltsNguoiDung;
        }
        public static List<NguoiDung_DTO> TimPhongtheoQuyen(string quyen)
        {
            string sTruyVan = "selectnv.ID_NV, nv.HOTEN_NV , nd.username , nd.pass , pq.TEN_QUYEN from NguoiDung nd, PHANQUYEN pq, NHANVIEN nv where nd.ID_NV = nv.ID_NV and nd.ID_QUYEN = pq.ID_QUYEN and pq.TEN_QUYEN like N'%" + quyen+"%'";
            con = KetNoi.MoKetNoi();
            DataTable dt = KetNoi.TruyVanLayDuLieu(sTruyVan, con);
            if (dt.Rows.Count == 0)
            {
                return null;
            }
            List<NguoiDung_DTO> ltsNguoiDung = new List<NguoiDung_DTO>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                NguoiDung_DTO nd = new NguoiDung_DTO();
                nd.IDNV = int.Parse(dt.Rows[i]["ID_NV"].ToString());
                nd.TenNV = dt.Rows[i]["HOTEN_NV"].ToString();
                nd.USERName = dt.Rows[i]["username"].ToString();
                nd.Password = dt.Rows[i]["pass"].ToString();
                nd.TenQuyen = dt.Rows[i]["TEN_QUYEN"].ToString();
                ltsNguoiDung.Add(nd);
            }
            return ltsNguoiDung;
        }
        public static bool USERName(string user)
        {
            using (con)
            {
                string sTruyVan = "SELECT COUNT(*) FROM NguoiDung WHERE username ='" + user + "'";
                using (SqlCommand command = new SqlCommand(sTruyVan, con))
                {
                    KetNoi.MoKetNoi();
                    int count = (int)command.ExecuteScalar();
                    if (count > 0)
                    {
                        return false;
                    }
                    return true;

                }
            }
        }
    }
}
