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
    public partial class frmCursos : Form
    {
        GestionCursos gCursos = new GestionCursos();
        int seleccionAlumno;

        public frmCursos()
        {
            InitializeComponent();
            RefrescarDGV();
        }

        private void RefrescarDGV()
        {
            dgvCursos.Rows.Clear();

            foreach (Curso c in gCursos.GetAll())
            {
                int i = dgvCursos.Rows.Add();

                dgvCursos.Rows[i].Cells[0].Value = c.Codigo;
                dgvCursos.Rows[i].Cells[1].Value = c.Titulo;
                dgvCursos.Rows[i].Cells[2].Value = c.Plazas;
                dgvCursos.Rows[i].Cells[3].Value = c.Precio;
                dgvCursos.Rows[i].Cells[4].Value = c.Realizacion;
            }
        }

        public void MaperarNegocioPresentacion(int n) //del objeto Alumno a los textBox
        {
            dgvCursos.Rows[n].Cells[0].Value = txtCodigo.Text;
            dgvCursos.Rows[n].Cells[1].Value = txtTitulo.Text;
            dgvCursos.Rows[n].Cells[2].Value = txtNPlazas.Text;
            dgvCursos.Rows[n].Cells[3].Value = txtPrecio.Text;
            dgvCursos.Rows[n].Cells[4].Value = txtLRealizacion.Text;
        }
        public void MapearPresentacionNegocio(int n) //de los textbox al objeto Alumno
        {
            txtCodigo.Text = (string)dgvCursos.Rows[n].Cells[0].Value;
            txtTitulo.Text = (string)dgvCursos.Rows[n].Cells[1].Value;
            txtNPlazas.Text = (string)dgvCursos.Rows[n].Cells[2].Value;
            txtPrecio.Text = (string)dgvCursos.Rows[n].Cells[3].Value;
            txtLRealizacion.Text = (string)dgvCursos.Rows[n].Cells[4].Value;

            gCursos.Curso = new Curso(txtCodigo.Text, txtTitulo.Text,
                    txtNPlazas.Text, txtPrecio.Text, txtLRealizacion.Text);
        }

        private void Limpiar()
        {
            txtCodigo.Text = "";
            txtTitulo.Text = "";
            txtNPlazas.Text = "";
            txtPrecio.Text = "";
            txtLRealizacion.Text = "";
        }

        private bool BuscarCodigo()
        {
            if (txtCodigo.Text != "")
            {
                for (int i = 0; i < dgvCursos.Rows.Count; i++)
                {
                    if ((string)dgvCursos.Rows[i].Cells[0].Value == txtCodigo.Text)
                    {
                        seleccionAlumno = i;
                        return true;
                    }
                }
                MessageBox.Show("Sin coincidencias", "Aviso");
            }
            else
                MessageBox.Show("Agregue un codigo para realizar la busqueda", "Aviso");
            return false;
        }

        private void SeleccionarDGV()
        {
            if (BuscarCodigo())
            {
                dgvCursos.ClearSelection();
                dgvCursos.Rows[seleccionAlumno].Selected = true;
                MapearPresentacionNegocio(seleccionAlumno);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != "" && txtTitulo.Text != "" && txtNPlazas.Text != ""
                && txtPrecio.Text != "" && txtLRealizacion.Text != "")
            {
                gCursos.Curso = new Curso(txtCodigo.Text, txtTitulo.Text,
                    txtNPlazas.Text, txtPrecio.Text, txtLRealizacion.Text);
                if (gCursos.Insert() != -1)
                {
                    MaperarNegocioPresentacion(dgvCursos.Rows.Add());

                    Limpiar();
                    RefrescarDGV();
                }
                else
                    MessageBox.Show("No se pudo añadir el curso", "Error");
            }
            else
                MessageBox.Show("No pueden haber celdaas vacias", "Aviso");
        }

        private void dgvCursos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                seleccionAlumno = e.RowIndex;
                MapearPresentacionNegocio(seleccionAlumno);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (BuscarCodigo())
            {
                gCursos.Curso = new Curso(txtCodigo.Text, txtTitulo.Text,
                    txtNPlazas.Text, txtPrecio.Text, txtLRealizacion.Text);

                if (gCursos.Edit() == -1)
                {
                    MessageBox.Show("Hubo un problema al intentar editar el curso seleccionado", "Error");
                }
                else
                    RefrescarDGV();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (BuscarCodigo())
            {
                gCursos.Curso = new Curso(txtCodigo.Text, txtTitulo.Text,
                    txtNPlazas.Text, txtPrecio.Text, txtLRealizacion.Text);

                if (gCursos.Remove() != -1)
                {
                    dgvCursos.Rows.RemoveAt(seleccionAlumno);
                    RefrescarDGV();
                }
                else
                    MessageBox.Show("Hubo un problema al intentar borrar el curso seleccionado", "Error");
            }
            else
                MessageBox.Show("Hubo un problema al intentar borrar el curso seleccionado (No se encontro el curso)", "Error");
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SeleccionarDGV();
        }

        private void btnPrimerCurso_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = gCursos.Primero().Codigo;
            SeleccionarDGV();
        }

        private void btnAnteriorCurso_Click(object sender, EventArgs e)
        {
            Curso c = gCursos.Anterior();
            if (c != null)
            {
                txtCodigo.Text = c.Codigo;
                SeleccionarDGV();
            }
        }

        private void btnSiguienteCurso_Click(object sender, EventArgs e)
        {
            Curso c = gCursos.Siguiente();
            if (c != null)
            {
                txtCodigo.Text = c.Codigo;
                SeleccionarDGV();
            }
        }

        private void btnUltimoCurso_Click(object sender, EventArgs e)
        {
            txtCodigo.Text = gCursos.Ultimo().Codigo;
            SeleccionarDGV();
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            RefrescarDGV();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
