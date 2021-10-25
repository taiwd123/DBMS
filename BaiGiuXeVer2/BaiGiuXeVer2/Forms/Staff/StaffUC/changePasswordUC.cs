using BaiGiuXeVer2.Classes.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    public partial class changePasswordUC : UserControl
    {
        private int id;
        private string role;
        public changePasswordUC()
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

        private void textCurrentPassword_Enter(object sender, EventArgs e)
        {
            if (textCurrentPassword.Text == "Current Password")
            {
                if (!cbShowPassword.Checked)
                {
                    textCurrentPassword.UseSystemPasswordChar = true;
                }
                else
                {
                    textCurrentPassword.UseSystemPasswordChar = false;
                }
                textCurrentPassword.Text = "";
            }
        }

        private void textCurrentPassword_Leave(object sender, EventArgs e)
        {
            if (textCurrentPassword.Text == "")
            {
                textCurrentPassword.UseSystemPasswordChar = false;
                textCurrentPassword.Text = "Current Password";
            }
        }

        private void textNewPassword_Enter(object sender, EventArgs e)
        {
            if (textNewPassword.Text == "New Password")
            {
                if (!cbShowPassword.Checked)
                {
                    textNewPassword.UseSystemPasswordChar = true;
                }
                else
                {
                    textNewPassword.UseSystemPasswordChar = false;
                }
                textNewPassword.Text = "";
            }
        }

        private void textNewPassword_Leave(object sender, EventArgs e)
        {
            if (textNewPassword.Text == "")
            {
                textNewPassword.UseSystemPasswordChar = false;
                textNewPassword.Text = "New Password";
            }
        }

        private void textConfirmNewPassword_Enter(object sender, EventArgs e)
        {
            if (textConfirmNewPassword.Text == "Confirm New Password")
            {
                if (!cbShowPassword.Checked)
                {
                    textConfirmNewPassword.UseSystemPasswordChar = true;
                }
                else
                {
                    textConfirmNewPassword.UseSystemPasswordChar = false;
                }
                textConfirmNewPassword.Text = "";
            }
        }

        private void textConfirmNewPassword_Leave(object sender, EventArgs e)
        {
            if (textConfirmNewPassword.Text == "")
            {
                textConfirmNewPassword.UseSystemPasswordChar = false;
                textConfirmNewPassword.Text = "Confirm New Password";
            }
        }

        private void cbShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cbShowPassword.Checked)
            {
                textCurrentPassword.UseSystemPasswordChar = false;
                textNewPassword.UseSystemPasswordChar = false;
                textConfirmNewPassword.UseSystemPasswordChar = false;
            }
            else
            {
                if (textCurrentPassword.Text != "Current Password")
                {
                    textCurrentPassword.UseSystemPasswordChar = true;
                }
                if (textNewPassword.Text != "New Password")
                {
                    textNewPassword.UseSystemPasswordChar = true;
                }
                if (textConfirmNewPassword.Text != "Confirm New Password")
                {
                    textConfirmNewPassword.UseSystemPasswordChar = true;
                }
            }
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            ThongTin tt = new ThongTin(this.role);
            DataTable dt = tt.getUserPass(this.id);
            string pass_db = dt.Rows[0]["pass"].ToString().Trim();
            string pass_curr = textCurrentPassword.Text.Trim();
            string pass_new = textNewPassword.Text.Trim();
            string pass_conf = textConfirmNewPassword.Text.Trim();
            if(pass_db != pass_curr)
            {
                MessageBox.Show("Mật khẩu không chính xác", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if(pass_new != pass_conf)
                {
                    MessageBox.Show("Mật khẩu Không trùng khớp", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if(tt.updatePass(this.id, pass_new))
                    {
                        MessageBox.Show("Thay đổi thành công", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        textCurrentPassword.Text = "";
                        textNewPassword.Text = "";
                        textConfirmNewPassword.Text = "";

                    }
                }
            }
        }
    }
}
