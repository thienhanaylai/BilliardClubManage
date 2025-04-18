using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubManage.BilliardDAO
{
    internal class BanDAO
    {
        DataProvider dataProvider;

        public BanDAO()
        {
            dataProvider = new DataProvider();
        }

        public List<Ban> getListBan()
        {
            dataProvider.Connect();
            List<Ban> listBan = new List<Ban>();
            string sql = "select * from Ban";
            SqlDataReader rd = dataProvider.SqlDataReader(sql);
            while (rd.Read())
            {
                Ban ban = new Ban();
                ban.IDban = rd.GetString(0);
                ban.Tenban = rd.GetString(1);
                ban.Tinhtrang = rd.GetBoolean(2);
                ban.Khuvuc = rd.GetString(3);
                if(rd.IsDBNull(4))
                    ban.GioBD = null;
                else ban.GioBD = rd.GetDateTime(4);
                if(rd.IsDBNull(5))
                    ban.GioKT = null;
                else ban.GioKT = rd.GetDateTime(5);
                ban.Dongia = rd.GetInt32(6);
                if(rd.IsDBNull(7))
                    ban.Loaiban = "null";
                else ban.Loaiban = rd.GetString(7);
                listBan.Add(ban);
            }
            dataProvider.Close();
            return listBan;
        }
    }
}
