using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Project.QuanLyQuanTraSua.v1.Model;
using Project.QuanLyQuanTraSua.v1.Controller;

namespace Project.QuanLyQuanTraSua.v1
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
      
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
        private taikhoanController tkC = new taikhoanController();
        private void guna2Button2_Click(object sender, EventArgs e)
        {
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            if (tkC.Checklogin(username, password) == -3)
            {
                MessageBox.Show("Tài Khoản của bạn nhập sai", "Thông báo");
            } else if (tkC.Checklogin(username, password) == -2)
            {
                MessageBox.Show("Mật Khẩu của bạn nhập sai", "Thông báo");
            } else if (tkC.Checklogin(username, password) == -1)
            {
                MessageBox.Show("Bạn đã bị đuổi việc!!", "Thông báo");
            }
            else if (tkC.Checklogin(username, password) == 1)
            {
                MessageBox.Show("Đăng Nhập thành công!!", "Thông báo");
                this.Hide();
                frmIndex index = new frmIndex();
                index.Show();
            }
        }
    }
}
