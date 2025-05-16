using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sunny.UI;

namespace BilliardClubManage.BilliardDAO
{
    internal class unity
    {
        DataProvider DataProvider;

        public unity()
        {
            DataProvider = new DataProvider();
        }

        public string getID(string loaiid) //id ban
        {
            DataProvider.Connect();
            string sql = "SELECT NEXT VALUE FOR " + loaiid + ";";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            string id = "";
            while (rd.Read())
            {
                id = rd.GetInt64(0).ToString();
            }
            DataProvider.Close();
            return id;
        }

        public string getIDhd() //id hang hoa
        {
            DataProvider.Connect();
            string sql = "select next value for seqHoadon;";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            string id = "";
            if (rd.Read())
            {
                id = rd.GetInt64(0).ToString();
            }
            DataProvider.Close();
            return id;
        }

        public string getIDhdct() //id hoa don chi tiet
        {
            DataProvider.Connect();
            string sql = "select next value for SeqChiTietHoaDonId;";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            string id = "";
            if (rd.Read())
            {
                id = rd.GetInt64(0).ToString();
            }
            DataProvider.Close();
            return id;
        }
    }
}
