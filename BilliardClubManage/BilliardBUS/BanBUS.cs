using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDAO;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubBUS
{
    internal class BanBUS
    {

        public static List<Ban> getListBan()
        {
                return new BanDAO().getListBan();
        }

        public static Ban getBanbyID(string id)
        {
            return new BanDAO().getBanbyID(id);
        }

        public static bool validateID(string id)
        {
            return new BanDAO().vaidateID(id);
        }

        public static bool insertBan(Ban ban)
        {
            return new BanDAO().insertBan(ban);
        }

        public static bool updateBan(Ban ban)
        {
            return new BanDAO().updateBan(ban);
        }

        public static bool deleteBan(string id)
        {
            return new BanDAO().deleteBan(id);
        }

        public static List<Ban> getListBanByKhuVuc(string khuvuc)
        {
            return new BanDAO().getListBanByKhuVuc(khuvuc);
        }
    }
}
