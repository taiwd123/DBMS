using BaiGiuXeVer2.Classes.Login;
using BaiGiuXeVer2.MyDB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    public partial class editProfileUC : UserControl
    {
        private int id;
        private string role;
        public editProfileUC()
        {
            InitializeComponent();
        }

        public void setID(int id)
        {
            this.id = id;
        }

        public void setRole(string role)
        {
            this.role = role;
        }

        private int maql;
        private void editProfileUC_Load(object sender, EventArgs e)
        {
            MyDBConnection db = new MyDBConnection(this.role);
            SqlCommand com = new SqlCommand("select * from f_Thong_Tin_NV_Theo_ID(@id)", db.getConnection());
            com.Parameters.Add("@id", SqlDbType.Int).Value = this.id;
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);

            maql = Convert.ToInt32(dt.Rows[0]["MaQL"].ToString().Trim());
            if (this.role == "Admin")
            {
                TextBox_TenQuanLy.Text = dt.Rows[0]["TenNV"].ToString().Trim();
            }
            else
            {
                SqlCommand com1 = new SqlCommand("select * from f_thong_tin_all_QL() as p where p.id = @maql", db.getConnection());
                com1.Parameters.Add("@maql", SqlDbType.Int).Value = maql;
                SqlDataAdapter da1 = new SqlDataAdapter(com1);
                DataTable dt1 = new DataTable();
                da1.Fill(dt1);

                TextBox_TenQuanLy.Text = dt1.Rows[0]["TenNV"].ToString().Trim();
            }

            TextBox_MaSo.Text = dt.Rows[0]["ID"].ToString().Trim();
            TextBox_HoTen.Text = dt.Rows[0]["TenNV"].ToString().Trim();
            if (dt.Rows[0]["GioiTinh"].ToString().Trim() == "Nu")
            {
                cboGioiTinh.Text = "Nữ";
            }
            else
            {
                cboGioiTinh.Text = dt.Rows[0]["GioiTinh"].ToString().Trim();
            }

            dtmNgaySinh.Value = DateTime.Parse(dt.Rows[0]["NgaySinh"].ToString().Trim());
            TextBox_SDT.Text = dt.Rows[0]["SoDT"].ToString().Trim();
            TextBox_DiaChi.Text = dt.Rows[0]["DiaChi"].ToString().Trim();
            try
            {
                if (dt.Rows[0]["Anh"] != DBNull.Value)
                {
                    MemoryStream ms = new MemoryStream((byte[])dt.Rows[0]["Anh"]);

                    pic_bienso.Image = new Bitmap(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận lưu thay đổi", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    ThongTin tt = new ThongTin(this.role);
                    int id_nv = Convert.ToInt32(TextBox_MaSo.Text.Trim());
                    string ten = TextBox_HoTen.Text.Trim();
                    string gioitinh = cboGioiTinh.Text.Trim();
                    string sdt = TextBox_SDT.Text.Trim();
                    string diachi = TextBox_DiaChi.Text.Trim();
                    int maqli = maql;
                    DateTime ngsinh = dtmNgaySinh.Value;
                    MemoryStream pic = new MemoryStream();
                    pic_bienso.Image.Save(pic, pic_bienso.Image.RawFormat);

                    if (tt.updateThonTin(id_nv, ten, gioitinh, sdt, diachi, maql, pic, ngsinh))
                    {
                        MessageBox.Show("Cập nhật thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void pic_bienso_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                pic_bienso.Image = new Bitmap(opnfd.FileName);
            }
        }
    }
}
