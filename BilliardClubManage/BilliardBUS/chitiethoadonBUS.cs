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
        public static bool insertCTHD(chitiethoadon n)
        {
            return new BilliardDAO.chitiethoadonDAO().insertChitiethoadon(n);
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
