using BaiGiuXeVer2.Classes.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Manager.ManagerUC
{
    public partial class showInfoStaffUC : UserControl
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
        public showInfoStaffUC()
        {
            InitializeComponent();
        }

        private void cboVaiTro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVaiTro.Text == "Admin" || cboVaiTro.Text == "Quản lý")
            {
                cboQuanLy.Enabled = false;
            }
            else
            {
                cboQuanLy.Enabled = true;
            }
        }
        private void loadDataGridView(DataTable dt)
        {
            gunaDataGridView1.DataSource = dt;
            gunaDataGridView1.AllowUserToAddRows = false;
            gunaDataGridView1.ReadOnly = true;
            gunaDataGridView1.Columns[0].HeaderText = "ID";
            gunaDataGridView1.Columns[1].HeaderText = "Tên";
            gunaDataGridView1.Columns[2].HeaderText = "Giới Tính";
            gunaDataGridView1.Columns[3].HeaderText = "Ngày Sinh";
            gunaDataGridView1.Columns[4].HeaderText = "Số ĐT";
            gunaDataGridView1.Columns[5].HeaderText = "Vai Trò";
            gunaDataGridView1.Columns[6].HeaderText = "Dịa Chỉ";
            gunaDataGridView1.Columns[7].HeaderText = "Mã QL";
            gunaDataGridView1.Columns[8].HeaderText = "Anh";
            if (gunaDataGridView1.Rows.Count > 0)
                gunaDataGridView1_MouseClick(null, null);
        }

        private void reloadAllNV()
        {
            ThongTin tt = new ThongTin(this.role);
            if (this.role == "Admin")
            {
                loadDataGridView(tt.getAllNV());
            }
            else
            {
                if (this.role == "QuanLi")
                {
                    loadDataGridView(tt.getAllNV_TheoMaQL(this.id));
                }
            }
        }

        private void gunaDataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            TextBox_MaSo.Text = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
            TextBox_HoTen.Text = gunaDataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
            if (gunaDataGridView1.CurrentRow.Cells[2].Value.ToString().Trim() == "Nu")
            {
                cboGioiTinh.Text = "Nữ";
            }
            else
            {
                cboGioiTinh.Text = gunaDataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
            }
            dtmNgaySinh.Value = DateTime.Parse(gunaDataGridView1.CurrentRow.Cells[3].Value.ToString().Trim());
            TextBox_SDT.Text = gunaDataGridView1.CurrentRow.Cells[4].Value.ToString().Trim();
            string role = gunaDataGridView1.CurrentRow.Cells[5].Value.ToString().Trim();
            if (role == "QuanLi")
            {
                cboVaiTro.Text = "Quản lý";
            }
            else
            {
                if (role == "NhanVien")
                {
                    cboVaiTro.Text = "Nhân viên";
                }
                else
                {
                    cboVaiTro.Text = "Admin";
                }
            }
            TextBox_DiaChi.Text = gunaDataGridView1.CurrentRow.Cells[6].Value.ToString().Trim();
            int maqli = Convert.ToInt32(gunaDataGridView1.CurrentRow.Cells[7].Value.ToString().Trim());
            try
            {
                if (gunaDataGridView1.CurrentRow.Cells[8].Value != DBNull.Value)
                {
                    MemoryStream ms = new MemoryStream((byte[])gunaDataGridView1.CurrentRow.Cells[8].Value);

                    Pic_ADD.Image = Image.FromStream(ms);
                }
                else
                {
                    Pic_ADD.Image = BaiGiuXeVer2.Properties.Resources.default_DDLK_avatar;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            ThongTin tt = new ThongTin(role);
            DataTable dt = tt.search_ID(maqli);
            cboQuanLy.DataSource = dt;
            cboQuanLy.DisplayMember = "tennv";
            cboQuanLy.ValueMember = "id";
        }

        private void Pic_ADD_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnfd = new OpenFileDialog();
            opnfd.Filter = "Image Files (*.jpg;*.jpeg;*.png;.*.gif;)|*.jpg;*.jpeg;*.png;.*.gif";
            if (opnfd.ShowDialog() == DialogResult.OK)
            {
                Pic_ADD.Image = new Bitmap(opnfd.FileName);
            }
        }

        private void cboQuanLy_Click(object sender, EventArgs e)
        {
            ThongTin tt = new ThongTin(this.role);
            DataTable dt = tt.getAllQL();
            cboQuanLy.DataSource = dt;
            cboQuanLy.DisplayMember = "tennv";
            cboQuanLy.ValueMember = "id";
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Xác nhận lưu thay đổi", "Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    int id_nv = Convert.ToInt32(TextBox_MaSo.Text.Trim());
                    string ten = TextBox_HoTen.Text.Trim();
                    string gioitinh;
                    if(cboGioiTinh.Text.Trim() == "Nữ")
                    {
                        gioitinh = "Nu";
                    }
                    else
                    {
                        gioitinh = "Nam";
                    }
                    string sdt = TextBox_SDT.Text.Trim();
                    string diachi = TextBox_DiaChi.Text.Trim();
                    DateTime ngsinh = dtmNgaySinh.Value;
                    MemoryStream pic = new MemoryStream();
                    Pic_ADD.Image.Save(pic, Pic_ADD.Image.RawFormat);
                    string role_curr;
                    if (cboVaiTro.Text.Trim() == "Quản lý")
                    {
                        role_curr = "QuanLi";
                    }
                    else
                    {
                        if (cboVaiTro.Text.Trim() == "Nhân viên")
                        {
                            role_curr = "NhanVien";
                        }
                        else
                        {
                            role_curr = "Admin";
                        }
                    }
                    int maql_curr;

                    ThongTin tt = new ThongTin(this.role);
                    DataTable dt = tt.search_ID(id_nv);

                    string role_pre = dt.Rows[0]["role_name"].ToString().Trim();
                    int maql_pre = Convert.ToInt32(dt.Rows[0]["maql"].ToString().Trim());

                    if (role_curr == "Admin" && role_pre != role_curr)
                    {
                        MessageBox.Show("Không thể cập nhật vai trò khác thành admin");
                    }
                    else
                    {
                        if (role_pre == "Admin" && role_pre != role_curr)
                        {
                            MessageBox.Show("Không thể cập nhật admin thành vai trò khác");
                        }
                        else
                        {
                            if (role_curr == "QuanLi")
                            {
                                maql_curr = id_nv;
                                if (tt.updateThonTin(id_nv, ten, gioitinh, sdt, diachi, maql_curr, pic, ngsinh) && tt.updateRoleNV(id_nv, role_curr))
                                {
                                    MessageBox.Show("Lưu thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Lưu không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                            }
                            else
                            {
                                if (role_curr == "NhanVien" && role_pre == "QuanLi")
                                {
                                    if (Convert.ToInt32(cboQuanLy.SelectedValue.ToString().Trim()) == id_nv)
                                    {
                                        MessageBox.Show("Cần chọn lại quản lí", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                    }
                                    else
                                    {
                                        maql_curr = Convert.ToInt32(cboQuanLy.SelectedValue.ToString().Trim());
                                        if (tt.updateThonTin(id_nv, ten, gioitinh, sdt, diachi, maql_curr, pic, ngsinh) && tt.updateRoleNV(id_nv, role_curr))
                                        {
                                            MessageBox.Show("Lưu thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Lưu không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                }
                                else
                                {
                                    if(role_curr == "NhanVien" && role_pre == "NhanVien")
                                    {
                                        maql_curr = Convert.ToInt32(cboQuanLy.SelectedValue.ToString().Trim());
                                        if (tt.updateThonTin(id_nv, ten, gioitinh, sdt, diachi, maql_curr, pic, ngsinh) && tt.updateRoleNV(id_nv, role_curr))
                                        {
                                            MessageBox.Show("Lưu thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                        }
                                        else
                                        {
                                            MessageBox.Show("Lưu không thành công", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                        }
                                    }
                                }
                            }
                        }
                    } 

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            reloadAllNV();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if (rboHoTen.Checked)
            {
                string name = TextBox_Search.Text.Trim();
                if (name == "")
                {
                    reloadAllNV();
                }
                else
                {
                    ThongTin tt = new ThongTin(this.role);
                    if(this.role == "Admin")
                    {
                        loadDataGridView(tt.search_Ten(name));
                    }
                    if(this.role == "QuanLi")
                    {
                        loadDataGridView(tt.QL_search_name(this.id, name));
                    }
                }
            }
            else
            {
                string id_nv = TextBox_Search.Text.Trim();
                if (rdoMaSo.Checked)
                {
                    if (id_nv == "")
                    {
                        reloadAllNV();
                    }
                    else
                    {
                        ThongTin tt = new ThongTin(this.role);
                        try
                        {
                            int ma_nv = Convert.ToInt32(id_nv);
                            if (this.role == "Admin")
                            {
                                loadDataGridView(tt.search_ID(ma_nv));
                            }
                            if (this.role == "QuanLi")
                            {
                                loadDataGridView(tt.QL_search_id(this.id, ma_nv));
                            }

                        }
                        catch
                        {
                            MessageBox.Show("ID không hợp lệ", "Eror", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        
                    }
                }
                else
                {
                    if (TextBox_Search.Text.Trim() == "")
                    {
                        reloadAllNV();
                    }
                    else
                    {
                        MessageBox.Show("Chọn phương thức để tìm kiếm", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void btn_remove_Click(object sender, EventArgs e)
        {
            string id_text = TextBox_MaSo.Text.Trim();
            string role_nv = cboVaiTro.Text.Trim();
            if(role_nv == "Admin")
            {
                MessageBox.Show("Không thể xóa Admin", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                if (role_nv == "Quản lý")
                {
                    MessageBox.Show("Cần chỉnh quyền quản lí các nhân viên khác của quản lí này và thay đổi quyền quản lí thành nhân viên, trước khi thao tác xóa", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (id_text == "")
                    {
                        MessageBox.Show("Chọn nhan viên để xóa", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else
                    {
                        try
                        {
                            int id_nv = Convert.ToInt32(id_text);
                            ThongTin tt = new ThongTin(this.role);
                            if (tt.deleteRoleNV(id_nv))
                            {
                                if (tt.deleteNhanVien(id_nv))
                                {
                                    MessageBox.Show("Đã xóa nhân viên", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                                else
                                {
                                    MessageBox.Show("Xóa không thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Cần chỉnh lại quản lí của các nhân viên trước khi xóa nhân viên này", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            
            
        }
    }
}
