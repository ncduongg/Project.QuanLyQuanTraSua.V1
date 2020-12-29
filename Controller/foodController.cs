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
    class foodController
    {
        public void AddFood(food fd)
        {
            DBConnection dB = new DBConnection();
            var conn = dB.sqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("AddFood", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@idDS",fd.IdDS);
            cmd.Parameters.Add("@nameM", fd.NameM);
            cmd.Parameters.Add("@priceM",fd.PriceM);
            cmd.Parameters.Add("@quantity",fd.Quantity);
            cmd.Parameters.Add("@imgurlM",fd.ImgurlM);
            cmd.Parameters.Add("@notesM",fd.NotesM);
            cmd.Parameters.Add("@status",fd.Status);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void EditFood(food fd)
        {
            DBConnection dB = new DBConnection();
            var conn = dB.sqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("EditFood", conn);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.Add("@idM", fd.IdM);
            cmd.Parameters.Add("@idDS", fd.IdDS);
            cmd.Parameters.Add("@nameM", fd.NameM);
            cmd.Parameters.Add("@priceM", fd.PriceM);
            cmd.Parameters.Add("@quantity", fd.Quantity);
            cmd.Parameters.Add("@imgurlM", fd.ImgurlM);
            cmd.Parameters.Add("@notesM", fd.NotesM);
            cmd.Parameters.Add("@status", fd.Status);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public bool CheckFood(string nameM)
        {
            DBConnection dB = new DBConnection();
            var conn = dB.sqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("CheckFood", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader[0].ToString().ToLower().Equals(nameM.ToLower()))
                {
                    return false;
                }
            }
            return true;
        }
        public DataTable LoadFood()
        {
            DataTable dataTable = new DataTable();
            DBConnection dB = new DBConnection();
            var conn = dB.sqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("LoadFood", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public bool DeleteFood(int idM)
        {
            try
            {
                DBConnection dB = new DBConnection();
                var conn = dB.sqlConnect();
                conn.Open();
                SqlCommand cmd = new SqlCommand("DeleteFood", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idM",idM);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        public DataTable LoadFoodIndex(int idDS)
        {
            DBConnection dB = new DBConnection();
            var conn = dB.sqlConnect();
            conn.Open();
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand("LoadFoodIndex", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idDS",idDS);
            SqlDataAdapter dataAdapter = new SqlDataAdapter();
            dataAdapter.SelectCommand = cmd;
            dataAdapter.Fill(dataTable);
            return dataTable;
        }
        public List<category> LoadToping()
        {
            List<category> caList = new List<category>();
            DBConnection dB = new DBConnection();
            var conn = dB.sqlConnect();
            conn.Open();
            SqlCommand cmd = new SqlCommand("LoadFoodIndex", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            return caList;
        }
    }
}
