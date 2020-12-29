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
using Project.QuanLyQuanTraSua.v1.Model;

namespace Project.QuanLyQuanTraSua.v1
{
    public partial class UC_POS : UserControl
    {
        private foodController foodC;
        private categoryController categoryC;
        private DataTable dataTable;
        public UC_POS()
        {
            InitializeComponent();
            foodC = new foodController();
            categoryC = new categoryController();
            LoadCategory();
            cb_Category.SelectedIndex = 0;
        }

        private void UC_POS_Load(object sender, EventArgs e)
        {
            
        }
        private void LoadCategory()
        {
            foreach (category item in categoryC.GetAllDanhSach())
            {
                cb_Category.Items.Add(item);
            }
        }

        private void cb_Category_SelectedIndexChanged(object sender, EventArgs e)
        {
            int id =  ((category)cb_Category.SelectedItem).IdDS;
            dataTable = new DataTable();
            dataTable = foodC.LoadFoodIndex(id);
            dataTable.Columns[0].ColumnName = "ID";
            dataTable.Columns[1].ColumnName = "Tên";
            dataTable.Columns[2].ColumnName = "ID Danh Mục";
            dataTable.Columns[3].ColumnName = "Tên Danh Mục";
            dataTable.Columns[4].ColumnName = "Giá";
            dataTable.Columns[5].ColumnName = "Số Lượng";
            dataTable.Columns[6].ColumnName = "uRL";
            dataTable.Columns[7].ColumnName = "Reviews";
            dataTable.Columns[8].ColumnName = "Tình trạng";
            dataGr_Food.DataSource = dataTable;
            dataGr_Food.Columns[2].Visible = false;
            dataGr_Food.Columns[6].Visible = false;
        }
        private int Choce = -1;
        private void dataGr_Food_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Choce = e.RowIndex;
            pB_images.Image = Image.FromFile(dataTable.Rows[Choce].ItemArray[6].ToString());
        }
    }
}
