using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDAO;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubBUS
{
    internal class KhoBUS
    {
        public static List<Kho> getDsHangHoa()
        {
          return new KhoDAO().getDsHangHoa();
        }

        public static int getSoLuong(string id)
        {
           return new KhoDAO().getSoLuong(id);
        }

        public static bool updateKho(string id, int sl)
        {
            return new KhoDAO().updateKho(id, sl);
        }

        public static bool insertHHKho(string id, int sl) //them hang hoa vao kho
        {
            return  new KhoDAO().insertHH(id, sl);
        }
        public static bool updateSoluong(string id, int sl) //cap nhat so luong hang hoa
        {
            return new KhoDAO().updateSl(id, sl);
        }
    }
}
