using Project.QuanLyQuanTraSua.v1.Controller;
using Project.QuanLyQuanTraSua.v1.Model;
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

namespace Project.QuanLyQuanTraSua.v1
{
    public partial class frmDL_EditFood : Form
    {
        private categoryController categoryC;
        private foodController foodC;
        private string urlGoc;
        private string urlMoi = @".\img\";
        public frmDL_EditFood(int idM, string nameM,double priceM, int quantity, string imgurlM, string notesM, int status)
        {
            InitializeComponent();
            foodC = new foodController();
            categoryC = new categoryController();
            LoadCategory();
            cb_Category.SelectedIndex = 0;
            txt_id.Text = idM.ToString();
            txt_nameM.Text = nameM;
            txt_priceM.Text = priceM.ToString();
            nb_quantity.Value = quantity;
            txt_Notes.Text = notesM;
            images_box.Image = Image.FromFile(imgurlM);
            urlGoc = imgurlM;
            if (status == 0)
            {
                ckB_phanloai.Checked = true;
            }
            else
            {
                ckB_phanloai.Checked = false;
            }
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
        private int click = 0;
        private void btn_url_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            // urlMoi = @".\img\";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                click++;
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
            fd.IdM = Convert.ToInt32(txt_id.Text);
            fd.IdDS = Convert.ToInt32(ct.IdDS);
            fd.NameM = txt_nameM.Text;
            fd.PriceM = Convert.ToDouble(txt_priceM.Text);
            fd.Quantity = Convert.ToInt32(nb_quantity.Value);
            if (click != 0)
            {
                fd.ImgurlM = urlMoi;
                fd.NotesM = txt_Notes.Text;
                if (ckB_phanloai.Checked)
                {
                    fd.Status = 0;
                    foodC.EditFood(fd);
                    MessageBox.Show("Sửa thành công món " + fd.NameM, "Thông Báo");
                    imagesController.MoveFile(urlGoc, urlMoi);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    fd.Status = 1;
                    foodC.EditFood(fd);
                    MessageBox.Show("Sửa thành công món " + fd.NameM, "Thông Báo");
                    imagesController.MoveFile(urlGoc, urlMoi);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            else
            {
                fd.ImgurlM = urlGoc;
                fd.NotesM = txt_Notes.Text;
                if (ckB_phanloai.Checked)
                {
                    fd.Status = 0;
                    foodC.EditFood(fd);
                    MessageBox.Show("Sửa thành công món " + fd.NameM, "Thông Báo");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    fd.Status = 1;
                    foodC.EditFood(fd);
                    MessageBox.Show("Sửa thành công món " + fd.NameM, "Thông Báo");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
        }

        private void frmDL_EditFood_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
