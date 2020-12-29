using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.QuanLyQuanTraSua.v1.Model
{
    class food
    {
        private int idM;
        private int idDS;
        private string nameM;
        private double priceM;
        private int quantity;
        private string imgurlM;
        private string notesM;
        private int status;

        public food()
        {

        }

        public food(int idM, int idDS, string nameM, double priceM, int quantity, string imgurlM, string notesM, int status)
        {
            this.IdM = idM;
            this.IdDS = idDS;
            this.NameM = nameM;
            this.PriceM = priceM;
            this.Quantity = quantity;
            this.ImgurlM = imgurlM;
            this.NotesM = notesM;
            this.Status = status;
        }

        public int IdM { get => idM; set => idM = value; }
        public int IdDS { get => idDS; set => idDS = value; }
        public string NameM { get => nameM; set => nameM = value; }
        public double PriceM { get => priceM; set => priceM = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public string ImgurlM { get => imgurlM; set => imgurlM = value; }
        public string NotesM { get => notesM; set => notesM = value; }
        public int Status { get => status; set => status = value; }
    }
}
