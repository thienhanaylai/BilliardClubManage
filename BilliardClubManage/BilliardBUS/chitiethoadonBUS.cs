using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubManage.BilliardBUS
{
    internal class chitiethoadonBUS
    {
        public static bool insertCTHD(string id,string idhoadon, string idhanghoa, int soluong, string idban, int sogiochoi)
        {
            return new BilliardDAO.chitiethoadonDAO().insertChitiethoadon(id, idhoadon, idhanghoa, soluong, idban, sogiochoi);
        }

        public static List<chitiethoadon> getDsSanphamByIDHoadon(string id)
        {
            return new BilliardDAO.chitiethoadonDAO().getDsSanPhamByIDHoadon(id);
        }

        public static bool updateCTHD(chitiethoadon hd)
        {
            return new BilliardDAO.chitiethoadonDAO().updatecthd(hd);
        }
    }
}
