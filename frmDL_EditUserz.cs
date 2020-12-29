using Project.QuanLyQuanTraSua.v1.Controller;
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
    public partial class frmDL_AddUser : Form
    {
        private taikhoanController tkC;
        public frmDL_AddUser(int idNV, string usernameNV, string passwordNV, string nameNV, string phoneNV, int statusNV, int adminset)
        {
            InitializeComponent();
            tkC = new taikhoanController();
            txt_id.Text = idNV.ToString();
            txt_user.Text = usernameNV.ToString();
            txt_password.Text = passwordNV.ToString();
            txt_name.Text = nameNV.ToString();
            txt_phone.Text = phoneNV.ToString();            
        }


        private void frmDL_AddUser_Load(object sender, EventArgs e)
        {


        }
        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            taikhoan tk = new taikhoan();
            tk.IdNV = Convert.ToInt32(txt_id.Text);
            tk.UsernameNV = txt_user.Text;
            if (tkC.CheckUsername(txt_user.Text))
            {
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
                    if (tkC.UpdateTK(tk))
                    {
                        MessageBox.Show("Bạn đã sửa thành công!", "Thông Báo");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Lỗi, vui lòng kiểm tra lại", "Thông Báo");
                    }
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
    }
}
