using System;
using System.Configuration; //by checking configuration property in the reference we made System.Configuration available in the headers.
using System.Data.SqlClient;

namespace ApartmentSystem.DAL
{
    public class FutureTenantDAL
    {
        private SqlConnection apartmentconnection; //creation of database connection, apartmentconnection is the object.
        SqlConnection connection = null;
        public int SaveTenantDetails(TenantDetails tenantDetails)
        {
            try
            {
                string aptConnectionString = ConfigurationManager.ConnectionStrings["ApartmentSystem.Properties.Settings.ApartmentDBConnectionString"].ToString();// app.config has the connection string so we need to call it and assign it to a string aptConnectionString by calling it by configuration manager.connection string,
                // name in the app.config is the connection string.
                apartmentconnection = new SqlConnection(aptConnectionString); //string aptconnectionstring has established connection to the database.
                apartmentconnection.Open(); //connection is open.

                SqlCommand cmd = new SqlCommand("insert into Tenant values(@tenantid, @fname, @lname,@ssn ,@aptype, @numofres, @petyn)", apartmentconnection);
                cmd.Parameters.AddWithValue("@tenantid", tenantDetails.Tenantid);  //all the tenantdetails are in TenantDetails.cs class so we call by class names followed by its fields.
                cmd.Parameters.AddWithValue("@fname", tenantDetails.FirstName);
                cmd.Parameters.AddWithValue("@lname", tenantDetails.LastName);
                cmd.Parameters.AddWithValue("@ssn", Convert.ToInt32(tenantDetails.SSN));
                cmd.Parameters.AddWithValue("@aptype", tenantDetails.ApartmentType);
                cmd.Parameters.AddWithValue("@numofres", tenantDetails.NumberOfFres);
                cmd.Parameters.AddWithValue("@petyn", tenantDetails.IsPetsAvailable);
                int results = cmd.ExecuteNonQuery(); //all the DML commands are executed by executenonquery (insert,update,delete,) we do not need a data adapter.
                return results;
            }
            catch (System.Exception exception)
            {
                throw exception;
            }
            finally
            {
                apartmentconnection.Close();
                // connection is closed for any futhur data loss.
            }

        }
    }
}
