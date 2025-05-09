using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubManage.BilliardDAO
{
    internal class KhoDAO
    {
        DataProvider DataProvider;

        public KhoDAO()
        {
            DataProvider = new DataProvider();
        }

        public List<Kho> getDsHangHoa()
        {
            DataProvider.Connect();
            List<Kho> ds = new List<Kho>();
            string sql = "select * from kho";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            while (rd.Read())
            {
                Kho k = new Kho();
                k.Idhanghoa = rd.GetString(0);
                k.Soluong = rd.GetInt32(1);
                ds.Add(k);
            }
            DataProvider.Close();
            return ds;
        }

        public int getSoLuong(string id)
        {
            DataProvider.Connect();
            string sql = "select * from kho where IDhanghoa = N'" + id + "'";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            if (rd.Read())
            {
                int sl = rd.GetInt32(1);
                DataProvider.Close();
                return sl;
            }
            else
            {
                DataProvider.Close();
                return 0;
            }
        }

        public bool updateKho(string id, int sl)
        {
            string sql = "update kho set Soluong = Soluong + " + sl + " where IDhanghoa = N'" + id + "'";
            DataProvider.Connect();
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            if (rd.Read())
            {
                DataProvider.Close();
                return true;
            }
            else
            {
                DataProvider.Close();
                return false;
            }
        }

        public bool insertHH(string id, int sl) //them hang hoa vao kho
        {
            string sql = "insert into kho values(N'" + id + "'," + sl + ")";
            DataProvider.Connect();
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            if (rd.Read())
            {
                DataProvider.Close();
                return true;
            }
            else
            {
                DataProvider.Close();
                return false;
            }
        }

        public bool updateSl(string id, int sl)
        {
            DataProvider.Connect();
            string sql = "update kho set Soluong=" + sl + " where IDhanghoa=N'" + id + "'";
            int kq = DataProvider.ExecuteNonQuery(sql);
            DataProvider.Close();
            if (kq > 0)
                return true;
            else
                return false;
        }
    }
}
