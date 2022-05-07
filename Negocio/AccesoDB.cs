using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace negocio
{
    public class AccesoDB
    {
        private SqlConnection connection;
        private SqlCommand command;
        private SqlDataReader reader;

        public SqlDataReader Reader
        {
            get { return reader; }
        }

        public AccesoDB()
        {
            connection = new SqlConnection("server=.\\; database=CATALOGO_DB; integrated security=true");
            command = new SqlCommand();
        }
        public void setQuery(string query)
        {
            command.CommandType = System.Data.CommandType.Text;
            command.CommandText = query;
        }

        public void read()
        {
            command.Connection = connection;

            try
            {
                connection.Open();
                reader = command.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            
        }

        public void run()
        {
            command.Connection = connection;
            try
            {
                connection.Open();
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public void setParametros(string nombre, object value)
        {
            command.Parameters.AddWithValue(nombre, value);
        }

        public void closeConnection()
        {
            if(reader != null)
                reader.Close();
            connection.Close();
        }

    }
}
