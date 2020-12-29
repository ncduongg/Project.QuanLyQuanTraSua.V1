using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Project.QuanLyQuanTraSua.v1.Controller
{
    class imagesController
    {
        public void MoveFile(string urlGoc, string urlDen)
        {
            File.Copy(urlGoc,urlDen);
        }
    }
}
