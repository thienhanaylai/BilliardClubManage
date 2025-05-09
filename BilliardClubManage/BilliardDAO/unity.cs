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

        public string getID(string loaiid)
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
    }
}
