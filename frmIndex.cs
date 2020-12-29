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
    public partial class frmIndex : Form
    {
        public frmIndex()
        {
            InitializeComponent();
            UC_POS UC_POS = new UC_POS();
            addUserControl(UC_POS);

        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
        private void addUserControl(UserControl uc)
        {
            pn_Index.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.Size = pn_Index.Size;
            uc.BringToFront();
            pn_Index.Controls.Add(uc);
        }

        private void btn_POS_Click(object sender, EventArgs e)
        {
            UC_POS UC_POS = new UC_POS();
            addUserControl(UC_POS);
        }

        private void btn_Statistical_Click(object sender, EventArgs e)
        {

        }

        private void btn_User_Click(object sender, EventArgs e)
        {
            UC_User uC_User = new UC_User();
            addUserControl(uC_User);
        }

        private void btn_food_Click(object sender, EventArgs e)
        {
            UC_Food uC_Food = new UC_Food();
            addUserControl(uC_Food);
        }
    }
}
