namespace academia
{
    partial class frmAlumnos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblDni = new Label();
            lblNombre = new Label();
            lblApellidos = new Label();
            lblTelefono = new Label();
            lblPoblacion = new Label();
            txtDni = new TextBox();
            txtNombre = new TextBox();
            txtApellidos = new TextBox();
            txtTelefono = new TextBox();
            txtPoblacion = new TextBox();
            btnPrimerAlumno = new Button();
            btnAnteriorAlumno = new Button();
            btnSiguienteAlumno = new Button();
            btnUltimoAlumno = new Button();
            btnEditar = new Button();
            btnInsertar = new Button();
            btnBorrar = new Button();
            btnBuscar = new Button();
            btnLimpiar = new Button();
            dgvAlumnos = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellidos = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            poblacion = new DataGridViewTextBoxColumn();
            btnRefrescar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            SuspendLayout();
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.Location = new Point(180, 157);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(39, 20);
            lblDni.TabIndex = 0;
            lblDni.Text = "Dni: ";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(152, 245);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(67, 20);
            lblNombre.TabIndex = 1;
            lblNombre.Text = "Nombre:";
            // 
            // lblApellidos
            // 
            lblApellidos.AutoSize = true;
            lblApellidos.Location = new Point(144, 324);
            lblApellidos.Name = "lblApellidos";
            lblApellidos.Size = new Size(75, 20);
            lblApellidos.TabIndex = 2;
            lblApellidos.Text = "Apellidos:";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(149, 408);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 3;
            lblTelefono.Text = "Telefono:";
            // 
            // lblPoblacion
            // 
            lblPoblacion.AutoSize = true;
            lblPoblacion.Location = new Point(142, 496);
            lblPoblacion.Name = "lblPoblacion";
            lblPoblacion.Size = new Size(77, 20);
            lblPoblacion.TabIndex = 4;
            lblPoblacion.Text = "Poblacion:";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(225, 154);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(225, 242);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(125, 27);
            txtNombre.TabIndex = 6;
            // 
            // txtApellidos
            // 
            txtApellidos.Location = new Point(225, 321);
            txtApellidos.Name = "txtApellidos";
            txtApellidos.Size = new Size(125, 27);
            txtApellidos.TabIndex = 7;
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(225, 405);
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(125, 27);
            txtTelefono.TabIndex = 8;
            // 
            // txtPoblacion
            // 
            txtPoblacion.Location = new Point(225, 493);
            txtPoblacion.Name = "txtPoblacion";
            txtPoblacion.Size = new Size(125, 27);
            txtPoblacion.TabIndex = 9;
            // 
            // btnPrimerAlumno
            // 
            btnPrimerAlumno.Location = new Point(143, 606);
            btnPrimerAlumno.Name = "btnPrimerAlumno";
            btnPrimerAlumno.Size = new Size(94, 29);
            btnPrimerAlumno.TabIndex = 10;
            btnPrimerAlumno.Text = "<<";
            btnPrimerAlumno.UseVisualStyleBackColor = true;
            btnPrimerAlumno.Click += btnPrimerAlumno_Click;
            // 
            // btnAnteriorAlumno
            // 
            btnAnteriorAlumno.Location = new Point(243, 606);
            btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            btnAnteriorAlumno.Size = new Size(94, 29);
            btnAnteriorAlumno.TabIndex = 11;
            btnAnteriorAlumno.Text = "<";
            btnAnteriorAlumno.UseVisualStyleBackColor = true;
            btnAnteriorAlumno.Click += btnAnteriorAlumno_Click;
            // 
            // btnSiguienteAlumno
            // 
            btnSiguienteAlumno.Location = new Point(343, 606);
            btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            btnSiguienteAlumno.Size = new Size(94, 29);
            btnSiguienteAlumno.TabIndex = 12;
            btnSiguienteAlumno.Text = ">";
            btnSiguienteAlumno.UseVisualStyleBackColor = true;
            btnSiguienteAlumno.Click += btnSiguienteAlumno_Click;
            // 
            // btnUltimoAlumno
            // 
            btnUltimoAlumno.Location = new Point(443, 606);
            btnUltimoAlumno.Name = "btnUltimoAlumno";
            btnUltimoAlumno.Size = new Size(94, 29);
            btnUltimoAlumno.TabIndex = 13;
            btnUltimoAlumno.Text = ">>";
            btnUltimoAlumno.UseVisualStyleBackColor = true;
            btnUltimoAlumno.Click += btnUltimoAlumno_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(543, 606);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 14;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(643, 606);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 15;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(743, 606);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 16;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(843, 606);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 17;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(943, 606);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { dni, nombre, apellidos, telefono, poblacion });
            dgvAlumnos.Location = new Point(413, 154);
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(678, 366);
            dgvAlumnos.TabIndex = 19;
            dgvAlumnos.CellClick += dgvAlumnos_CellClick;
            // 
            // dni
            // 
            dni.HeaderText = "Dni";
            dni.MinimumWidth = 6;
            dni.Name = "dni";
            dni.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // apellidos
            // 
            apellidos.HeaderText = "Apellidos";
            apellidos.MinimumWidth = 6;
            apellidos.Name = "apellidos";
            apellidos.Width = 125;
            // 
            // telefono
            // 
            telefono.HeaderText = "Telefono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.Width = 125;
            // 
            // poblacion
            // 
            poblacion.HeaderText = "Poblacion";
            poblacion.MinimumWidth = 6;
            poblacion.Name = "poblacion";
            poblacion.Width = 125;
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(412, 520);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(30, 30);
            btnRefrescar.TabIndex = 20;
            btnRefrescar.Text = "🗘";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(974, 64);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(117, 29);
            btnVolver.TabIndex = 21;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmAlumnos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 703);
            Controls.Add(btnVolver);
            Controls.Add(btnRefrescar);
            Controls.Add(dgvAlumnos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(btnBorrar);
            Controls.Add(btnInsertar);
            Controls.Add(btnEditar);
            Controls.Add(btnUltimoAlumno);
            Controls.Add(btnSiguienteAlumno);
            Controls.Add(btnAnteriorAlumno);
            Controls.Add(btnPrimerAlumno);
            Controls.Add(txtPoblacion);
            Controls.Add(txtTelefono);
            Controls.Add(txtApellidos);
            Controls.Add(txtNombre);
            Controls.Add(txtDni);
            Controls.Add(lblPoblacion);
            Controls.Add(lblTelefono);
            Controls.Add(lblApellidos);
            Controls.Add(lblNombre);
            Controls.Add(lblDni);
            Name = "frmAlumnos";
            Text = "frmAlumnos";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblDni;
        private Label lblNombre;
        private Label lblApellidos;
        private Label lblTelefono;
        private Label lblPoblacion;
        private TextBox txtDni;
        private TextBox txtNombre;
        private TextBox txtApellidos;
        private TextBox txtTelefono;
        private TextBox txtPoblacion;
        private Button btnPrimerAlumno;
        private Button btnAnteriorAlumno;
        private Button btnSiguienteAlumno;
        private Button btnUltimoAlumno;
        private Button btnEditar;
        private Button btnInsertar;
        private Button btnBorrar;
        private Button btnBuscar;
        private Button btnLimpiar;
        private DataGridView dgvAlumnos;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellidos;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn poblacion;
        private Button btnRefrescar;
        private Button btnVolver;
    }
}