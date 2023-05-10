using DAO;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HoaDon_BUS
    {
        public static List<HoaDon_DTO> LayDSHD()
        {
            return HoaDon_DAO.LayDSHoadon();
        }
        public static bool add(HoaDon_DTO hd)
        {
            return HoaDon_DAO.add(hd);
        }
        public static bool Update(HoaDon_DTO hd)
        {
            return HoaDon_DAO.update(hd);
        }
        public static bool Delete(HoaDon_DTO hd)
        {
            return HoaDon_DAO.Delete(hd);
        }
        public static List<HoaDon_DTO> TimHDtheoIDHD(int ma)
        {
            return HoaDon_DAO.TimHDtheoIDHD(ma);
        }
        public static List<HoaDon_DTO> TimHDtheoNgayGD(DateTime ngay)
        {
            return HoaDon_DAO.TimHDtheoGianGD(ngay);
        }
        public static List<HoaDon_DTO> TimHDtheoTenKH(string ten)
        {
            return HoaDon_DAO.TimHDtheotenKH(ten);
        }
        public static List<HoaDon_DTO> TimHDtheoIDDATPHONG(int ma)
        {
            return HoaDon_DAO.TimHDtheoIDDATPHONG(ma);
        }
        public static HoaDon_DTO TimHDtheoID()
        {
            return HoaDon_DAO.TimHD_ID();
        }
    }
}
