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
    public partial class frmDL_AddBill : Form
    {
        public frmDL_AddBill(int idM,string nameM,double price)
        {
            InitializeComponent();
        }

        private void frmDL_AddBill_Load(object sender, EventArgs e)
        {
            Guna.UI.Lib.GraphicsHelper.ShadowForm(this);
        }
        private void LoadToping()
        {

        }
    }
}
