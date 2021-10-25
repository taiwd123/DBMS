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

namespace BaiGiuXeVer2.Forms.Manager.ManagerUC
{
    public partial class registerUC : UserControl
    {
        private int id;
        private string role;

        public void setID(int id)
        {
            this.id = id;
        }
        public void setRole(string role)
        {
            this.role = role;
        }
        public registerUC()
        {
            InitializeComponent();
        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVaiTro.Text == "Admin")
            {
                cboQuanLy.Enabled = false;
            }
            else
            {
                if (cboVaiTro.Text == "Quản lý")
                {
                    cboQuanLy.DataSource = null;
                    cboQuanLy.Enabled = false;
                }
                else
                {
                    load_cbxQL();
                    cboQuanLy.Enabled = true;
                }
            }
        }
        private void load_cbxQL()
        {
            MyDBConnection db = new MyDBConnection(this.role);
            SqlDataAdapter da = new SqlDataAdapter();
            DataTable dt = new DataTable();
            SqlCommand comm = new SqlCommand("select * from f_thong_tin_all_QL()", db.getConnection());
            da.SelectCommand = comm;
            da.Fill(dt);

            cboQuanLy.DataSource = dt;
            cboQuanLy.DisplayMember = "tennv";
            cboQuanLy.ValueMember = "id";
        }

        private void btnDangKy_Click(object sender, EventArgs e)
        {
            try
            {
                int id_nv = Convert.ToInt32(TextBox_MaSo.Text.Trim());
                int maql;
                if (cboVaiTro.Text == "Admin" || cboVaiTro.Text == "Quản lý")
                {
                    maql = Convert.ToInt32(TextBox_MaSo.Text.Trim());
                }
                else
                {
                    maql = Convert.ToInt32(cboQuanLy.SelectedValue.ToString());
                }
                string ten = TextBox_HoTen.Text.Trim();
                string gioitinh;
                if (cboGioiTinh.Text.Trim() == "Nữ")
                {
                    gioitinh = "Nu";
                }
                else
                {
                    gioitinh = cboGioiTinh.Text.Trim();
                }
                string sdt = TextBox_SDT.Text.Trim();
                string diachi = TextBox_DiaChi.Text.Trim();
                string user = TextBox_Username.Text.Trim();
                string pass = TextBox_Password.Text.Trim();
                DateTime ngaysinh = dtmNgaySinh.Value;
                MemoryStream pic = new MemoryStream();
                pic_bienso.Image.Save(pic, pic_bienso.Image.RawFormat);
                string role_name;
                if (cboVaiTro.Text.Trim() == "Quản lý")
                {
                    role_name = "QuanLi";
                }
                else
                {
                    if (cboVaiTro.Text.Trim() == "Nhân viên")
                    {
                        role_name = "NhanVien";
                    }
                    else
                    {
                        role_name = "Admin";
                    }
                }



                if (check_tt(id_nv, maql, ten, gioitinh, sdt, diachi, user, pass, ngaysinh, pic))
                {
                    ThongTin nv = new ThongTin(this.role);
                    bool check = nv.insertNV(id_nv, ten, gioitinh, sdt, diachi, maql, user, pass, pic, ngaysinh);
                    nv.insertRoleNV(id_nv, role_name);
                    if (check == true)
                    {
                        MessageBox.Show("Thêm thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        reset();
                    }
                    else
                    {
                        MessageBox.Show("Thêm thất bại", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show("Điền đầy đủ các thông tin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool check_tt(int id_nv, int maql, string ten, string gtinh, string sdt, string diachi, string user, string pass, DateTime ngsinh, MemoryStream pic)
        {
            if (id_nv == null || maql == null || ten == "" || gtinh == "" || sdt == "" || diachi == "" || user == "" || pass == "" || ngsinh == null || pic == null)
            {
                return false;
            }
            return true;
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

        private void registerUC_Load(object sender, EventArgs e)
        {
            MyDBConnection db = new MyDBConnection(this.role);

            dtmNgaySinh.Format = DateTimePickerFormat.Custom;
            dtmNgaySinh.CustomFormat = "dd/MM/yyyy";
            load_cbxQL();
        }
        private void reset()
        {
            TextBox_MaSo.Text = "";
            TextBox_DiaChi.Text = "";
            TextBox_HoTen.Text = "";
            TextBox_SDT.Text = "";
            TextBox_Username.Text = "";
            TextBox_Password.Text = "";
            pic_bienso.Image = BaiGiuXeVer2.Properties.Resources.default_DDLK_avatar;
        }
    }
}
