using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace acceso
{
    public class Acces
    {
        private SqlConnection _conecction = new SqlConnection(@"Data Source=.\SQLEXPRESS02;Initial Catalog=LoginLogout;Integrated Security=True");

        private SqlCommand? _command;

        public bool Escribir(string query)
        {
            _conecction.Open();
            _command = new SqlCommand();
            _command.CommandType = CommandType.Text;
            _command.Connection = _conecction;
            _command.CommandText = query;
            try
            {
                int respuesta = _command.ExecuteNonQuery();
                return true;
            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }
            finally
            {
                _conecction.Close();
            }
        }
    }
}
