﻿using Project.QuanLyQuanTraSua.v1.Controller;
using Project.QuanLyQuanTraSua.v1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.QuanLyQuanTraSua.v1
{
    public partial class frmDL_AddUserReal : Form
    {
        private taikhoanController tkC;
        public frmDL_AddUserReal()
        {
            InitializeComponent();
            tkC = new taikhoanController();
            cb_Admin.SelectedIndex = 0;
            cb_Status.SelectedIndex = 0;
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            taikhoan tk = new taikhoan();
            if (tkC.CheckUsername(txt_user.Text))
            {
                tk.UsernameNV = txt_user.Text;
                tk.PasswordNV = txt_password.Text;
                tk.NameNV = txt_name.Text;
                if (Regex.IsMatch(txt_phone.Text, @"^\d+$"))
                {
                    tk.PhoneNV = txt_phone.Text;
                    if (cb_Status.Text.Equals("Đang Làm"))
                    {
                        tk.StatusNV = 0;
                    }
                    else
                    {
                        tk.StatusNV = 1;
                    }
                    if (cb_Admin.Text.Equals("Admin"))
                    {
                        tk.Adminset = 0;
                    }
                    else
                    {
                        tk.Adminset = 1;
                    }
                    tkC.AddUser(tk);
                    MessageBox.Show("Thêm thành công", "Thông Báo");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("SĐT không đúng lắm", "Thông Báo");
                }
            }
            else
            {
                MessageBox.Show("UserName đã bị trùng, kiểm tra lại", "Thông Báo");
            }
        }

        private void frmDL_AddUserReal_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
    }
}
