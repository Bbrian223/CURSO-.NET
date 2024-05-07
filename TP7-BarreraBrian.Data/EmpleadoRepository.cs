using TP7_BarreraBrian.Entities;
using Microsoft.Data.SqlClient;

namespace TP7_BarreraBrian.Data
{
    public class EmpleadoRepository
    {
        EmpleadoRepository() { }

        public List<Empleado> ObtenerDatos() { 
            
            var conexion = new SqlConnection();

            return  new List<Empleado>();
        }
    
    }
}
