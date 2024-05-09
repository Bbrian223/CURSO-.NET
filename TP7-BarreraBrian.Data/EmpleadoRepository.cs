using TP7_BarreraBrian.Entities;
using Microsoft.Data.SqlClient;
using System.Windows.Forms;

namespace TP7_BarreraBrian.Data
{
    public class EmpleadoRepository
    {

        private readonly string CONNECTIONSTRING = "Data Source=(local);Initial Catalog=master;Integrated Security=true";

        SqlConnection connection = new SqlConnection();


        EmpleadoRepository() { }

        public List<Empleado> ObtenerDatos() {

                return new List<Empleado>();
        }

        public SqlConnection establecerConexion() {
            try
            {
                connection.ConnectionString = CONNECTIONSTRING;
                connection.Open();
                MessageBox.Show("Se conectó correctamente a la Base de Datos");

            }
            catch (SqlException e)
            {

                MessageBox.Show("No se logró conectar a la Base de Datos" + e.ToString());
            }

            return connection;
        }



    
    }
}
