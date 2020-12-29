using Project.QuanLyQuanTraSua.v1.Connections;
using Project.QuanLyQuanTraSua.v1.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.QuanLyQuanTraSua.v1.Controller
{
    class categoryController
    {
        public List<category> GetAllDanhSach()
        {
            DBConnection dB = new DBConnection();
            var conn = dB.sqlConnect();
            conn.Open();
            List<category> ctList = new List<category>();
            SqlCommand cmd = new SqlCommand("GetAllDanhSach", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader sqlDataReader = cmd.ExecuteReader();
            while (sqlDataReader.Read())
            {
                category ct = new category();
                ct.IdDS = Convert.ToInt32(sqlDataReader[0]);
                ct.NameDS = sqlDataReader[1].ToString();
                ctList.Add(ct);
            }
            conn.Close();
            return ctList;
        }
    }
}
