using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.QuanLyQuanTraSua.v1.Model
{
    class taikhoan
    {
        private int idNV;
        private string usernameNV;
        private string passwordNV;
        private string nameNV;
        private string phoneNV;
        private int statusNV;
        private int adminset;
        public taikhoan()
        {

        }

        public taikhoan(int idNV, string usernameNV, string passwordNV, string nameNV, string phoneNV, int statusNV, int adminset)
        {
            this.idNV = idNV;
            this.usernameNV = usernameNV;
            this.passwordNV = passwordNV;
            this.nameNV = nameNV;
            this.phoneNV = phoneNV;
            this.statusNV = statusNV;
            this.adminset = adminset;
        }

        public int IdNV { get => idNV; set => idNV = value; }
        public string UsernameNV { get => usernameNV; set => usernameNV = value; }
        public string PasswordNV { get => passwordNV; set => passwordNV = value; }
        public string NameNV { get => nameNV; set => nameNV = value; }
        public string PhoneNV { get => phoneNV; set => phoneNV = value; }
        public int StatusNV { get => statusNV; set => statusNV = value; }
        public int Adminset { get => adminset; set => adminset = value; }
    }
}
