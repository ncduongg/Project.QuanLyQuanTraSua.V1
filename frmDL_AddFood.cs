using Project.QuanLyQuanTraSua.v1.Controller;
using Project.QuanLyQuanTraSua.v1.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project.QuanLyQuanTraSua.v1
{
    public partial class frmDL_AddFood : Form
    {
        private categoryController categoryC;
        private foodController foodC;
        OpenFileDialog fileDialog;
        public frmDL_AddFood()
        {
            InitializeComponent();
            foodC = new foodController();
            categoryC = new categoryController();
            fileDialog = new OpenFileDialog();
            LoadCategory();
            cb_Category.SelectedIndex = 0;
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
            btn_Save.DialogResult = DialogResult.OK;
        }
        private string urlGoc;
        private string urlMoi = @".\img\";
        
        private void btn_url_Click(object sender, EventArgs e)
        {
            urlMoi = @".\img\";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                Random rd = new Random();
                int RD = rd.Next(10000);
                urlGoc = fileDialog.FileName;
                urlMoi = urlMoi + RD + fileDialog.SafeFileName;
                images_box.Image = Image.FromFile(urlGoc);
            }
        }
        private void LoadCategory()
        {
            foreach (category item in categoryC.GetAllDanhSach())
            {
                cb_Category.Items.Add(item);
            }
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            imagesController imagesController = new imagesController();
            food fd = new food();
            category ct = new category();
            ct = (category)cb_Category.SelectedItem;
            fd.IdDS = Convert.ToInt32(ct.IdDS);
            if (foodC.CheckFood(txt_nameM.Text))
            {
                fd.NameM = txt_nameM.Text;
                fd.PriceM = Convert.ToDouble(txt_priceM.Text);
                fd.Quantity = Convert.ToInt32(nb_quantity.Value);
                fd.ImgurlM = urlMoi;
                fd.NotesM = txt_Notes.Text;
                if (ckB_phanloai.Checked)
                {
                    fd.Status = 0;
                    foodC.AddFood(fd);
                    MessageBox.Show("Thêm thành công món " + fd.NameM, "Thông Báo");
                    imagesController.MoveFile(urlGoc, urlMoi);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    fd.Status = 1;
                    foodC.AddFood(fd);
                    MessageBox.Show("Thêm thành công món " + fd.NameM, "Thông Báo");
                    imagesController.MoveFile(urlGoc, urlMoi);
                    this.Close();
                    this.DialogResult = DialogResult.OK;
                }
                
            }
            else
            {
                MessageBox.Show("Đã tồn tại món " + txt_nameM.Text, "Thông Báo");
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void c(object sender, EventArgs e)
        {

        }
    }
}
