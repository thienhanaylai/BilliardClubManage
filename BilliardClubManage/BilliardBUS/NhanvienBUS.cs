using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDAO;
using BilliardClubManage.BilliardDTO;


namespace BilliardClubBUS
{
    internal class NhanvienBUS
    {
        public static List<Nhanvien> getListNV()
        {
            return new NhanvienDAO().getListNV();
        }

        public static bool validateNV(string id,string pw)
        {
            return new NhanvienDAO().validateNv(id, pw);
        }

        public static Nhanvien getNVbyId(string id)
        {
            return new NhanvienDAO().getNVbyID(id);
        }
    }
}
