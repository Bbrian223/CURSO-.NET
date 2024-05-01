namespace TP6_BarreraBrian
{
    partial class FormGestionLibros
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            tabIngreso = new TabPage();
            lbPrecio = new Label();
            txbPrecio = new TextBox();
            chkImportado = new CheckBox();
            lbImportado = new Label();
            txbPaginas = new TextBox();
            lbPaginas = new Label();
            lbGenero = new Label();
            cmbGeneros = new ComboBox();
            txbAutor = new TextBox();
            lbAutor = new Label();
            lbNombre = new Label();
            txbNombre = new TextBox();
            btnCancelar = new Button();
            btnIngresar = new Button();
            tabLista = new TabPage();
            lbxLibros = new ListBox();
            tabControl1.SuspendLayout();
            tabIngreso.SuspendLayout();
            tabLista.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabIngreso);
            tabControl1.Controls.Add(tabLista);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(763, 450);
            tabControl1.TabIndex = 0;
            tabControl1.Tag = "";
            // 
            // tabIngreso
            // 
            tabIngreso.Controls.Add(lbPrecio);
            tabIngreso.Controls.Add(txbPrecio);
            tabIngreso.Controls.Add(chkImportado);
            tabIngreso.Controls.Add(lbImportado);
            tabIngreso.Controls.Add(txbPaginas);
            tabIngreso.Controls.Add(lbPaginas);
            tabIngreso.Controls.Add(lbGenero);
            tabIngreso.Controls.Add(cmbGeneros);
            tabIngreso.Controls.Add(txbAutor);
            tabIngreso.Controls.Add(lbAutor);
            tabIngreso.Controls.Add(lbNombre);
            tabIngreso.Controls.Add(txbNombre);
            tabIngreso.Controls.Add(btnCancelar);
            tabIngreso.Controls.Add(btnIngresar);
            tabIngreso.Location = new Point(4, 24);
            tabIngreso.Name = "tabIngreso";
            tabIngreso.Padding = new Padding(3);
            tabIngreso.Size = new Size(755, 422);
            tabIngreso.TabIndex = 0;
            tabIngreso.Text = "Ingreso";
            tabIngreso.UseVisualStyleBackColor = true;
            // 
            // lbPrecio
            // 
            lbPrecio.AutoSize = true;
            lbPrecio.Location = new Point(249, 248);
            lbPrecio.Name = "lbPrecio";
            lbPrecio.Size = new Size(40, 15);
            lbPrecio.TabIndex = 13;
            lbPrecio.Text = "Precio";
            // 
            // txbPrecio
            // 
            txbPrecio.Location = new Point(306, 245);
            txbPrecio.Name = "txbPrecio";
            txbPrecio.Size = new Size(51, 23);
            txbPrecio.TabIndex = 12;
            // 
            // chkImportado
            // 
            chkImportado.AutoSize = true;
            chkImportado.Location = new Point(308, 213);
            chkImportado.Name = "chkImportado";
            chkImportado.Size = new Size(35, 19);
            chkImportado.TabIndex = 11;
            chkImportado.Text = "SI";
            chkImportado.UseVisualStyleBackColor = true;
            // 
            // lbImportado
            // 
            lbImportado.AutoSize = true;
            lbImportado.Location = new Point(226, 214);
            lbImportado.Name = "lbImportado";
            lbImportado.Size = new Size(63, 15);
            lbImportado.TabIndex = 10;
            lbImportado.Text = "Importado";
            // 
            // txbPaginas
            // 
            txbPaginas.Location = new Point(308, 175);
            txbPaginas.Name = "txbPaginas";
            txbPaginas.Size = new Size(49, 23);
            txbPaginas.TabIndex = 9;
            // 
            // lbPaginas
            // 
            lbPaginas.AutoSize = true;
            lbPaginas.Location = new Point(241, 178);
            lbPaginas.Name = "lbPaginas";
            lbPaginas.Size = new Size(48, 15);
            lbPaginas.TabIndex = 8;
            lbPaginas.Text = "Paginas";
            // 
            // lbGenero
            // 
            lbGenero.AutoSize = true;
            lbGenero.Location = new Point(244, 135);
            lbGenero.Name = "lbGenero";
            lbGenero.Size = new Size(45, 15);
            lbGenero.TabIndex = 7;
            lbGenero.Text = "Genero";
            // 
            // cmbGeneros
            // 
            cmbGeneros.FormattingEnabled = true;
            cmbGeneros.Items.AddRange(new object[] { "Aventura", "Romance", "Ciencia Ficcion", "Drama", "Comedia" });
            cmbGeneros.Location = new Point(308, 132);
            cmbGeneros.Name = "cmbGeneros";
            cmbGeneros.Size = new Size(121, 23);
            cmbGeneros.TabIndex = 6;
            // 
            // txbAutor
            // 
            txbAutor.Location = new Point(308, 94);
            txbAutor.Name = "txbAutor";
            txbAutor.Size = new Size(121, 23);
            txbAutor.TabIndex = 5;
            // 
            // lbAutor
            // 
            lbAutor.AutoSize = true;
            lbAutor.Location = new Point(252, 97);
            lbAutor.Name = "lbAutor";
            lbAutor.Size = new Size(37, 15);
            lbAutor.TabIndex = 4;
            lbAutor.Text = "Autor";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(238, 59);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 3;
            lbNombre.Text = "Nombre";
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(308, 56);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(121, 23);
            txbNombre.TabIndex = 2;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(250, 323);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 1;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(431, 323);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(75, 23);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // tabLista
            // 
            tabLista.Controls.Add(lbxLibros);
            tabLista.Location = new Point(4, 24);
            tabLista.Name = "tabLista";
            tabLista.Padding = new Padding(3);
            tabLista.Size = new Size(755, 422);
            tabLista.TabIndex = 1;
            tabLista.Text = "Lista";
            tabLista.UseVisualStyleBackColor = true;
            // 
            // lbxLibros
            // 
            lbxLibros.FormattingEnabled = true;
            lbxLibros.ItemHeight = 15;
            lbxLibros.Location = new Point(124, 45);
            lbxLibros.Name = "lbxLibros";
            lbxLibros.Size = new Size(471, 304);
            lbxLibros.TabIndex = 0;
            // 
            // FormGestionLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 450);
            Controls.Add(tabControl1);
            Name = "FormGestionLibros";
            Text = "Gestion de Libros";
            tabControl1.ResumeLayout(false);
            tabIngreso.ResumeLayout(false);
            tabIngreso.PerformLayout();
            tabLista.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabIngreso;
        private TabPage tabLista;
        private Button btnCancelar;
        private Button btnIngresar;
        private TextBox txbAutor;
        private Label lbAutor;
        private Label lbNombre;
        private TextBox txbNombre;
        private Label lbImportado;
        private TextBox txbPaginas;
        private Label lbPaginas;
        private Label lbGenero;
        private ComboBox cmbGeneros;
        private CheckBox chkImportado;
        private ListBox lbxLibros;
        private Label lbPrecio;
        private TextBox txbPrecio;
    }
}
