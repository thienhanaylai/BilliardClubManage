using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDAO;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubManage.BilliardBUS
{
    internal class HoadonBUS
    {
        public static List<Hoadon> getDsHoaDon()
        {
            return new HoadonDAO().getListHoaDon();
        }

        public static Hoadon getHoadonbyId(string id)
        {
            return new HoadonDAO().getHoadonbyID(id);
        }

        public static bool insertHoaDon(Hoadon hoadon)
        {
            return new HoadonDAO().insertHoadon(hoadon);
        }

        public static bool updateHoadon(Hoadon hoadon)
        {
            return new HoadonDAO().updateHoadon(hoadon);
        }


        public static bool checkPayment(string id)
        {
            return new HoadonDAO().checkPayment(id); //false la chua thanh toan, true la da thanh toan
        }
    }
}
