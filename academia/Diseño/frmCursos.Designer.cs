namespace academia
{
    partial class frmCursos
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
            dgvCursos = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            plazas = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            realizacion = new DataGridViewTextBoxColumn();
            btnLimpiar = new Button();
            btnBuscar = new Button();
            btnBorrar = new Button();
            btnInsertar = new Button();
            btnEditar = new Button();
            btnUltimoAlumno = new Button();
            btnSiguienteAlumno = new Button();
            btnAnteriorAlumno = new Button();
            btnPrimerAlumno = new Button();
            txtPrecio = new TextBox();
            txtNPlazas = new TextBox();
            txtLRealizacion = new TextBox();
            txtTitulo = new TextBox();
            txtCodigo = new TextBox();
            lblPrecio = new Label();
            lblNPlazas = new Label();
            lblLRealizacion = new Label();
            lblTitulo = new Label();
            lblCodigo = new Label();
            btnRefrescar = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            SuspendLayout();
            // 
            // dgvCursos
            // 
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Columns.AddRange(new DataGridViewColumn[] { codigo, titulo, plazas, precio, realizacion });
            dgvCursos.Location = new Point(413, 153);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.Size = new Size(678, 366);
            dgvCursos.TabIndex = 39;
            dgvCursos.CellClick += dgvCursos_CellClick;
            // 
            // codigo
            // 
            codigo.HeaderText = "Código";
            codigo.MinimumWidth = 6;
            codigo.Name = "codigo";
            codigo.Width = 125;
            // 
            // titulo
            // 
            titulo.HeaderText = "Titulo";
            titulo.MinimumWidth = 6;
            titulo.Name = "titulo";
            titulo.Width = 125;
            // 
            // plazas
            // 
            plazas.HeaderText = "Plazas";
            plazas.MinimumWidth = 6;
            plazas.Name = "plazas";
            plazas.Width = 125;
            // 
            // precio
            // 
            precio.HeaderText = "Precio";
            precio.MinimumWidth = 6;
            precio.Name = "precio";
            precio.Width = 125;
            // 
            // realizacion
            // 
            realizacion.HeaderText = "Realizacion";
            realizacion.MinimumWidth = 6;
            realizacion.Name = "realizacion";
            realizacion.Width = 125;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(943, 605);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(94, 29);
            btnLimpiar.TabIndex = 38;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(843, 605);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(94, 29);
            btnBuscar.TabIndex = 37;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnBorrar
            // 
            btnBorrar.Location = new Point(743, 605);
            btnBorrar.Name = "btnBorrar";
            btnBorrar.Size = new Size(94, 29);
            btnBorrar.TabIndex = 36;
            btnBorrar.Text = "Borrar";
            btnBorrar.UseVisualStyleBackColor = true;
            btnBorrar.Click += btnBorrar_Click;
            // 
            // btnInsertar
            // 
            btnInsertar.Location = new Point(643, 605);
            btnInsertar.Name = "btnInsertar";
            btnInsertar.Size = new Size(94, 29);
            btnInsertar.TabIndex = 35;
            btnInsertar.Text = "Insertar";
            btnInsertar.UseVisualStyleBackColor = true;
            btnInsertar.Click += btnInsertar_Click;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(543, 605);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(94, 29);
            btnEditar.TabIndex = 34;
            btnEditar.Text = "Editar";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnEditar_Click;
            // 
            // btnUltimoAlumno
            // 
            btnUltimoAlumno.Location = new Point(443, 605);
            btnUltimoAlumno.Name = "btnUltimoAlumno";
            btnUltimoAlumno.Size = new Size(94, 29);
            btnUltimoAlumno.TabIndex = 33;
            btnUltimoAlumno.Text = ">>";
            btnUltimoAlumno.UseVisualStyleBackColor = true;
            btnUltimoAlumno.Click += btnUltimoCurso_Click;
            // 
            // btnSiguienteAlumno
            // 
            btnSiguienteAlumno.Location = new Point(343, 605);
            btnSiguienteAlumno.Name = "btnSiguienteAlumno";
            btnSiguienteAlumno.Size = new Size(94, 29);
            btnSiguienteAlumno.TabIndex = 32;
            btnSiguienteAlumno.Text = ">";
            btnSiguienteAlumno.UseVisualStyleBackColor = true;
            btnSiguienteAlumno.Click += btnSiguienteCurso_Click;
            // 
            // btnAnteriorAlumno
            // 
            btnAnteriorAlumno.Location = new Point(243, 605);
            btnAnteriorAlumno.Name = "btnAnteriorAlumno";
            btnAnteriorAlumno.Size = new Size(94, 29);
            btnAnteriorAlumno.TabIndex = 31;
            btnAnteriorAlumno.Text = "<";
            btnAnteriorAlumno.UseVisualStyleBackColor = true;
            btnAnteriorAlumno.Click += btnAnteriorCurso_Click;
            // 
            // btnPrimerAlumno
            // 
            btnPrimerAlumno.Location = new Point(143, 605);
            btnPrimerAlumno.Name = "btnPrimerAlumno";
            btnPrimerAlumno.Size = new Size(94, 29);
            btnPrimerAlumno.TabIndex = 30;
            btnPrimerAlumno.Text = "<<";
            btnPrimerAlumno.UseVisualStyleBackColor = true;
            btnPrimerAlumno.Click += btnPrimerCurso_Click;
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(225, 492);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(125, 27);
            txtPrecio.TabIndex = 29;
            // 
            // txtNPlazas
            // 
            txtNPlazas.Location = new Point(225, 404);
            txtNPlazas.Name = "txtNPlazas";
            txtNPlazas.Size = new Size(125, 27);
            txtNPlazas.TabIndex = 28;
            // 
            // txtLRealizacion
            // 
            txtLRealizacion.Location = new Point(225, 320);
            txtLRealizacion.Name = "txtLRealizacion";
            txtLRealizacion.Size = new Size(125, 27);
            txtLRealizacion.TabIndex = 27;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(225, 241);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(125, 27);
            txtTitulo.TabIndex = 26;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(225, 153);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 25;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(166, 495);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(53, 20);
            lblPrecio.TabIndex = 24;
            lblPrecio.Text = "Precio:";
            // 
            // lblNPlazas
            // 
            lblNPlazas.AutoSize = true;
            lblNPlazas.Location = new Point(145, 407);
            lblNPlazas.Name = "lblNPlazas";
            lblNPlazas.Size = new Size(74, 20);
            lblNPlazas.TabIndex = 23;
            lblNPlazas.Text = "Nº Plazas:";
            // 
            // lblLRealizacion
            // 
            lblLRealizacion.AutoSize = true;
            lblLRealizacion.Location = new Point(73, 323);
            lblLRealizacion.Name = "lblLRealizacion";
            lblLRealizacion.Size = new Size(146, 20);
            lblLRealizacion.TabIndex = 22;
            lblLRealizacion.Text = "Lugar de realizacion:";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(169, 244);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(50, 20);
            lblTitulo.TabIndex = 21;
            lblTitulo.Text = "Titulo:";
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(158, 156);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(61, 20);
            lblCodigo.TabIndex = 20;
            lblCodigo.Text = "Código:";
            // 
            // btnRefrescar
            // 
            btnRefrescar.Location = new Point(412, 519);
            btnRefrescar.Name = "btnRefrescar";
            btnRefrescar.Size = new Size(30, 30);
            btnRefrescar.TabIndex = 40;
            btnRefrescar.Text = "🗘";
            btnRefrescar.UseVisualStyleBackColor = true;
            btnRefrescar.Click += btnRefrescar_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(974, 60);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(117, 29);
            btnVolver.TabIndex = 41;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmCursos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 703);
            Controls.Add(btnVolver);
            Controls.Add(btnRefrescar);
            Controls.Add(dgvCursos);
            Controls.Add(btnLimpiar);
            Controls.Add(btnBuscar);
            Controls.Add(btnBorrar);
            Controls.Add(btnInsertar);
            Controls.Add(btnEditar);
            Controls.Add(btnUltimoAlumno);
            Controls.Add(btnSiguienteAlumno);
            Controls.Add(btnAnteriorAlumno);
            Controls.Add(btnPrimerAlumno);
            Controls.Add(txtPrecio);
            Controls.Add(txtNPlazas);
            Controls.Add(txtLRealizacion);
            Controls.Add(txtTitulo);
            Controls.Add(txtCodigo);
            Controls.Add(lblPrecio);
            Controls.Add(lblNPlazas);
            Controls.Add(lblLRealizacion);
            Controls.Add(lblTitulo);
            Controls.Add(lblCodigo);
            Name = "frmCursos";
            Text = "frmCursos";
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvCursos;
        private Button btnLimpiar;
        private Button btnBuscar;
        private Button btnBorrar;
        private Button btnInsertar;
        private Button btnEditar;
        private Button btnUltimoAlumno;
        private Button btnSiguienteAlumno;
        private Button btnAnteriorAlumno;
        private Button btnPrimerAlumno;
        private TextBox txtPrecio;
        private TextBox txtNPlazas;
        private TextBox txtLRealizacion;
        private TextBox txtTitulo;
        private TextBox txtCodigo;
        private Label lblPrecio;
        private Label lblNPlazas;
        private Label lblLRealizacion;
        private Label lblTitulo;
        private Label lblCodigo;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn plazas;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn realizacion;
        private Button btnRefrescar;
        private Button btnVolver;
    }
}