namespace TP7_BarreraBrian
{
    partial class Form1
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
            btnIngreso = new Button();
            lbCasado = new Label();
            lbSalario = new Label();
            lbEdad = new Label();
            lbDni = new Label();
            lbNombre = new Label();
            lbID = new Label();
            txbSalario = new TextBox();
            txbEdad = new TextBox();
            txbDni = new TextBox();
            txbNombre = new TextBox();
            txbId = new TextBox();
            chkCasado = new CheckBox();
            listBoxEmpleados = new ListBox();
            SuspendLayout();
            // 
            // btnIngreso
            // 
            btnIngreso.Location = new Point(98, 325);
            btnIngreso.Name = "btnIngreso";
            btnIngreso.Size = new Size(183, 31);
            btnIngreso.TabIndex = 25;
            btnIngreso.Text = "Ingresar Empleado";
            btnIngreso.UseVisualStyleBackColor = true;
            btnIngreso.Click += btnIngreso_Click;
            // 
            // lbCasado
            // 
            lbCasado.AutoSize = true;
            lbCasado.Location = new Point(59, 224);
            lbCasado.Name = "lbCasado";
            lbCasado.Size = new Size(46, 15);
            lbCasado.TabIndex = 24;
            lbCasado.Text = "Casado";
            // 
            // lbSalario
            // 
            lbSalario.AutoSize = true;
            lbSalario.Location = new Point(59, 262);
            lbSalario.Name = "lbSalario";
            lbSalario.Size = new Size(42, 15);
            lbSalario.TabIndex = 23;
            lbSalario.Text = "Salario";
            // 
            // lbEdad
            // 
            lbEdad.AutoSize = true;
            lbEdad.Location = new Point(59, 188);
            lbEdad.Name = "lbEdad";
            lbEdad.Size = new Size(33, 15);
            lbEdad.TabIndex = 22;
            lbEdad.Text = "Edad";
            // 
            // lbDni
            // 
            lbDni.AutoSize = true;
            lbDni.Location = new Point(59, 148);
            lbDni.Name = "lbDni";
            lbDni.Size = new Size(25, 15);
            lbDni.TabIndex = 21;
            lbDni.Text = "Dni";
            // 
            // lbNombre
            // 
            lbNombre.AutoSize = true;
            lbNombre.Location = new Point(59, 106);
            lbNombre.Name = "lbNombre";
            lbNombre.Size = new Size(51, 15);
            lbNombre.TabIndex = 20;
            lbNombre.Text = "Nombre";
            // 
            // lbID
            // 
            lbID.AutoSize = true;
            lbID.Location = new Point(59, 74);
            lbID.Name = "lbID";
            lbID.Size = new Size(18, 15);
            lbID.TabIndex = 19;
            lbID.Text = "ID";
            // 
            // txbSalario
            // 
            txbSalario.Location = new Point(143, 259);
            txbSalario.Name = "txbSalario";
            txbSalario.Size = new Size(100, 23);
            txbSalario.TabIndex = 18;
            // 
            // txbEdad
            // 
            txbEdad.Location = new Point(143, 185);
            txbEdad.Name = "txbEdad";
            txbEdad.Size = new Size(100, 23);
            txbEdad.TabIndex = 16;
            // 
            // txbDni
            // 
            txbDni.Location = new Point(143, 145);
            txbDni.Name = "txbDni";
            txbDni.Size = new Size(100, 23);
            txbDni.TabIndex = 15;
            // 
            // txbNombre
            // 
            txbNombre.Location = new Point(143, 103);
            txbNombre.Name = "txbNombre";
            txbNombre.Size = new Size(100, 23);
            txbNombre.TabIndex = 14;
            // 
            // txbId
            // 
            txbId.Location = new Point(143, 71);
            txbId.Name = "txbId";
            txbId.Size = new Size(100, 23);
            txbId.TabIndex = 13;
            // 
            // chkCasado
            // 
            chkCasado.AutoSize = true;
            chkCasado.Location = new Point(145, 223);
            chkCasado.Name = "chkCasado";
            chkCasado.Size = new Size(35, 19);
            chkCasado.TabIndex = 17;
            chkCasado.Text = "SI";
            chkCasado.UseVisualStyleBackColor = true;
            // 
            // listBoxEmpleados
            // 
            listBoxEmpleados.FormattingEnabled = true;
            listBoxEmpleados.ItemHeight = 15;
            listBoxEmpleados.Location = new Point(347, 43);
            listBoxEmpleados.Name = "listBoxEmpleados";
            listBoxEmpleados.Size = new Size(484, 379);
            listBoxEmpleados.TabIndex = 26;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(893, 482);
            Controls.Add(listBoxEmpleados);
            Controls.Add(btnIngreso);
            Controls.Add(lbCasado);
            Controls.Add(lbSalario);
            Controls.Add(lbEdad);
            Controls.Add(lbDni);
            Controls.Add(lbNombre);
            Controls.Add(lbID);
            Controls.Add(txbSalario);
            Controls.Add(txbEdad);
            Controls.Add(txbDni);
            Controls.Add(txbNombre);
            Controls.Add(txbId);
            Controls.Add(chkCasado);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnIngreso;
        private Label lbCasado;
        private Label lbSalario;
        private Label lbEdad;
        private Label lbDni;
        private Label lbNombre;
        private Label lbID;
        private TextBox txbSalario;
        private TextBox txbEdad;
        private TextBox txbDni;
        private TextBox txbNombre;
        private TextBox txbId;
        private CheckBox chkCasado;
        private ListBox listBoxEmpleados;
    }
}
