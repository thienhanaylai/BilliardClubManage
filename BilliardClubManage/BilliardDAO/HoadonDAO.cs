using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubManage.BilliardDAO
{
    internal class HoadonDAO
    {
        DataProvider DataProvider;

        public HoadonDAO()
        {
            DataProvider = new DataProvider();
        }

        public List<Hoadon> getListHoaDon()
        {
            DataProvider.Connect();
            List<Hoadon> listHoadon = new List<Hoadon>();
            string sql = "select * from Hoadon";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            while (rd.Read())
            {
                Hoadon hd = new Hoadon();
                hd.IDhoadon = rd.GetString(0);
                hd.Ngaylap = rd.GetDateTime(1);
                hd.Tongtien = rd.GetInt32(2);
                hd.Trangthai = rd.GetBoolean(3);
                hd.IDkh = rd.GetString(4);
                hd.IDnv = rd.GetString(5);
                listHoadon.Add(hd);
            }
            DataProvider.Close();
            return listHoadon;
        }

        public Hoadon getHoadonbyID(string id)
        {
            DataProvider.Connect();
            Hoadon hd = new Hoadon();
            string sql = "select * from Hoadon where IDhoadon = N'" + id + "'";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            if (rd.Read())
            {
                hd.IDhoadon = rd.GetString(0);
                hd.Ngaylap = rd.GetDateTime(1);
                hd.Tongtien = rd.GetInt32(2);
                hd.Trangthai = rd.GetBoolean(3);
                hd.IDkh = rd.GetString(4);
                hd.IDnv = rd.GetString(5);
            }
            DataProvider.Close();
            return hd;
        }

        public bool insertHoadon(Hoadon hd)
        {
            DataProvider.Connect();
            string timefortmat = ((DateTime)hd.Ngaylap).ToString("yyyy-MM-dd HH:mm:ss");
            int tranthai = 0;
            if (hd.Trangthai == false) tranthai = 0;
            else tranthai = 1;
            string sql = "insert into hoadon values(N'" + hd.IDhoadon + "', '" + timefortmat + "', " + hd.Tongtien + ", " + tranthai + ", N'" + hd.IDkh + "', N'" + hd.IDnv + "')";
            int result = DataProvider.ExecuteNonQuery(sql);
            if (result > 0)
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

        public bool updateHoadon(Hoadon hd)
        {
            try
            {
            DataProvider.Connect();
            string timefortmat = ((DateTime)hd.Ngaylap).ToString("yyyy-MM-dd HH:mm:ss");
            int tranthai = 0;
            if (hd.Trangthai == false) tranthai = 0;
            else tranthai = 1;
            string sql = "update hoadon set Ngaylap = '" + timefortmat + "', Tongtien = " + hd.Tongtien + ", Trangthai = " + tranthai + ", IDkh = N'" + hd.IDkh + "', IDnv = N'" + hd.IDnv + "' where IDhoadon = N'" + hd.IDhoadon + "'";
            int result = DataProvider.ExecuteNonQuery(sql);
            if (result == 0)
            {
                DataProvider.Close();
                return false;
            }
            else
            {
                DataProvider.Close();
                return true;
            }
            } catch(Exception ex)
            {
                return false;
            }
        }

        public bool checkPayment(string id) //false la chua thanh toan, true la da thanh toan
        {
            DataProvider.Connect();
            string sql = "select * from Hoadon where IDhoadon = N'" + id + "' and Trangthai = 0";//0 la chua thanh toan
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            if(rd.Read()) {
                DataProvider.Close();
                return false;
            }
            else
            {
                DataProvider.Close();
                return true;
            }
        }

        public Hoadon getHoadonByIdban(string id)
        {
            Hoadon hd = new Hoadon();
            DataProvider.Connect();
            string sql = "select * from Hoadon where IDhoadon in (select IDhoadon from chitiethoadon where IDban = N'" + id + "') and Trangthai = 0";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            if (rd.Read())
            {
                hd.IDhoadon = rd.GetString(0);
                hd.Ngaylap = rd.GetDateTime(1);
                hd.Tongtien = rd.GetInt32(2);
                hd.Trangthai = rd.GetBoolean(3);
                hd.IDkh = rd.GetString(4);
                hd.IDnv = rd.GetString(5);
            }
            DataProvider.Close();
            return hd;
        }
     }
}
