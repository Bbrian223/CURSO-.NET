using System.Diagnostics.CodeAnalysis;
using TP7_BarreraBrian.Entities;

namespace TP7_BarreraBrian
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIngreso_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txbId.Text);
            string nombre = txbNombre.Text;
            string dni = txbDni.Text;
            int edad = int.Parse(txbEdad.Text);
            bool casado = chkCasado.Checked;
            decimal salario = decimal.Parse(txbSalario.Text);

            Empleado empleado = new Empleado(id, nombre, dni, edad, casado, salario);

            listBoxEmpleados.Items.Add(empleado.ObtenerDatos());
        }
    }
}
