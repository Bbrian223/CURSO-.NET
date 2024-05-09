using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace TP7_BarreraBrian.Entities.Data
{
    public class EmpleadoRepository
    {

        private readonly string CONNECTIONSTRING = "Data Source=.;Initial Catalog=EMPLEADOS_DB;Integrated Security =true";

        SqlConnection connection = new SqlConnection();


        public EmpleadoRepository() { }

        public List<Empleado> ObtenerDatos()
        {
            List<Empleado> lista = new List<Empleado>();
            
            var cmd = new SqlCommand();
            
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT * FROM dbo.EMPLEADOS_DB";
            
            

            

            using (var conn = new SqlConnection(CONNECTIONSTRING))
            {
                cmd.Connection = conn;
                
                conn.Open();

                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    Empleado empleado = new Empleado();

                    empleado.ID = reader.GetInt32(0);
                    empleado.NombreCompleto = reader.GetString(1);
                    empleado.Dni = reader.GetString(2);
                    empleado.Edad = reader.GetInt32(3);
                    empleado.Casado = reader.GetBoolean(4);
                    empleado.Salario = reader.GetDecimal(5);

                    lista.Add(empleado);

                }

                conn.Close();

            }
                

            return lista;
        }

    }
}
