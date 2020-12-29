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
    class taikhoanController
    {
        private string StringSQL = @"Data Source=NCDUONG\NCDUONG;Initial Catalog=QLQuanTS;Integrated Security=True";
        private string TruyVan = "SELECT * FROM taikhoan";
        DataTable dt;
        public int Checklogin(string username,string password)
        {
            SqlConnection conn = new SqlConnection(StringSQL);
            conn.Open();
            SqlCommand cmd = new SqlCommand(TruyVan,conn);
            SqlDataReader dtR = cmd.ExecuteReader();
            while (dtR.Read())
            {
                if (dtR[1].ToString().Equals(username))
                {
                    if (dtR[2].ToString().Equals(password))
                    {
                        if(Convert.ToInt32(dtR[5]) == 0)
                        {
                            return 1;
                        }
                        else
                        {
                            return -1;
                        }
                    }
                    else
                    {
                        return -2;
                    }
                } else
                {
                    return -3;
                }
            }
            return 0;
        }
        public List<taikhoan> ShowAllTaiKhoan()
        {
            List<taikhoan> tkList = new List<taikhoan>();
            SqlConnection conn = new SqlConnection(StringSQL);
            conn.Open();
            SqlCommand cmd = new SqlCommand(TruyVan, conn);
            SqlDataReader dtR = cmd.ExecuteReader();
            while (dtR.Read())
            {
                taikhoan tk = new taikhoan();
                tk.IdNV = Convert.ToInt32(dtR[0]);
                tk.UsernameNV = dtR[1].ToString();
                tk.PasswordNV = dtR[2].ToString();
                tk.NameNV = dtR[3].ToString();
                tk.PhoneNV = dtR[4].ToString();
                tk.StatusNV = Convert.ToInt32(dtR[5]);
                tk.Adminset = Convert.ToInt32(dtR[6]);
                tkList.Add(tk);
            }
            return tkList;
        }
        public DataTable ShowAllTK()
        {
            SqlConnection conn = new SqlConnection(StringSQL);
            conn.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(TruyVan, conn);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            conn.Close();
            return dataTable;

        }
        public bool UpdateTK(taikhoan tk)
        {
            SqlConnection conn = new SqlConnection(StringSQL);
            conn.Open();
            SqlCommand cmd = new SqlCommand("UpdateTK",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@idNV", tk.IdNV);
            cmd.Parameters.Add("@usernameN", tk.UsernameNV);
            cmd.Parameters.Add("@passwordN", tk.PasswordNV);
            cmd.Parameters.Add("@nameN", tk.NameNV);
            cmd.Parameters.Add("@phoneN", tk.PhoneNV);
            cmd.Parameters.Add("@statusN", tk.StatusNV);
            cmd.Parameters.Add("@adminset", tk.Adminset);
            cmd.ExecuteNonQuery();
            conn.Close();
            return true;  
        }
        public bool CheckUsername(string username)
        {
            SqlConnection conn = new SqlConnection(StringSQL);
            conn.Open();
            SqlCommand cmd = new SqlCommand("CheckUsername",conn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataReader dataReader =  cmd.ExecuteReader();
            while (dataReader.Read())
            {
                if (dataReader[0].ToString().ToLower().Equals(username.ToLower()))
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            return false;
        }
        public void AddUser(taikhoan tk)
        {
            SqlConnection conn = new SqlConnection(StringSQL);
            conn.Open();
            SqlCommand cmd = new SqlCommand("AddUser", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@usernameN", tk.UsernameNV);
            cmd.Parameters.Add("@passwordN", tk.PasswordNV);
            cmd.Parameters.Add("@nameN", tk.NameNV);
            cmd.Parameters.Add("@phoneN", tk.PhoneNV);
            cmd.Parameters.Add("@statusN", tk.StatusNV);
            cmd.Parameters.Add("@adminset", tk.Adminset);
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public bool DeleteUser(int idNV)
        {
            try
            {
                SqlConnection conn = new SqlConnection(StringSQL);
                conn.Open();
                SqlCommand cmd = new SqlCommand("DeleteUser", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@idNV",idNV);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

    }
}
