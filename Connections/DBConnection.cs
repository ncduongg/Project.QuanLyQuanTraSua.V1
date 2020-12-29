using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.QuanLyQuanTraSua.v1.Connections
{
    class DBConnection
    {
        private string StringSQL = @"Data Source=NCDUONG\NCDUONG;Initial Catalog=QLQuanTS;Persist Security Info=True;User ID=sa;Password=ncduong";

        public SqlConnection sqlConnect()
        {
            SqlConnection conn = new SqlConnection(StringSQL);
            return conn;
        }
    }
}
