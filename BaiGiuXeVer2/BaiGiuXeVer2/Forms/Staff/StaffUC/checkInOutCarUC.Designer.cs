﻿
namespace BaiGiuXeVer2.Forms.Staff.StaffUC
{
    partial class checkInOutCarUC
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnCapNhatVao = new Guna.UI.WinForms.GunaButton();
            this.dtmGui = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaShadowPanel2 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnCapNhatRa = new Guna.UI.WinForms.GunaButton();
            this.textPhat = new Guna.UI.WinForms.GunaTextBox();
            this.dtmRa = new Guna.UI.WinForms.GunaDateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.cboBienSoRa = new Guna.UI.WinForms.GunaComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.pic_bieienso = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaCirclePictureBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.gunaTextBox1 = new Guna.UI.WinForms.GunaTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textPhi = new Guna.UI.WinForms.GunaTextBox();
            this.gunaShadowPanel1.SuspendLayout();
            this.gunaShadowPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bieienso)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel1.Controls.Add(this.pic_bieienso);
            this.gunaShadowPanel1.Controls.Add(this.btnCapNhatVao);
            this.gunaShadowPanel1.Controls.Add(this.gunaTextBox1);
            this.gunaShadowPanel1.Controls.Add(this.dtmGui);
            this.gunaShadowPanel1.Controls.Add(this.label4);
            this.gunaShadowPanel1.Controls.Add(this.label2);
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Location = new System.Drawing.Point(69, 43);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 10;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel1.ShadowShift = 8;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(467, 718);
            this.gunaShadowPanel1.TabIndex = 2;
            // 
            // btnCapNhatVao
            // 
            this.btnCapNhatVao.AnimationHoverSpeed = 0.07F;
            this.btnCapNhatVao.AnimationSpeed = 0.03F;
            this.btnCapNhatVao.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhatVao.BaseColor = System.Drawing.Color.White;
            this.btnCapNhatVao.BorderColor = System.Drawing.Color.Black;
            this.btnCapNhatVao.BorderSize = 3;
            this.btnCapNhatVao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatVao.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapNhatVao.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapNhatVao.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnCapNhatVao.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatVao.Image = null;
            this.btnCapNhatVao.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapNhatVao.Location = new System.Drawing.Point(129, 616);
            this.btnCapNhatVao.Name = "btnCapNhatVao";
            this.btnCapNhatVao.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCapNhatVao.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapNhatVao.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapNhatVao.OnHoverImage = null;
            this.btnCapNhatVao.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapNhatVao.Radius = 8;
            this.btnCapNhatVao.Size = new System.Drawing.Size(201, 56);
            this.btnCapNhatVao.TabIndex = 115;
            this.btnCapNhatVao.Text = "Cập nhật";
            this.btnCapNhatVao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtmGui
            // 
            this.dtmGui.BackColor = System.Drawing.Color.Transparent;
            this.dtmGui.BaseColor = System.Drawing.Color.White;
            this.dtmGui.BorderColor = System.Drawing.Color.Silver;
            this.dtmGui.CustomFormat = "hh:MM dd/MM/yyyy";
            this.dtmGui.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtmGui.Enabled = false;
            this.dtmGui.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmGui.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmGui.ForeColor = System.Drawing.Color.Black;
            this.dtmGui.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmGui.Location = new System.Drawing.Point(219, 249);
            this.dtmGui.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.dtmGui.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmGui.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmGui.Name = "dtmGui";
            this.dtmGui.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtmGui.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmGui.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmGui.OnPressedColor = System.Drawing.Color.Black;
            this.dtmGui.Radius = 10;
            this.dtmGui.Size = new System.Drawing.Size(160, 30);
            this.dtmGui.TabIndex = 114;
            this.dtmGui.Text = "11:04 22/04/2021";
            this.dtmGui.Value = new System.DateTime(2021, 4, 22, 11, 37, 58, 266);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.Color.Gray;
            this.label4.Location = new System.Drawing.Point(82, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 28);
            this.label4.TabIndex = 108;
            this.label4.Text = "Thời gian gửi:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.Color.Gray;
            this.label2.Location = new System.Drawing.Point(82, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 106;
            this.label2.Text = "Biển số:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(162, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 71);
            this.label1.TabIndex = 0;
            this.label1.Text = "VÀO";
            // 
            // gunaShadowPanel2
            // 
            this.gunaShadowPanel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel2.BaseColor = System.Drawing.Color.White;
            this.gunaShadowPanel2.Controls.Add(this.gunaCirclePictureBox1);
            this.gunaShadowPanel2.Controls.Add(this.btnCapNhatRa);
            this.gunaShadowPanel2.Controls.Add(this.textPhi);
            this.gunaShadowPanel2.Controls.Add(this.textPhat);
            this.gunaShadowPanel2.Controls.Add(this.label8);
            this.gunaShadowPanel2.Controls.Add(this.dtmRa);
            this.gunaShadowPanel2.Controls.Add(this.label6);
            this.gunaShadowPanel2.Controls.Add(this.cboBienSoRa);
            this.gunaShadowPanel2.Controls.Add(this.label5);
            this.gunaShadowPanel2.Controls.Add(this.label3);
            this.gunaShadowPanel2.Controls.Add(this.label18);
            this.gunaShadowPanel2.Location = new System.Drawing.Point(542, 43);
            this.gunaShadowPanel2.Name = "gunaShadowPanel2";
            this.gunaShadowPanel2.Radius = 10;
            this.gunaShadowPanel2.ShadowColor = System.Drawing.Color.Black;
            this.gunaShadowPanel2.ShadowShift = 8;
            this.gunaShadowPanel2.Size = new System.Drawing.Size(467, 718);
            this.gunaShadowPanel2.TabIndex = 3;
            // 
            // btnCapNhatRa
            // 
            this.btnCapNhatRa.AnimationHoverSpeed = 0.07F;
            this.btnCapNhatRa.AnimationSpeed = 0.03F;
            this.btnCapNhatRa.BackColor = System.Drawing.Color.Transparent;
            this.btnCapNhatRa.BaseColor = System.Drawing.Color.White;
            this.btnCapNhatRa.BorderColor = System.Drawing.Color.Black;
            this.btnCapNhatRa.BorderSize = 3;
            this.btnCapNhatRa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCapNhatRa.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCapNhatRa.FocusedColor = System.Drawing.Color.Empty;
            this.btnCapNhatRa.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.btnCapNhatRa.ForeColor = System.Drawing.Color.Black;
            this.btnCapNhatRa.Image = null;
            this.btnCapNhatRa.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCapNhatRa.Location = new System.Drawing.Point(138, 616);
            this.btnCapNhatRa.Name = "btnCapNhatRa";
            this.btnCapNhatRa.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCapNhatRa.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCapNhatRa.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCapNhatRa.OnHoverImage = null;
            this.btnCapNhatRa.OnPressedColor = System.Drawing.Color.Black;
            this.btnCapNhatRa.Radius = 8;
            this.btnCapNhatRa.Size = new System.Drawing.Size(201, 56);
            this.btnCapNhatRa.TabIndex = 117;
            this.btnCapNhatRa.Text = "Cập nhật";
            this.btnCapNhatRa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textPhat
            // 
            this.textPhat.BackColor = System.Drawing.Color.Transparent;
            this.textPhat.BaseColor = System.Drawing.Color.White;
            this.textPhat.BorderColor = System.Drawing.Color.Silver;
            this.textPhat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPhat.Enabled = false;
            this.textPhat.FocusedBaseColor = System.Drawing.Color.White;
            this.textPhat.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textPhat.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textPhat.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.textPhat.ForeColor = System.Drawing.Color.Black;
            this.textPhat.Location = new System.Drawing.Point(179, 302);
            this.textPhat.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.textPhat.Name = "textPhat";
            this.textPhat.PasswordChar = '\0';
            this.textPhat.Radius = 10;
            this.textPhat.SelectedText = "";
            this.textPhat.Size = new System.Drawing.Size(232, 37);
            this.textPhat.TabIndex = 116;
            // 
            // dtmRa
            // 
            this.dtmRa.BackColor = System.Drawing.Color.Transparent;
            this.dtmRa.BaseColor = System.Drawing.Color.White;
            this.dtmRa.BorderColor = System.Drawing.Color.Silver;
            this.dtmRa.CustomFormat = "hh:MM dd/MM/yyyy";
            this.dtmRa.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtmRa.Enabled = false;
            this.dtmRa.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmRa.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtmRa.ForeColor = System.Drawing.Color.Black;
            this.dtmRa.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmRa.Location = new System.Drawing.Point(179, 249);
            this.dtmRa.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.dtmRa.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtmRa.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtmRa.Name = "dtmRa";
            this.dtmRa.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtmRa.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmRa.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtmRa.OnPressedColor = System.Drawing.Color.Black;
            this.dtmRa.Radius = 10;
            this.dtmRa.Size = new System.Drawing.Size(160, 30);
            this.dtmRa.TabIndex = 115;
            this.dtmRa.Text = "11:04 22/04/2021";
            this.dtmRa.Value = new System.DateTime(2021, 4, 22, 11, 37, 58, 266);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.Color.Gray;
            this.label6.Location = new System.Drawing.Point(42, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 28);
            this.label6.TabIndex = 113;
            this.label6.Text = "Phạt:";
            // 
            // cboBienSoRa
            // 
            this.cboBienSoRa.BackColor = System.Drawing.Color.Transparent;
            this.cboBienSoRa.BaseColor = System.Drawing.Color.White;
            this.cboBienSoRa.BorderColor = System.Drawing.Color.Silver;
            this.cboBienSoRa.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboBienSoRa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBienSoRa.FocusedColor = System.Drawing.Color.Empty;
            this.cboBienSoRa.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cboBienSoRa.ForeColor = System.Drawing.Color.Black;
            this.cboBienSoRa.FormattingEnabled = true;
            this.cboBienSoRa.Location = new System.Drawing.Point(179, 193);
            this.cboBienSoRa.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.cboBienSoRa.Name = "cboBienSoRa";
            this.cboBienSoRa.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cboBienSoRa.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cboBienSoRa.Radius = 10;
            this.cboBienSoRa.Size = new System.Drawing.Size(160, 30);
            this.cboBienSoRa.TabIndex = 113;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label5.ForeColor = System.Drawing.Color.Gray;
            this.label5.Location = new System.Drawing.Point(42, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 28);
            this.label5.TabIndex = 110;
            this.label5.Text = "Thời gian trả:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.ForeColor = System.Drawing.Color.Gray;
            this.label3.Location = new System.Drawing.Point(42, 190);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 28);
            this.label3.TabIndex = 108;
            this.label3.Text = "Biển số:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Leelawadee UI", 39.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label18.Location = new System.Drawing.Point(186, 93);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(96, 71);
            this.label18.TabIndex = 0;
            this.label18.Text = "RA";
            // 
            // pic_bieienso
            // 
            this.pic_bieienso.BaseColor = System.Drawing.Color.White;
            this.pic_bieienso.Image = global::BaiGiuXeVer2.Properties.Resources.default_DDLK_avatar;
            this.pic_bieienso.Location = new System.Drawing.Point(110, 329);
            this.pic_bieienso.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.pic_bieienso.Name = "pic_bieienso";
            this.pic_bieienso.Size = new System.Drawing.Size(250, 250);
            this.pic_bieienso.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_bieienso.TabIndex = 108;
            this.pic_bieienso.TabStop = false;
            this.pic_bieienso.UseTransfarantBackground = false;
            // 
            // gunaCirclePictureBox1
            // 
            this.gunaCirclePictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaCirclePictureBox1.Image = global::BaiGiuXeVer2.Properties.Resources.default_DDLK_avatar;
            this.gunaCirclePictureBox1.Location = new System.Drawing.Point(160, 418);
            this.gunaCirclePictureBox1.Margin = new System.Windows.Forms.Padding(3, 20, 3, 3);
            this.gunaCirclePictureBox1.Name = "gunaCirclePictureBox1";
            this.gunaCirclePictureBox1.Size = new System.Drawing.Size(166, 161);
            this.gunaCirclePictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaCirclePictureBox1.TabIndex = 108;
            this.gunaCirclePictureBox1.TabStop = false;
            this.gunaCirclePictureBox1.UseTransfarantBackground = false;
            // 
            // gunaTextBox1
            // 
            this.gunaTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTextBox1.BaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.BorderColor = System.Drawing.Color.Silver;
            this.gunaTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.gunaTextBox1.Enabled = false;
            this.gunaTextBox1.FocusedBaseColor = System.Drawing.Color.White;
            this.gunaTextBox1.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaTextBox1.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.gunaTextBox1.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.gunaTextBox1.ForeColor = System.Drawing.Color.Black;
            this.gunaTextBox1.Location = new System.Drawing.Point(219, 193);
            this.gunaTextBox1.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.gunaTextBox1.Name = "gunaTextBox1";
            this.gunaTextBox1.PasswordChar = '\0';
            this.gunaTextBox1.Radius = 10;
            this.gunaTextBox1.SelectedText = "";
            this.gunaTextBox1.Size = new System.Drawing.Size(160, 37);
            this.gunaTextBox1.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Leelawadee UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label8.ForeColor = System.Drawing.Color.Gray;
            this.label8.Location = new System.Drawing.Point(42, 362);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 28);
            this.label8.TabIndex = 113;
            this.label8.Text = "Phí:";
            // 
            // textPhi
            // 
            this.textPhi.BackColor = System.Drawing.Color.Transparent;
            this.textPhi.BaseColor = System.Drawing.Color.White;
            this.textPhi.BorderColor = System.Drawing.Color.Silver;
            this.textPhi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.textPhi.Enabled = false;
            this.textPhi.FocusedBaseColor = System.Drawing.Color.White;
            this.textPhi.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.textPhi.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.textPhi.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.textPhi.ForeColor = System.Drawing.Color.Black;
            this.textPhi.Location = new System.Drawing.Point(179, 358);
            this.textPhi.Margin = new System.Windows.Forms.Padding(3, 50, 3, 3);
            this.textPhi.Name = "textPhi";
            this.textPhi.PasswordChar = '\0';
            this.textPhi.Radius = 10;
            this.textPhi.SelectedText = "";
            this.textPhi.Size = new System.Drawing.Size(232, 37);
            this.textPhi.TabIndex = 116;
            // 
            // checkInOutCarUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gunaShadowPanel2);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Name = "checkInOutCarUC";
            this.Size = new System.Drawing.Size(1077, 800);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.gunaShadowPanel2.ResumeLayout(false);
            this.gunaShadowPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_bieienso)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gunaCirclePictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnCapNhatVao;
        private Guna.UI.WinForms.GunaDateTimePicker dtmGui;
        private Guna.UI.WinForms.GunaButton btnCapNhatRa;
        private Guna.UI.WinForms.GunaTextBox textPhat;
        private Guna.UI.WinForms.GunaDateTimePicker dtmRa;
        private Guna.UI.WinForms.GunaComboBox cboBienSoRa;
        private Guna.UI.WinForms.GunaCirclePictureBox pic_bieienso;
        private Guna.UI.WinForms.GunaTextBox gunaTextBox1;
        private Guna.UI.WinForms.GunaCirclePictureBox gunaCirclePictureBox1;
        private Guna.UI.WinForms.GunaTextBox textPhi;
        private System.Windows.Forms.Label label8;
    }
}
