using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Project.QuanLyQuanTraSua.v1.Model
{
    class category
    {
        private int idDS;
        private string nameDS;

        public int IdDS { get => idDS; set => idDS = value; }
        public string NameDS { get => nameDS; set => nameDS = value; }

        public category(int idDS, string nameDS)
        {
            this.IdDS = idDS;
            this.NameDS = nameDS;
        }
        public category()
        {

        }
        public override string ToString()
        {
            return NameDS;
        }
    }
}
