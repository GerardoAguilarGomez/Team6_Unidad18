using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;

namespace UD18
{
    public class Database
    {
        public void Multifunction(string cadena)
        {
            try
            {
                SqlConnection conexion = new SqlConnection("Data Source=192.168.0.29;Initial Catalog=UD18;Persist Security Info=True;User ID=Eric;Password=Root_1234");
                conexion.Open();
                SqlCommand comando = new SqlCommand(cadena, conexion);
                comando.ExecuteNonQuery();
                Console.WriteLine("Operacion realizada");
                conexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
