using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.QuanLyQuanTraSua.v1.Controller;

namespace Project.QuanLyQuanTraSua.v1
{
    public partial class UC_Food : UserControl
    {
        private foodController foodC;
        private DataTable dt;
        public UC_Food()
        {
            InitializeComponent();
            foodC = new foodController();
            dt = new DataTable();
        }
        private void LoadFood()
        {
            dt.Clear();
            dt = foodC.LoadFood();
            dt.Columns[0].ColumnName = "ID";
            dt.Columns[1].ColumnName = "Tên Món";
            dt.Columns[2].ColumnName = "ID DM";
            dt.Columns[3].ColumnName = "Danh Mục";
            dt.Columns[4].ColumnName = "Giá";
            dt.Columns[5].ColumnName = "Số Lượng";
            dt.Columns[6].ColumnName = "URL";
            dt.Columns[7].ColumnName = "Review";
            dt.Columns[8].ColumnName = "Phân Loại";
            dataGr_Food.DataSource = dt;
            dataGr_Food.Columns[2].Visible = false;
            dataGr_Food.Columns[6].Visible = false;
            dataGr_Food.Columns[8].Visible = false;
        }

        private void UC_Food_Load(object sender, EventArgs e)
        {
            LoadFood();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frmDL_AddFood frmDL_AddFood = new frmDL_AddFood();
            if(frmDL_AddFood.ShowDialog() == DialogResult.OK)
            {
                LoadFood();
            }
        }
        private int Choce = -1;
        private void dataGr_Food_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Choce = e.RowIndex;
        }

        private void btn_Edit_Click(object sender, EventArgs e)
        {
            if (Choce!=-1)
            {
                int id = Convert.ToInt32(dt.Rows[Choce].ItemArray[0]);
                String nameM = dt.Rows[Choce].ItemArray[1].ToString();
                double priceM = Convert.ToDouble(dt.Rows[Choce].ItemArray[4]);
                int quantity = Convert.ToInt32(dt.Rows[Choce].ItemArray[5]);
                String imgurlM = dt.Rows[Choce].ItemArray[6].ToString();
                String notesM = dt.Rows[Choce].ItemArray[7].ToString();
                int status = Convert.ToInt32(dt.Rows[Choce].ItemArray[8]);
                frmDL_EditFood frmDL_EditFood = new frmDL_EditFood(id, nameM, priceM, quantity, imgurlM, notesM, status);
                if (frmDL_EditFood.ShowDialog() == DialogResult.OK)
                {
                    LoadFood();
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn Món cần Edit", "Lỗi");
            }
        }

        private void btn_Refest_Click(object sender, EventArgs e)
        {
            LoadFood();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (Choce != -1)
            {
                int id = Convert.ToInt32(dt.Rows[Choce].ItemArray[0]);
                if (foodC.DeleteFood(id))
                {
                    MessageBox.Show("Xóa thành công", "Thông Báo");
                    LoadFood();
                }
                else
                {
                    MessageBox.Show("Xóa thất bại", "Lỗi");
                }
            }
            else
            {
                MessageBox.Show("Hãy chọn Món cần Delete", "Lỗi");
            }
        }
    }
}
