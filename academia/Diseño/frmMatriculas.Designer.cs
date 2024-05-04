namespace academia
{
    partial class frmMatriculas
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
            dgvAlumnos = new DataGridView();
            dni = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellidos = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            poblacion = new DataGridViewTextBoxColumn();
            dgvCursos = new DataGridView();
            codigo = new DataGridViewTextBoxColumn();
            titulo = new DataGridViewTextBoxColumn();
            plazas = new DataGridViewTextBoxColumn();
            precio = new DataGridViewTextBoxColumn();
            realizacion = new DataGridViewTextBoxColumn();
            txtCodigo = new TextBox();
            txtDni = new TextBox();
            btnTodosCursos = new Button();
            btnVerAlumnos = new Button();
            btnVerCursos = new Button();
            btnTodosAlumnos = new Button();
            btnMatricular = new Button();
            btnDesmatricular = new Button();
            btnVolver = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).BeginInit();
            SuspendLayout();
            // 
            // dgvAlumnos
            // 
            dgvAlumnos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAlumnos.Columns.AddRange(new DataGridViewColumn[] { dni, nombre, apellidos, telefono, poblacion });
            dgvAlumnos.Location = new Point(716, 132);
            dgvAlumnos.MultiSelect = false;
            dgvAlumnos.Name = "dgvAlumnos";
            dgvAlumnos.RowHeadersWidth = 51;
            dgvAlumnos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAlumnos.Size = new Size(678, 421);
            dgvAlumnos.TabIndex = 20;
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
            // dgvCursos
            // 
            dgvCursos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCursos.Columns.AddRange(new DataGridViewColumn[] { codigo, titulo, plazas, precio, realizacion });
            dgvCursos.Location = new Point(12, 132);
            dgvCursos.Name = "dgvCursos";
            dgvCursos.RowHeadersWidth = 51;
            dgvCursos.Size = new Size(678, 421);
            dgvCursos.TabIndex = 40;
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
            // txtCodigo
            // 
            txtCodigo.Location = new Point(565, 99);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(125, 27);
            txtCodigo.TabIndex = 41;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(716, 99);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(125, 27);
            txtDni.TabIndex = 42;
            // 
            // btnTodosCursos
            // 
            btnTodosCursos.Location = new Point(101, 589);
            btnTodosCursos.Name = "btnTodosCursos";
            btnTodosCursos.Size = new Size(211, 61);
            btnTodosCursos.TabIndex = 43;
            btnTodosCursos.Text = "Ver Todos Cursos";
            btnTodosCursos.UseVisualStyleBackColor = true;
            btnTodosCursos.Click += btnTodosCursos_Click;
            // 
            // btnVerAlumnos
            // 
            btnVerAlumnos.Location = new Point(422, 589);
            btnVerAlumnos.Name = "btnVerAlumnos";
            btnVerAlumnos.Size = new Size(211, 61);
            btnVerAlumnos.TabIndex = 44;
            btnVerAlumnos.Text = "Ver Alumnos del Curso";
            btnVerAlumnos.UseVisualStyleBackColor = true;
            btnVerAlumnos.Click += btnVerAlumnos_Click;
            // 
            // btnVerCursos
            // 
            btnVerCursos.Location = new Point(763, 589);
            btnVerCursos.Name = "btnVerCursos";
            btnVerCursos.Size = new Size(211, 61);
            btnVerCursos.TabIndex = 45;
            btnVerCursos.Text = "Ver Cursos del Alumno";
            btnVerCursos.UseVisualStyleBackColor = true;
            btnVerCursos.Click += btnVerCursos_Click;
            // 
            // btnTodosAlumnos
            // 
            btnTodosAlumnos.Location = new Point(1088, 589);
            btnTodosAlumnos.Name = "btnTodosAlumnos";
            btnTodosAlumnos.Size = new Size(211, 61);
            btnTodosAlumnos.TabIndex = 47;
            btnTodosAlumnos.Text = "Ver Todos Alumnos";
            btnTodosAlumnos.UseVisualStyleBackColor = true;
            btnTodosAlumnos.Click += btnTodosAlumnos_Click;
            // 
            // btnMatricular
            // 
            btnMatricular.Location = new Point(896, 47);
            btnMatricular.Name = "btnMatricular";
            btnMatricular.Size = new Size(211, 61);
            btnMatricular.TabIndex = 48;
            btnMatricular.Text = "Matricular Alumno";
            btnMatricular.UseVisualStyleBackColor = true;
            btnMatricular.Click += btnMatricular_Click;
            // 
            // btnDesmatricular
            // 
            btnDesmatricular.Location = new Point(1113, 47);
            btnDesmatricular.Name = "btnDesmatricular";
            btnDesmatricular.Size = new Size(211, 61);
            btnDesmatricular.TabIndex = 49;
            btnDesmatricular.Text = "Desmatricular Alumno";
            btnDesmatricular.UseVisualStyleBackColor = true;
            btnDesmatricular.Click += btnDesmatricular_Click;
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(61, 47);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(117, 29);
            btnVolver.TabIndex = 50;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmMatriculas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1407, 703);
            Controls.Add(btnVolver);
            Controls.Add(btnDesmatricular);
            Controls.Add(btnMatricular);
            Controls.Add(btnTodosAlumnos);
            Controls.Add(btnVerCursos);
            Controls.Add(btnVerAlumnos);
            Controls.Add(btnTodosCursos);
            Controls.Add(txtDni);
            Controls.Add(txtCodigo);
            Controls.Add(dgvCursos);
            Controls.Add(dgvAlumnos);
            Name = "frmMatriculas";
            Text = "frmMatriculas";
            ((System.ComponentModel.ISupportInitialize)dgvAlumnos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvCursos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvAlumnos;
        private DataGridViewTextBoxColumn dni;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellidos;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn poblacion;
        private DataGridView dgvCursos;
        private DataGridViewTextBoxColumn codigo;
        private DataGridViewTextBoxColumn titulo;
        private DataGridViewTextBoxColumn plazas;
        private DataGridViewTextBoxColumn precio;
        private DataGridViewTextBoxColumn realizacion;
        private TextBox txtCodigo;
        private TextBox txtDni;
        private Button btnTodosCursos;
        private Button btnVerAlumnos;
        private Button btnVerCursos;
        private Button btnTodosAlumnos;
        private Button btnMatricular;
        private Button btnDesmatricular;
        private Button btnVolver;
    }
}