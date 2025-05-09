using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDTO;

namespace BilliardClubManage.BilliardDAO
{
    internal class HanghoaDAO
    {
        DataProvider DataProvider;

        public HanghoaDAO()
        {
            DataProvider = new DataProvider();
        }

        public List<Hanghoa> getListHangHoa()
        {
            List<Hanghoa> listHangHoa = new List<Hanghoa>();
            DataProvider.Connect();
            string sql = "select hanghoa.*,kho.Soluong from hanghoa left join kho on hanghoa.IDhanghoa = kho.IDhanghoa";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            while (rd.Read())
            {
                Hanghoa hanghoa = new Hanghoa();
                hanghoa.IDhanghoa = rd.GetString(0);
                hanghoa.Tenhanghoa = rd.GetString(1);
                switch ( rd.GetInt32(2))
                {
                    case 1:
                        hanghoa.Donvi = "Lon";
                        break;
                    case 2:
                        hanghoa.Donvi = "Chai";
                        break;
                    case 3:
                        hanghoa.Donvi = "Ly";
                        break;
                    default:
                        hanghoa.Donvi = "Lon";
                        break;
                }

                hanghoa.Gia = rd.GetInt32(3);
                hanghoa.Soluong = rd.IsDBNull(4) ? 0 : rd.GetInt32(4);
                listHangHoa.Add(hanghoa);
            }
            DataProvider.Close();
            return listHangHoa;
        }

        public Hanghoa getHangHoabyID(string id)
        {
            DataProvider.Connect();
            string sql = "select hanghoa.*,kho.Soluong from hanghoa left join kho on hanghoa.IDhanghoa = kho.IDhanghoa where hanghoa.IDhanghoa = N'" + id + "'";
            SqlDataReader rd = DataProvider.SqlDataReader(sql);
            Hanghoa hh = new Hanghoa();
            if (rd.Read())
            {
                hh.IDhanghoa = rd.GetString(0);
                hh.Tenhanghoa = rd.GetString(1);
                switch (rd.GetInt32(2))
                {
                    case 1:
                        hh.Donvi = "Lon";
                        break;
                    case 2:
                        hh.Donvi = "Chai";
                        break;
                    case 3:
                        hh.Donvi = "Ly";
                        break;
                    default:
                        hh.Donvi = "Lon";
                        break;
                }
                hh.Gia = rd.GetInt32(3);
                hh.Soluong = rd.IsDBNull(4) ? 0 : rd.GetInt32(4);
            }
            DataProvider.Close();
            return hh;
        }

        public bool insertHanghoa(Hanghoa hh)
        {
            DataProvider.Connect();
            int dv = 0;
            switch (hh.Donvi)
            {
                case "Lon":
                    dv = 1;
                    break;
                case "Chai":
                    dv = 2;
                    break;
                case "Ly":
                    dv = 3;
                    break;
                default:
                    dv = 1;
                    break;
            }
            string sql = "insert into Hanghoa values(N'" + hh.IDhanghoa + "',N'" + hh.Tenhanghoa + "',N'" + dv + "'," + hh.Gia + ")";
            int kq = DataProvider.ExecuteNonQuery(sql);
            DataProvider.Close();
            if (kq > 0)
                return true;
            else
                return false;
        }

        public bool updateHanghoa(Hanghoa hh)
        {
            DataProvider.Connect();
            int dv = 0;
            switch (hh.Donvi)
            {
                case "Lon":
                    dv = 1;
                    break;
                case "Chai":
                    dv = 2;
                    break;
                case "Ly":
                    dv = 3;
                    break;
                default:
                    dv = 1;
                    break;
            }
            string sql = "update Hanghoa set Tenhanghoa=N'" + hh.Tenhanghoa + "',Donvi=N'" + dv + "',Gia=" + hh.Gia + " where IDhanghoa=N'" + hh.IDhanghoa + "'";
          
            int kq = DataProvider.ExecuteNonQuery(sql);
            DataProvider.Close();
            if (kq > 0)
                return true;
            else
                return false;
        }

        public bool deleteHanghoa(string id)
        {
            DataProvider.Connect();
            string sql = "delete from Hanghoa where IDhanghoa=N'" + id + "'";
            int kq = DataProvider.ExecuteNonQuery(sql);
            DataProvider.Close();
            if (kq > 0)
                return true;
            else
                return false;
        }

 

    }
}
