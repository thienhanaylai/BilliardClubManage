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


    }
}
