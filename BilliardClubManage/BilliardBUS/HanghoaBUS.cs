using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDAO;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubBUS
{
    internal class HanghoaBUS
    {
        public static List<Hanghoa> getListHH()
        {
            return new HanghoaDAO().getListHangHoa();
        }


        public static List<Hanghoa> getListHhByLoai(string loai)
        {
            return new HanghoaDAO().getListhhbyLoai(loai);
        }

        public static bool insertHH(Hanghoa h)
        {
            return new HanghoaDAO().insertHanghoa(h);   
        }

        public static Hanghoa getHHbyId(string id)
        {
            return new HanghoaDAO().getHangHoabyID(id);
        }

        public static bool updateHanghoa(Hanghoa hh)
        {
            return new HanghoaDAO().updateHanghoa(hh);
        }

        public static bool deleteHanghoa(string id)
        {
            return new HanghoaDAO().deleteHanghoa(id);
        }   

    }
}
