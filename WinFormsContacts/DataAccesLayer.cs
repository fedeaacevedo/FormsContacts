using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsContacts
{
    public class DataAccesLayer
    {
        //conexion a la base de datos
        private SqlConnection conn = new SqlConnection("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=WinFormsContacts;Data Source=FEDERICO\\SQLEXPRESS");
        public void InsertContact(Contact contact)
        {
            //siempre que se hace un acceso a la db se utiliza try catch
            try
            {
                conn.Open();
                string query = @"
    
                            INSERT INTO Contacts( FirstName, LastName, Phone, Email)
                            VALUES (@FirstName, @LastName, @Phone, @Email) ";

                SqlParameter firstName = new SqlParameter();
                firstName.ParameterName = "@FirstName";
                firstName.Value = contact.FirstName;
                firstName.DbType = System.Data.DbType.String;

                SqlParameter lastName = new SqlParameter("@LastName", contact.LastName);
                SqlParameter phone = new SqlParameter("@Phone", contact.Phone);
                SqlParameter email = new SqlParameter("@Email", contact.Email);

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.Add(firstName);
                command.Parameters.Add(lastName);
                command.Parameters.Add(phone);
                command.Parameters.Add(email);

                command.ExecuteNonQuery();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                //cerramos la conexion con o sin errores
                conn.Close();
            }
        }
    }
}
