using System.Windows.Forms;

namespace academia
{
    public partial class frmAcademia : Form
    {
        public frmAcademia()
        {
            InitializeComponent();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            frmCursos frmcurso = new frmCursos();
            frmcurso.Location = this.Location;
            frmcurso.StartPosition = FormStartPosition.Manual;
            frmcurso.FormClosing += delegate { this.Show(); };
            frmcurso.Show();
            this.Hide();

        }

        private void btnMatriculas_Click(object sender, EventArgs e)
        {
            frmMatriculas frmmatriculas = new frmMatriculas();
            frmmatriculas.Location = this.Location;
            frmmatriculas.StartPosition = FormStartPosition.Manual;
            frmmatriculas.FormClosing += delegate { this.Show(); };
            frmmatriculas.Show();
            this.Hide();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            frmAlumnos frmalumnos = new frmAlumnos();
            frmalumnos.Location = this.Location;
            frmalumnos.StartPosition = FormStartPosition.Manual;
            frmalumnos.FormClosing += delegate { this.Show(); };
            frmalumnos.Show();
            this.Hide();
        }
    }
}
