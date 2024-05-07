namespace TP7_BarreraBrian.Entities
{
    public class Empleado
    {
        private int _idEmpleado;
        private string _nombreCompleto;
        private string _dni;
        private int _edad;
        private bool _casado;
        private decimal _salario;

        public Empleado() { }
        public Empleado(int id, string nombreComp, string dni, int edad, bool casado, decimal salario) { 
            ID = id;
            NombreCompleto = nombreComp;
            Dni = dni;
            Edad = edad;
            Casado = casado;
            Salario = salario;
        }

        public int ID { get { return _idEmpleado;} set { _idEmpleado = value; } }

        public string NombreCompleto { get {  return _nombreCompleto; } set { _nombreCompleto = value; } }
        public string Dni { get { return _dni;} set { _dni = value; } }

        public int Edad { get { return _edad;} set { _edad = value; } }
        public bool Casado { get { return _casado; } set { _casado = value; } }

        public decimal Salario {  get { return _salario; } set { _salario = value; } }

        public string ObtenerDatos() {

            return _idEmpleado.ToString() + " , " + _nombreCompleto + " , " + _dni + " , " + _edad.ToString() + " , " + (_casado == true? "casado" : "soltero") + " , " + _salario.ToString();
        }

    }
}
