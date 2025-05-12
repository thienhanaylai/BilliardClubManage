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

        public bool vaidateID(string id)
        {
            string sql = "select * from Ban where IDban = N'" + id + "'";
            dataProvider.Connect();
            SqlDataReader rd = dataProvider.SqlDataReader(sql);
            if (rd.Read()) // neu co kq tra ve la id da ton tai => true
            {
                dataProvider.Close();
                return true;
            }
            else
            {
                dataProvider.Close();
                return false;
            }
        }

        public Ban getBanbyID(string id)
        {
            string sql = "select * from Ban where IDban = N'" + id + "'";
            dataProvider.Connect();
            SqlDataReader rd = dataProvider.SqlDataReader(sql);
            Ban ban = new Ban();
            if (rd.Read())
            {
                ban.IDban = rd.GetString(0);
                ban.Tenban = rd.GetString(1);
                ban.Tinhtrang = rd.GetBoolean(2);
                ban.Khuvuc = rd.GetString(3);
                if (rd.IsDBNull(4))
                    ban.GioBD = null;
                else ban.GioBD = rd.GetDateTime(4);
                if (rd.IsDBNull(5))
                    ban.GioKT = null;
                else ban.GioKT = rd.GetDateTime(5);
                ban.Dongia = rd.GetInt32(6);
                if (rd.IsDBNull(7))
                    ban.Loaiban = "null";
                else ban.Loaiban = rd.GetString(7);
            }
            return ban;
        }

        public bool insertBan(Ban ban)
        {
            string sql = "exec insertBan N'" + ban.IDban + "',N'" + ban.Tenban + "'," + 0 + ",N'" + ban.Khuvuc + "'," + "null" + "," + "null" + "," + ban.Dongia + ",N'" + ban.Loaiban + "'";
            dataProvider.Connect();
            int kq = dataProvider.ExecuteNonQuery(sql);
            dataProvider.Close();
            if (kq > 0)
                return true;
            else
                return false;
        } 

        public bool updateBan(Ban ban)
        {
            string sql = "exec updateBan '" + ban.IDban + "','" + ban.Tenban + "'," + ban.Tinhtrang + ",'" + ban.Khuvuc + "','" + ((object)ban.GioBD ?? DBNull.Value) + "','" + ((object)ban.GioKT ?? DBNull.Value) + "'," + ban.Dongia + ",'" + ban.Loaiban + "'";
            dataProvider.Connect();
            int kq = dataProvider.ExecuteNonQuery(sql);
            dataProvider.Close();
            if (kq > 0)
                return true;
            else
                return false;
        }

        public bool updateGio(Ban ban)
        {
            string sql = "exec updateBan '" + ban.IDban + "','" + ban.Tenban + "'," + ban.Tinhtrang + ",'" + ban.Khuvuc + "','" + ((object)ban.GioBD ?? DBNull.Value) + "','" + ((object)ban.GioKT ?? DBNull.Value) + "'," + ban.Dongia + ",'" + ban.Loaiban + "'";
            if (ban.Tinhtrang == true)
            {
                string giobd = ((DateTime)ban.GioBD).ToString("yyyy-MM-dd HH:mm:ss");
                sql = "exec updateBan '" + ban.IDban + "','" + ban.Tenban + "'," + ban.Tinhtrang + ",'" + ban.Khuvuc + "','" + giobd + "','" + ((object)ban.GioKT ?? DBNull.Value) + "'," + ban.Dongia + ",'" + ban.Loaiban + "'";
            } else
            {
                string giobd = ((DateTime)ban.GioBD).ToString("yyyy-MM-dd HH:mm:ss");
                string giokt = ((DateTime)ban.GioKT).ToString("yyyy-MM-dd HH:mm:ss");
                sql = "exec updateBan '" + ban.IDban + "','" + ban.Tenban + "'," + ban.Tinhtrang + ",'" + ban.Khuvuc + "','" + giobd + "','" + giokt + "'," + ban.Dongia + ",'" + ban.Loaiban + "'";

            }

            dataProvider.Connect();
            int kq = dataProvider.ExecuteNonQuery(sql);
            dataProvider.Close();
            if (kq > 0)
                return true;
            else
                return false;

        }

        public bool deleteBan(string id)
        {
            string sql = "exec dropBan '" + id + "'";
            dataProvider.Connect();
            int flag = dataProvider.ExecuteNonQuery(sql);
            if (flag > 0)
            {
                dataProvider.Close();
                return true;
            }
            else
            {
                dataProvider.Close();
                return false;
            }
        }

        public List<Ban> getListBanByKhuVuc(string khuvuc)
        {
            List<Ban> listBan = new List<Ban>();
            string sql = "select * from ban where Khuvuc = N'" + khuvuc + "'";
            dataProvider.Connect();
            SqlDataReader rd = dataProvider.SqlDataReader(sql);
            while (rd.Read())
            {
                Ban ban = new Ban();
                ban.IDban = rd.GetString(0);
                ban.Tenban = rd.GetString(1);
                ban.Tinhtrang = rd.GetBoolean(2);
                ban.Khuvuc = rd.GetString(3);
                if (rd.IsDBNull(4))
                    ban.GioBD = null;
                else ban.GioBD = rd.GetDateTime(4);
                if (rd.IsDBNull(5))
                    ban.GioKT = null;
                else ban.GioKT = rd.GetDateTime(5);
                ban.Dongia = rd.GetInt32(6);
                if (rd.IsDBNull(7))
                    ban.Loaiban = "null";
                else ban.Loaiban = rd.GetString(7);
                listBan.Add(ban);
            }
            dataProvider.Close();
            return listBan;
        }


    }
}
