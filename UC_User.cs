using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.AccessControl;
using Project.QuanLyQuanTraSua.v1.Controller;

namespace Project.QuanLyQuanTraSua.v1
{
    public partial class UC_User : UserControl
    {
        public UC_User()
        {
            InitializeComponent();
        }
        private taikhoanController tkC = new taikhoanController();
        private DataTable dt = new DataTable();
        private void UC_User_Load(object sender, EventArgs e)
        {
            AddData();
           // dataGr_User.AutoGenerateColumns = false;

        }
        private void AddData()
        {
            dt.Clear();
            dt = tkC.ShowAllTK();
            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "Tài Khoản";
            dt.Columns[2].ColumnName = "Mật Khẩu";
            dt.Columns[3].ColumnName = "Tên";
            dt.Columns[4].ColumnName = "Số ĐT";
            dt.Columns[5].ColumnName = "Tình Trạng";
            dt.Columns[6].ColumnName = "ADMIN";
            dataGr_User.DataSource = dt;
            dataGr_User.Columns[2].Visible = false;
        }
        int Choce = -1;
        private void dataGr_User_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Choce = e.RowIndex;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (Choce!=-1)
            {
                int id = Convert.ToInt32(dt.Rows[Choce].ItemArray[0]);
                String user = dt.Rows[Choce].ItemArray[1].ToString();
                String pass = dt.Rows[Choce].ItemArray[2].ToString();
                String name = dt.Rows[Choce].ItemArray[3].ToString();
                String phone = dt.Rows[Choce].ItemArray[4].ToString();
                int statuss = Convert.ToInt32(dt.Rows[Choce].ItemArray[5]);
                int adminset = Convert.ToInt32(dt.Rows[Choce].ItemArray[6]);
                frmDL_AddUser frmDL_AddUser = new frmDL_AddUser(id, user, pass, name, phone, statuss, adminset);
                if (frmDL_AddUser.ShowDialog() == DialogResult.OK)
                {
                    AddData();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn Nhân Viên cần Edit","Lỗi");
            }
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmDL_AddUserReal frmDL_AddUserReal = new frmDL_AddUserReal();
            if (frmDL_AddUserReal.ShowDialog()==DialogResult.OK)
            {
                AddData();
            }
        }

        private void btn_Refest_Click(object sender, EventArgs e)
        {
            AddData();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Choce != -1)
            {
                int id = Convert.ToInt32(dt.Rows[Choce].ItemArray[0]);
                if (tkC.DeleteUser(id))
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                    AddData();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Thông Báo");
                }

            }
            else
            {
                MessageBox.Show("Hãy chọn Nhân Viên cần Delete", "Lỗi");
            }
        }

        private void dataGr_User_SelectionChanged(object sender, EventArgs e)
        {

        }
    }
}
