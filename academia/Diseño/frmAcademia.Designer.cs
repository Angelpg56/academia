namespace academia
{
    partial class frmAcademia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcademia));
            btnCursos = new Button();
            btnMatriculas = new Button();
            btnAlumnos = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnCursos
            // 
            btnCursos.Location = new Point(169, 523);
            btnCursos.Name = "btnCursos";
            btnCursos.Size = new Size(225, 29);
            btnCursos.TabIndex = 0;
            btnCursos.Text = "Gestion de Cursos";
            btnCursos.UseVisualStyleBackColor = true;
            btnCursos.Click += btnCursos_Click;
            // 
            // btnMatriculas
            // 
            btnMatriculas.Location = new Point(566, 523);
            btnMatriculas.Name = "btnMatriculas";
            btnMatriculas.Size = new Size(225, 29);
            btnMatriculas.TabIndex = 1;
            btnMatriculas.Text = "Gestion de Matriculas";
            btnMatriculas.UseVisualStyleBackColor = true;
            btnMatriculas.Click += btnMatriculas_Click;
            // 
            // btnAlumnos
            // 
            btnAlumnos.Location = new Point(959, 523);
            btnAlumnos.Name = "btnAlumnos";
            btnAlumnos.Size = new Size(225, 29);
            btnAlumnos.TabIndex = 2;
            btnAlumnos.Text = "Gestion de Alumnos";
            btnAlumnos.UseVisualStyleBackColor = true;
            btnAlumnos.Click += btnAlumnos_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(93, 64);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1187, 354);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // frmAcademia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1407, 703);
            Controls.Add(pictureBox1);
            Controls.Add(btnAlumnos);
            Controls.Add(btnMatriculas);
            Controls.Add(btnCursos);
            Name = "frmAcademia";
            Text = "Academia";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnCursos;
        private Button btnMatriculas;
        private Button btnAlumnos;
        private PictureBox pictureBox1;
    }
}
