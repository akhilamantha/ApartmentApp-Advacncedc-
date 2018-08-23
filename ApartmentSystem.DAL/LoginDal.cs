using ApartmentSystem.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApartmentSystem.DAL
{
   public class LoginDal
    {

        SqlConnection apartmentDatabaseconnection = null; // database object created

        public int GetuserDetails(Login logInDetails)
        {
            try
            {
                string aptConnectionString = ConfigurationManager.ConnectionStrings["ApartmentSystem.Properties.Settings.ApartmentDBConnectionString"].ToString();

                apartmentDatabaseconnection = new SqlConnection(aptConnectionString); //object is passed with a connection string.hence connection is establshed
                apartmentDatabaseconnection.Open();

                SqlCommand cmd = new SqlCommand("select * from Login where UserName=@username and Password =@password", apartmentDatabaseconnection);
                cmd.Parameters.AddWithValue("@UserName", logInDetails.UserName);
                cmd.Parameters.AddWithValue("@Password", logInDetails.PassWord);
                SqlDataAdapter sda = new SqlDataAdapter(cmd); //here we are not using a nonquery type executable function so we are using a dataadapter.

                DataTable dt = new DataTable();
                sda.Fill(dt);
                return dt.Rows.Count; 
            }
            finally
            {
                apartmentDatabaseconnection.Close();
            }
        }
    }
}
