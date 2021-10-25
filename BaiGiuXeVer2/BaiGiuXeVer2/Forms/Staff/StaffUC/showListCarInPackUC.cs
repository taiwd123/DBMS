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

namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    public partial class showListCarInPackUC : UserControl
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
        public showListCarInPackUC()
        {
            InitializeComponent();
        }
        private void loadXeNgayTrongBai(DataTable dt)
        {
            gunaDataGridView1.DataSource = dt;
            gunaDataGridView1.AllowUserToAddRows = false;
            gunaDataGridView1.ReadOnly = true;
            gunaDataGridView1.Columns[0].HeaderText = "Biển Xe";
            gunaDataGridView1.Columns[1].HeaderText = "Check In";
            gunaDataGridView1.Columns[2].HeaderText = "Ảnh";
            if (gunaDataGridView1.Rows.Count > 0)
                gunaDataGridView1_MouseClick(null, null);
        }

        private void loadXeThangTrongBai(DataTable dt)
        {
            gunaDataGridView1.DataSource = dt;
            gunaDataGridView1.AllowUserToAddRows = false;
            gunaDataGridView1.ReadOnly = true;
            gunaDataGridView1.Columns[0].HeaderText = "Biển Xe";
            gunaDataGridView1.Columns[1].HeaderText = "Tên KH";
            gunaDataGridView1.Columns[2].HeaderText = "Địa Chỉ";
            gunaDataGridView1.Columns[3].HeaderText = "Điện Thoại";
            gunaDataGridView1.Columns[4].HeaderText = "Ảnh";
            gunaDataGridView1.Columns[5].HeaderText = "Check In";
            if (gunaDataGridView1.Rows.Count > 0)
                gunaDataGridView1_MouseClick(null, null);
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (rdoXeNgay.Checked)
            {
                string bienxe = TextBox_Search.Text.Trim();
                if(bienxe == "")
                {
                    ThongTinXe ttx = new ThongTinXe(this.role);
                    DataTable dt = ttx.getTTAllXeNgayTrongBai();
                    loadXeNgayTrongBai(dt);
                }
                else
                {
                    ThongTinXe ttx = new ThongTinXe(this.role);
                    DataTable dt = ttx.getTTXeNgayTrongBai(bienxe);
                    loadXeNgayTrongBai(dt);

                }
            }
            else
            {
                if (rdoXeThang.Checked)
                {
                    string bienxe = TextBox_Search.Text.Trim();
                    if (bienxe == "")
                    {
                        ThongTinXe ttx = new ThongTinXe(this.role);
                        DataTable dt = ttx.getTTAllXeThangTrongBai();
                        loadXeThangTrongBai(dt);
                    }
                    else
                    {
                        ThongTinXe ttx = new ThongTinXe(this.role);
                        DataTable dt = ttx.getTTXeThangTrongBai(bienxe);
                        loadXeThangTrongBai(dt);

                    }
                }
                else
                {
                    ThongTinXe ttx = new ThongTinXe(this.role);
                    DataTable dt = ttx.getTTAllXeNgayTrongBai();
                    loadXeNgayTrongBai(dt);
                }
            }
        }

        private void gunaDataGridView1_MouseClick(object sender, MouseEventArgs e)
        {
            
            if (rdoXeThang.Checked)
            {
                
                try
                {
                    TextBox_BienSo.Text = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                    TextBox_TenKH.Text = gunaDataGridView1.CurrentRow.Cells[1].Value.ToString().Trim();
                    TextBoxt_DiaChi.Text = gunaDataGridView1.CurrentRow.Cells[2].Value.ToString().Trim();
                    TextBox_SDT.Text = gunaDataGridView1.CurrentRow.Cells[3].Value.ToString().Trim();
                    if (gunaDataGridView1.CurrentRow.Cells[4].Value != DBNull.Value)
                    {
                        MemoryStream ms = new MemoryStream((byte[])gunaDataGridView1.CurrentRow.Cells[8].Value);

                        Pic_bienxe.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        Pic_bienxe.Image = BaiGiuXeVer2.Properties.Resources.default_DDLK_avatar;
                    }
                    dtm_NgayGui.Value = DateTime.Parse(gunaDataGridView1.CurrentRow.Cells[5].Value.ToString().Trim());
                    dtmNgayTra.Value = DateTime.Parse(gunaDataGridView1.CurrentRow.Cells[5].Value.ToString().Trim()).AddHours(24);
                }
                catch
                {
                    MessageBox.Show("Đây không phải là xe gửi tháng, vui lòng tìm lại","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            else
            {
                
                try
                {
                    TextBox_BienSo.Text = gunaDataGridView1.CurrentRow.Cells[0].Value.ToString().Trim();
                    dtm_NgayGui.Value = DateTime.Parse(gunaDataGridView1.CurrentRow.Cells[1].Value.ToString().Trim());
                    dtmNgayTra.Value = DateTime.Parse(gunaDataGridView1.CurrentRow.Cells[1].Value.ToString().Trim()).AddHours(24);
                    if (gunaDataGridView1.CurrentRow.Cells[2].Value != DBNull.Value)
                    {
                        MemoryStream ms = new MemoryStream((byte[])gunaDataGridView1.CurrentRow.Cells[8].Value);

                        Pic_bienxe.Image = Image.FromStream(ms);
                    }
                    else
                    {
                        Pic_bienxe.Image = BaiGiuXeVer2.Properties.Resources.default_DDLK_avatar;
                    }
                }
                catch
                {
                    MessageBox.Show("Đây không phải là xe gửi ngày, vui lòng tìm lại", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void showListCarInPackUC_Load(object sender, EventArgs e)
        {
            TextBoxt_DiaChi.Visible = true;
            TextBox_BienSo.Visible = true;
            TextBox_Phat.Visible = true;
            TextBox_TenKH.Visible = true;
            TextBox_SDT.Visible = true;
            dtmNgayTra.Visible = true;
            dtm_NgayGui.Visible = true;
            Pic_bienxe.Visible = true;


            TextBoxt_DiaChi.Enabled = false;
            TextBox_BienSo.Enabled = false;
            TextBox_Phat.Enabled = false;
            TextBox_TenKH.Enabled = false;
            TextBox_SDT.Enabled = false;
            dtmNgayTra.Enabled = false;
            dtm_NgayGui.Enabled = false;
            Pic_bienxe.Enabled = false;
        }
    }
}
