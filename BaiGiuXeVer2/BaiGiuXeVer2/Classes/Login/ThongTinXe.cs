using BaiGiuXeVer2.MyDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.Classes.Login
{
    class ThongTinXe
    {
        private string role;

        public ThongTinXe(string role)
        {
            this.role = role;
        }

        public DataTable getTTXeNgay(string bienxe)
        {
            MyDBConnection db = new MyDBConnection(role);
            SqlCommand com = new SqlCommand("select * from f_Thong_Tin_Xe_Ve_Ngay(@bienxe)", db.getConnection());
            com.Parameters.Add("@bienxe", SqlDbType.VarChar).Value = bienxe;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getTTXeNgayTrongBai(string bienxe)
        {
            MyDBConnection db = new MyDBConnection(role);
            SqlCommand com = new SqlCommand("select * from f_Thong_Tin_Xe_Ve_Ngay_Trong_Bai(@bienxe)", db.getConnection());
            com.Parameters.Add("@bienxe", SqlDbType.VarChar).Value = bienxe;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getTTAllXeNgayTrongBai()
        {
            MyDBConnection db = new MyDBConnection(role);
            SqlCommand com = new SqlCommand("select * from f_Thong_Tin_All_Xe_Ve_Ngay_Trong_Bai()", db.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable getTTXeThangTrongBai(string bienxe)
        {
            MyDBConnection db = new MyDBConnection(role);
            SqlCommand com = new SqlCommand("select * from f_thong_tin_xe_thang_trong_bai_theo_bien(@bienxe)", db.getConnection());
            com.Parameters.Add("@bienxe", SqlDbType.VarChar).Value = bienxe;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getTTAllXeThangTrongBai()
        {
            MyDBConnection db = new MyDBConnection(role);
            SqlCommand com = new SqlCommand("select * from f_thong_tin_xe_thang_trong_bai()", db.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
