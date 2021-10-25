using BaiGiuXeVer2.MyDB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiGiuXeVer2.Classes.Login
{
    class ThongTin
    {
        private string role;
        public ThongTin(string role)
        {
            this.role = role;
        }

        
        public bool insertNV(int id, string ten, string gtinh, string sdt, string diachi, int maql, string user, string pass, MemoryStream anh, DateTime ngsinh)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("insert_nhan_vien", conn.getConnection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@id", SqlDbType.Int).Value = id;
            com.Parameters.Add("@ten", SqlDbType.VarChar).Value = ten;
            com.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = gtinh;
            com.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            com.Parameters.Add("@diachi", SqlDbType.VarChar).Value = diachi;
            com.Parameters.Add("@maql", SqlDbType.Int).Value = maql;
            com.Parameters.Add("@user", SqlDbType.VarChar).Value = user;
            com.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;
            com.Parameters.Add("@anh", SqlDbType.Image).Value = anh.ToArray();
            com.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngsinh;

            conn.OpenConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                conn.ClosedConnection();
                return true;
            }
            else
            {
                conn.ClosedConnection();
                return false;
            }
            
        }
        public bool insertRoleNV(int id_nv, string role_name)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("insert_role_acc", conn.getConnection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@id_nv", SqlDbType.Int).Value = id_nv;
            com.Parameters.Add("@role_name", SqlDbType.VarChar).Value = role_name;

            conn.OpenConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                conn.ClosedConnection();
                return true;
            }
            else
            {
                conn.ClosedConnection();
                return false;
            }

        }
        public DataTable getThongTinNV(int id_nv)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("select * from f_thong_tin_NV(@maNV)", conn.getConnection());
            com.Parameters.Add("@maNV", SqlDbType.Int).Value = id_nv;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable getAllNV()
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("select * from f_thong_tin_all_NV()", conn.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllQL()
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("select * from f_thong_tin_all_QL()", conn.getConnection());
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable getAllNV_TheoMaQL(int id_nv)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("select * from f_thong_tin_NV_Theo_MQL(@id)", conn.getConnection());
            com.Parameters.Add("@id", SqlDbType.Int).Value = id_nv;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable search_Ten(string name)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("select NhanVien.Id, TenNV, GioiTinh, NgaySinh, SoDT, role_name, DiaChi,MaQL, Anh from nhanvien, role_acc where nhanvien.id = role_acc.id_nv and tennv like '%"+name+"%'", conn.getConnection());
            com.Parameters.Add("@name", SqlDbType.VarChar).Value = name;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public DataTable search_ID(int Id)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("select * from f_Thong_Tin_NV_Theo_ID(@id)", conn.getConnection());
            com.Parameters.Add("@id", SqlDbType.Int).Value = Id;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        public bool updateThonTin(int id_nv, string ten, string giotinh, string sdt, string diachi, int maql, MemoryStream anh, DateTime ngaysinh)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("update_thong_tin_nhan_vien", conn.getConnection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@id", SqlDbType.Int).Value = id_nv;
            com.Parameters.Add("@ten", SqlDbType.VarChar).Value = ten;
            com.Parameters.Add("@gioitinh", SqlDbType.VarChar).Value = giotinh;
            com.Parameters.Add("@sdt", SqlDbType.VarChar).Value = sdt;
            com.Parameters.Add("@diachi", SqlDbType.VarChar).Value = diachi;
            com.Parameters.Add("@maql", SqlDbType.Int).Value = maql;
            com.Parameters.Add("@anh", SqlDbType.Image).Value = anh.ToArray();
            com.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = ngaysinh;

            conn.OpenConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                conn.ClosedConnection();
                return true;
            }
            else
            {
                conn.ClosedConnection();
                return false;
            }
        }

        public bool updateRoleNV(int id_nv, string role_name)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("update_role_acc", conn.getConnection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@id", SqlDbType.Int).Value = id_nv;
            com.Parameters.Add("@role_name", SqlDbType.VarChar).Value = role_name;

            conn.OpenConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                conn.ClosedConnection();
                return true;
            }
            else
            {
                conn.ClosedConnection();
                return false;
            }
        }


        public DataTable QL_search_id(int id_ql, int id_nv)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("select * from f_thong_tin_NV_Theo_MQL(@id) where id = @id_nv", conn.getConnection());
            com.Parameters.Add("@id", SqlDbType.Int).Value = id_ql;
            com.Parameters.Add("@id_nv", SqlDbType.Int).Value = id_nv;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable QL_search_name(int id_ql, string tennv)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("select * from f_thong_tin_NV_Theo_MQL(@id) where tennv like '%" + tennv +"%'", conn.getConnection());
            com.Parameters.Add("@id", SqlDbType.Int).Value = id_ql;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public bool deleteNhanVien(int id_nv)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("delete_nhan_vien", conn.getConnection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@id", SqlDbType.Int).Value = id_nv;

            conn.OpenConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                conn.ClosedConnection();
                return true;
            }
            else
            {
                conn.ClosedConnection();
                return false;
            }

        }
        public bool deleteRoleNV(int id_nv)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("delete_role_acc", conn.getConnection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@id", SqlDbType.Int).Value = id_nv;

            conn.OpenConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                conn.ClosedConnection();
                return true;
            }
            else
            {
                conn.ClosedConnection();
                return false;
            }

        }
        public bool updatePass(int id_nv, string pass)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("update_pass", conn.getConnection());
            com.CommandType = CommandType.StoredProcedure;
            com.Parameters.Add("@id_nv", SqlDbType.Int).Value = id_nv;
            com.Parameters.Add("@pass", SqlDbType.VarChar).Value = pass;

            conn.OpenConnection();
            if (com.ExecuteNonQuery() == 1)
            {
                conn.ClosedConnection();
                return true;
            }
            else
            {
                conn.ClosedConnection();
                return false;
            }

        }

        public DataTable getUserPass(int id_nv)
        {
            MyDBConnection conn = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("select * from f_Lay_MK_NV(@manv)", conn.getConnection());
            com.Parameters.Add("@manv", SqlDbType.Int).Value = id_nv;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
