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

        private int convertDonviToInt(string donvi)
        {
            int dv = 0;
            switch (donvi)
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
                case "Goi":
                    dv = 4;
                    break;
                case "Dia":
                    dv = 5;
                    break;
                default:
                    dv = 1;
                    break;
            }
            return dv;
        }

        private string convertDonviToString(int donvi) {
            string dv = "";
            switch (donvi)
            {
                case 1:
                    dv = "Lon";
                    break;
                case 2:
                    dv = "Chai";
                    break;
                case 3:
                    dv = "Ly";
                    break;
                case 4:
                    dv = "Goi";
                    break;
                case 5:
                    dv = "Dia";
                    break;
                default:
                    dv = "Lon";
                    break;
            }
            return dv;
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
                hanghoa.Donvi = convertDonviToString(rd.GetInt32(2));
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
                hh.Donvi = convertDonviToString( rd.GetInt32(2));
                hh.Gia = rd.GetInt32(3);
                hh.Soluong = rd.IsDBNull(4) ? 0 : rd.GetInt32(4);
            }
            DataProvider.Close();
            return hh;
        }

        //lay danh sach hang hoa theo loai nuoc hoac thuc an va so uong trong kho lon hon 0
        public List<Hanghoa> getListhhbyLoai(string loai)
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
                hanghoa.Donvi = convertDonviToString(rd.GetInt32(2));
                hanghoa.Gia = rd.GetInt32(3);
                hanghoa.Soluong = rd.IsDBNull(4) ? 0 : rd.GetInt32(4);
                if(hanghoa.Donvi == loai && hanghoa.Soluong > 0)
                    listHangHoa.Add(hanghoa);
            }
            DataProvider.Close();
            return listHangHoa;
        }

        public bool insertHanghoa(Hanghoa hh)
        {
            DataProvider.Connect();
            int dv = 0;
            dv = convertDonviToInt(hh.Donvi);
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
            dv = convertDonviToInt(hh.Donvi);
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
