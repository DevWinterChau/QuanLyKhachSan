using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class NguoiDung_BUS
    {
        public static List<NguoiDung_DTO> LayDSNguoiDung()
        {
            return NguoiDung_DAO.LayDSNguoiDung();
        }
        public static bool add(NguoiDung_DTO nd)
        {
            return NguoiDung_DAO.add(nd);
        }
        public static bool Update(NguoiDung_DTO nd)
        {
            return NguoiDung_DAO.update(nd);
        }
        public static bool Delete(NguoiDung_DTO nd)
        {
            return NguoiDung_DAO.Delete(nd);
        }
        public static List<NguoiDung_DTO> TimNguoidungtheIDNV(int ma)
        {
            return NguoiDung_DAO.TimPhongtheoMaNV(ma);
        }
        public static List<NguoiDung_DTO> TimNguoidungtheTenNV(string ten)
        {
            return NguoiDung_DAO.TimPhongtheoTenNV(ten);
        }
        public static List<NguoiDung_DTO> TimNguoidungtheTenQuyen(string ten)
        {
            return NguoiDung_DAO.TimPhongtheoQuyen(ten);
        }
        public static bool CheckUSer(string user)
        {
            return NguoiDung_DAO.USERName(user);
        }
    }
}
