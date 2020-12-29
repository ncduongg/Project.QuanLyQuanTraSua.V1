using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.QuanLyQuanTraSua.v1.Model
{
    class foodEx : food
    {
        private string nameDS;

        public foodEx(string nameDS)
        {
            this.nameDS = nameDS;
        }
        public foodEx()
        {

        }
        public string NameDS { get => nameDS; set => nameDS = value; }
    }
}
