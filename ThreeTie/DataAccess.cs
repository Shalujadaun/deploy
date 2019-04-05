using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI.WebControls;

namespace ThreeTie
{
    public class DataAccess
    {
        public string message = string.Empty;

        SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["dbconnect"].ToString());

        public String AddUserInformation(BusinessObject ObjBO)
        {
            try
            {
                String strpassword = Encryptdata(ObjBO.password);
                SqlCommand cmd = new SqlCommand("Sp_UsersInsertRecord", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", SqlDbType.VarChar).Value = ObjBO.userID;
                cmd.Parameters.AddWithValue("@Password", SqlDbType.VarChar).Value = strpassword;
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                con.Open();
                cmd.ExecuteNonQuery();

                message = (string)cmd.Parameters["@Status"].Value;
                cmd.Dispose();
                return message;
            }
            catch
            {
                throw;
            }
        }

        public int LoginUserInformation(BusinessObject ObjBO)
        {
            try
            {

                String strpassword = Decryptdata(ObjBO.password);
                SqlCommand cmd = new SqlCommand("Sp_LoginUser", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@UserID", SqlDbType.NVarChar).Value = ObjBO.userID;
                cmd.Parameters.AddWithValue("@Password", SqlDbType.NVarChar).Value = strpassword;
                cmd.Parameters.Add("@Status", SqlDbType.NVarChar, 500).Direction = ParameterDirection.Output;
                con.Open();

                cmd.ExecuteNonQuery();

                int result;
                result = Convert.ToInt32(cmd.Parameters["@Status"].Value);
                cmd.Dispose();
                return result;
            }
           catch
            {
                throw;
            }
        }
        private string Encryptdata(string password)
        {
            string strmsg = string.Empty;
            byte[] encode = new byte[password.Length];
            encode = Encoding.UTF8.GetBytes(password);
            strmsg = Convert.ToBase64String(encode);
            return strmsg;
        }

        private string Decryptdata(string password)
        {
            try
            {
                string strmsg = string.Empty;
                byte[] encode = new byte[password.Length];
                encode = Encoding.UTF8.GetBytes(password);
                strmsg = Convert.ToBase64String(encode);
                return strmsg;
            }
            catch (System.Exception ex)
            {
                throw ex;
            }
        }
       
    }
}