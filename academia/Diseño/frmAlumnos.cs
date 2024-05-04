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
    public partial class frmAlumnos : Form
    {
        GestionAlumnos gAlumnos = new GestionAlumnos();
        int seleccionAlumno;

        public frmAlumnos()
        {
            InitializeComponent();
            RefrescarDGV();
        }

        private void RefrescarDGV()
        {
            dgvAlumnos.Rows.Clear();

            foreach (Alumno a in gAlumnos.GetAll())
            {
                int i = dgvAlumnos.Rows.Add();

                dgvAlumnos.Rows[i].Cells[0].Value = a.Dni;
                dgvAlumnos.Rows[i].Cells[1].Value = a.Nombre;
                dgvAlumnos.Rows[i].Cells[2].Value = a.Apellidos;
                dgvAlumnos.Rows[i].Cells[3].Value = a.Telefono;
                dgvAlumnos.Rows[i].Cells[4].Value = a.Poblacion;
            }
        }

        public void MaperarNegocioPresentacion(int n) //del objeto Alumno a los textBox
        {
            dgvAlumnos.Rows[n].Cells[0].Value = txtDni.Text;
            dgvAlumnos.Rows[n].Cells[1].Value = txtNombre.Text;
            dgvAlumnos.Rows[n].Cells[2].Value = txtApellidos.Text;
            dgvAlumnos.Rows[n].Cells[3].Value = txtTelefono.Text;
            dgvAlumnos.Rows[n].Cells[4].Value = txtPoblacion.Text;
        }
        public void MapearPresentacionNegocio(int n) //de los textbox al objeto Alumno
        {
            txtDni.Text = (string)dgvAlumnos.Rows[n].Cells[0].Value;
            txtNombre.Text = (string)dgvAlumnos.Rows[n].Cells[1].Value;
            txtApellidos.Text = (string)dgvAlumnos.Rows[n].Cells[2].Value;
            txtTelefono.Text = (string)dgvAlumnos.Rows[n].Cells[3].Value;
            txtPoblacion.Text = (string)dgvAlumnos.Rows[n].Cells[4].Value;

            gAlumnos.Alumno = new Alumno(txtDni.Text, txtNombre.Text,
                    txtApellidos.Text, txtTelefono.Text, txtPoblacion.Text);
        }

        private void Limpiar()
        {
            txtDni.Text = "";
            txtNombre.Text = "";
            txtApellidos.Text = "";
            txtPoblacion.Text = "";
            txtTelefono.Text = "";
        }

        private bool BuscarDNI()
        {
            if (txtDni.Text != "")
            {
                for (int i = 0; i < dgvAlumnos.Rows.Count; i++)
                {
                    if ((string)dgvAlumnos.Rows[i].Cells[0].Value == txtDni.Text)
                    {
                        seleccionAlumno = i;
                        return true;
                    }
                }
                MessageBox.Show("Sin coincidencias", "Aviso");
            }
            return false;
        }

        private void SeleccionarDGV()
        {
            if (BuscarDNI())
            {
                dgvAlumnos.ClearSelection();
                dgvAlumnos.Rows[seleccionAlumno].Selected = true;
                MapearPresentacionNegocio(seleccionAlumno);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (txtDni.Text != "" && txtNombre.Text != "" && txtApellidos.Text != ""
                && txtPoblacion.Text != "" && txtTelefono.Text != "")
            {
                gAlumnos.Alumno = new Alumno(txtDni.Text, txtNombre.Text,
                    txtApellidos.Text, txtTelefono.Text, txtPoblacion.Text);
                if (gAlumnos.Insert() != -1)
                {
                    MaperarNegocioPresentacion(dgvAlumnos.Rows.Add());

                    Limpiar();
                    RefrescarDGV();
                }
            }
            else
            {
                MessageBox.Show("No pueden haber celdas vacias", "Aviso");
            }
        }

        private void dgvAlumnos_CellClick(object sender, DataGridViewCellEventArgs e)
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
            if (BuscarDNI())
            {
                gAlumnos.Alumno = new Alumno(txtDni.Text, txtNombre.Text,
                    txtApellidos.Text, txtTelefono.Text, txtPoblacion.Text);

                if (gAlumnos.Edit() == -1)
                {
                    MessageBox.Show("Hubo un problema al intentar editar el alumno seleccionado", "Error");
                }
                else
                    RefrescarDGV();
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (BuscarDNI())
                {
                    gAlumnos.Alumno = new Alumno(txtDni.Text, txtNombre.Text,
                        txtApellidos.Text, txtTelefono.Text, txtPoblacion.Text);

                    if (gAlumnos.Remove() != -1)
                    {
                        dgvAlumnos.Rows.RemoveAt(seleccionAlumno);
                        RefrescarDGV();
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Hubo un problema al intentar borrar el alumno seleccionado", "Error");
            }
            Limpiar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            SeleccionarDGV();
        }

        private void btnPrimerAlumno_Click(object sender, EventArgs e)
        {
            txtDni.Text = gAlumnos.Primero().Dni;
            SeleccionarDGV();
        }

        private void btnAnteriorAlumno_Click(object sender, EventArgs e)
        {
            Alumno a = gAlumnos.Anterior();
            if (a != null)
            {
                txtDni.Text = a.Dni;
                SeleccionarDGV();
            }
        }

        private void btnSiguienteAlumno_Click(object sender, EventArgs e)
        {
            Alumno a = gAlumnos.Siguiente();
            if (a != null)
            {
                txtDni.Text = a.Dni;
                SeleccionarDGV();
            }
        }

        private void btnUltimoAlumno_Click(object sender, EventArgs e)
        {
            txtDni.Text = gAlumnos.Ultimo().Dni;
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
