using academia.Programacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    public partial class frmMatriculas : Form
    {
        GestionMatriculas gMatriculas = new GestionMatriculas();

        public frmMatriculas()
        {
            InitializeComponent();
            RefrescarDgvCursos();
            RefrescarDgvAlumnos();
        }

        private void RefrescarDgvCursos()
        {
            dgvCursos.Rows.Clear();

            foreach (Curso c in gMatriculas.GetAllCursos())
            {
                int i = dgvCursos.Rows.Add();

                dgvCursos.Rows[i].Cells[0].Value = c.Codigo;
                dgvCursos.Rows[i].Cells[1].Value = c.Titulo;
                dgvCursos.Rows[i].Cells[2].Value = c.Plazas;
                dgvCursos.Rows[i].Cells[3].Value = c.Precio;
                dgvCursos.Rows[i].Cells[4].Value = c.Realizacion;
            }
        }

        private void RefrescarDgvAlumnos()
        {
            dgvAlumnos.Rows.Clear();

            foreach (Alumno a in gMatriculas.GetAllAlumnos())
            {
                int i = dgvAlumnos.Rows.Add();

                dgvAlumnos.Rows[i].Cells[0].Value = a.Dni;
                dgvAlumnos.Rows[i].Cells[1].Value = a.Nombre;
                dgvAlumnos.Rows[i].Cells[2].Value = a.Apellidos;
                dgvAlumnos.Rows[i].Cells[3].Value = a.Telefono;
                dgvAlumnos.Rows[i].Cells[4].Value = a.Poblacion;
            }
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtCodigo.Text = (string)dgvCursos.Rows[e.RowIndex].Cells[0].Value;
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtDni.Text = (string)dgvAlumnos.Rows[e.RowIndex].Cells[0].Value;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTodosCursos_Click(object sender, EventArgs e)
        {
            RefrescarDgvCursos();
        }

        private void btnTodosAlumnos_Click(object sender, EventArgs e)
        {
            RefrescarDgvAlumnos();
        }

        private void btnVerAlumnos_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "")
            {
                gMatriculas.Curso = new Curso(txtCodigo.Text);

                if (gMatriculas.GetByCodigo() != -1)
                {
                    dgvAlumnos.Rows.Clear();

                    foreach (Alumno a in gMatriculas.AlumnosMatriculados())
                    {
                        int i = dgvAlumnos.Rows.Add();

                        dgvAlumnos.Rows[i].Cells[0].Value = a.Dni;
                        dgvAlumnos.Rows[i].Cells[1].Value = a.Nombre;
                        dgvAlumnos.Rows[i].Cells[2].Value = a.Apellidos;
                        dgvAlumnos.Rows[i].Cells[3].Value = a.Telefono;
                        dgvAlumnos.Rows[i].Cells[4].Value = a.Poblacion;
                    }
                }
                else
                    MessageBox.Show("Codigo no encontrado", "Aviso");
            }
            else
                MessageBox.Show("Agregue un codigo para realizar la busqueda", "Aviso");
        }

        private void btnVerCursos_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != "")
            {
                gMatriculas.Alumno = new Alumno(txtDni.Text);

                if (gMatriculas.GetByDni() != -1)
                {
                    dgvCursos.Rows.Clear();

                    foreach (Curso c in gMatriculas.CursosMatriculados())
                    {
                        int i = dgvCursos.Rows.Add();

                        dgvCursos.Rows[i].Cells[0].Value = c.Codigo;
                        dgvCursos.Rows[i].Cells[1].Value = c.Titulo;
                        dgvCursos.Rows[i].Cells[2].Value = c.Plazas;
                        dgvCursos.Rows[i].Cells[3].Value = c.Precio;
                        dgvCursos.Rows[i].Cells[4].Value = c.Realizacion;
                    }
                }
                else
                    MessageBox.Show("Dni no encontrado", "Aviso");
            }
            else
                MessageBox.Show("Agregue un dni para realizar la busqueda", "Aviso");
        }

        private void btnMatricular_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != "" && txtCodigo.Text != "")
            {
                gMatriculas.Alumno = new Alumno(txtDni.Text);
                gMatriculas.Curso = new Curso(txtCodigo.Text);

                if (gMatriculas.GetByDni() != -1 && gMatriculas.GetByCodigo() != -1)
                {
                    if (gMatriculas.Matricular() == -1)
                    {
                        MessageBox.Show("Hubo un problema al matricular al alumno", "Aviso");
                    }
                }
                else
                    MessageBox.Show("El codigo del curso o el dni del alumno no coincide", "Aviso");
            }
            else
                MessageBox.Show("Uno de los campos esta vacio", "Aviso");
        }

        private void btnDesmatricular_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != "" && txtCodigo.Text != "")
            {
                gMatriculas.Alumno = new Alumno(txtDni.Text);
                gMatriculas.Curso = new Curso(txtCodigo.Text);
                if (gMatriculas.GetByDni() != -1 && gMatriculas.GetByCodigo() != -1)
                {
                    if (gMatriculas.Desmatricular() == -1)
                    {
                        MessageBox.Show("Hubo un problema al desmatricular al alumno", "Aviso");
                    }
                }
                else
                    MessageBox.Show("El codigo del curso o el dni del alumno no coincide", "Aviso");
            }
            else
                MessageBox.Show("Uno de los campos esta vacio", "Aviso");
        }
    }
}
