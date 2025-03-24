using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BilliardClubManage.BilliardDTO;


namespace BilliardClubManage.BilliardDAO
{
    internal class NhanvienDAO
    {
        DataProvider dataProvider;

        public NhanvienDAO()
        {
            dataProvider = new DataProvider();
        }

        public List<Nhanvien> getListNV()
        {
            //lay danh sach nhan vien
            dataProvider.Connect();
            List<Nhanvien> listNV = new List<Nhanvien>();
            string sql = "select * from Nhanvien";
            SqlDataReader rd = dataProvider.SqlDataReader(sql);
            while (rd.Read()) {
            Nhanvien nv = new Nhanvien();
               nv.IDnv = rd.GetString(0);
                string Ho = rd.GetString(1);
                string Ten = rd.GetString(2);
                nv.Hoten = Ho + " " + Ten;
                nv.Ngaysinh = rd.GetDateTime(3);
                nv.Gioitinh= rd.GetBoolean(4);
                nv.Chucvu = rd.GetString(5);
                nv.Matkhau = rd.GetString(6);
                listNV.Add(nv);
            }
            dataProvider.Close();
            return listNV;
        }
        
        public bool validateNv(string id,string pw)
        {
            string sql = "select * from Nhanvien where IDnv = N'" + id + "' and Matkhau = N'" + pw+ "'";
            dataProvider.Connect();
            SqlDataReader rd = dataProvider.SqlDataReader(sql);
            if (rd.Read())
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

        public Nhanvien getNVbyID(string id)
        {
            string sql = "select * from Nhanvien where IDnv = N'" + id + "'";
            dataProvider.Connect();
            SqlDataReader rd = dataProvider.SqlDataReader(sql);
            Nhanvien nv = new Nhanvien();
            if (rd.Read())
            {
                nv.IDnv = rd.GetString(0).Trim();
                string Ho = rd.GetString(1).Trim();
                string Ten = rd.GetString(2).Trim();
                nv.Hoten = Ho + " " + Ten;
                nv.Ngaysinh = rd.GetDateTime(3);
                nv.Gioitinh = rd.GetBoolean(4);
                nv.Chucvu = rd.GetString(5).Trim();
                nv.Matkhau = rd.GetString(6).Trim();
            }
            return nv;
        }

        public bool insertNV(string id, string ho, string ten, DateTime ngaysinh, bool gioitinh, string chucvu, string matkhau)
        {
            string sql = "insert into Nhanvien values(N'" + id + "',N'" + ho + "', N'" + ten +"',N'" + ngaysinh + "',N'" + gioitinh + "',N'" + chucvu + "',N'" + matkhau + "')";
            dataProvider.Connect();
            int flag = dataProvider.ExecuteNonQuery(sql);
            if(flag > 0)
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

    }
}
