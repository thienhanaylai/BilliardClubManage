using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Shapes;
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
            if(ban.IDban == "")
            {
                if(ban.Loaiban == "Pool")
                {
                    ban.IDban = "L" + new unity().getID("seqLo");
                } else if(ban.Loaiban == "Libre")
                {
                    ban.IDban = "P" + new unity().getID("seqPhang");
                }
            }
            return new BanDAO().insertBan(ban);
        }

        public static bool updateBan(Ban ban)
        {
            return new BanDAO().updateBan(ban);
        }

        public static bool updateGio(Ban ban)
        {
            return new BanDAO().updateGio(ban);
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
