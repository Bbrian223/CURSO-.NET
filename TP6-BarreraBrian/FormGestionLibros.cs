namespace TP6_BarreraBrian
{
    public partial class FormGestionLibros : Form
    {
        public FormGestionLibros()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string nombre = txbNombre.Text;
            string autor = txbAutor.Text;
            string Genero = cmbGeneros.Text;
            int paginas = Int32.Parse(txbPaginas.Text);
            string origen = "nacional";
            var precio = float.Parse(txbPrecio.Text);


            if (chkImportado.Checked) origen = "importado";

            lbxLibros.Items.Add(nombre + " - " + autor + " - " + Genero + " - " + paginas + " - " + origen + " - $" + precio);

            txbNombre.Clear();
            txbAutor.Clear();
            cmbGeneros.Text = "";
            txbPaginas.Clear();
            chkImportado.Checked = false;
            txbPrecio.Clear();
        }
    }
}
