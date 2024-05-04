using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academia.Programacion
{
    internal class GestionMatriculas
    {
        public Alumno Alumno { set; get; }
        public Curso Curso { set; get; }

        public List<Alumno> GetAllAlumnos()
        {
            List<Alumno> alumnos = new List<Alumno>();
            DataTable dt = BaseDatos.Consulta("select * from alumnos order by dni");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                alumnos.Add(new Alumno(dt.Rows[i]["dni"].ToString(), dt.Rows[i]["nombre"].ToString(),
               dt.Rows[i]["apellidos"].ToString(), dt.Rows[i]["telefono"].ToString(),
               dt.Rows[i]["poblacion"].ToString()));
            }
            return alumnos;
        }

        public List<Curso> GetAllCursos()
        {
            List<Curso> cursos = new List<Curso>();
            DataTable dt = BaseDatos.Consulta("select * from cursos order by codigo");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                cursos.Add(new Curso(dt.Rows[i]["codigo"].ToString(), dt.Rows[i]["titulo"].ToString(),
                    dt.Rows[i]["n_plazas"].ToString(), dt.Rows[i]["precio"].ToString(),
                    dt.Rows[i]["lugar_realizacion"].ToString()));
            }
            return cursos;
        }

        public List<Curso> CursosMatriculados()
        {
            List<Curso> cursos = new List<Curso>();
            DataTable dt = BaseDatos.Consulta("select * from cursos where codigo in (select codigo from matriculas where dni = '" + Alumno.Dni + "')");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                cursos.Add(new Curso(dt.Rows[i]["codigo"].ToString(), dt.Rows[i]["titulo"].ToString(),
                    dt.Rows[i]["n_plazas"].ToString(), dt.Rows[i]["precio"].ToString(),
                    dt.Rows[i]["lugar_realizacion"].ToString()));
            }
            return cursos;
        }

        public List<Alumno> AlumnosMatriculados()
        {
            List<Alumno> alumnos = new List<Alumno>();
            DataTable dt = BaseDatos.Consulta("select * from alumnos where dni in (select dni from matriculas where codigo = '" + Curso.Codigo + "')");
            for (int i = 0; dt != null && i < dt.Rows.Count; i++)
            {
                alumnos.Add(new Alumno(dt.Rows[i]["dni"].ToString(), dt.Rows[i]["nombre"].ToString(),
                    dt.Rows[i]["apellidos"].ToString(), dt.Rows[i]["telefono"].ToString(),
                    dt.Rows[i]["poblacion"].ToString()));
            }
            return alumnos;
        }

        public int Matricular()
        {
            string sql = "insert into matriculas (dni, codigo) values('"
                + Alumno.Dni + "', '" + Curso.Codigo + "')";
                if (BaseDatos.Modificacion(sql) != -1)
                {
                    return 1;
                }
                return -1;
        }

        public int Desmatricular()
        {
            string sql = "delete from matriculas where dni = '" + Alumno.Dni + "' and codigo = '" + Curso.Codigo + "'";
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea continuar?", "Confirma, por favor",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.OK)
                if (BaseDatos.Modificacion(sql) != -1)
                {
                    return 1;
                }
                return -1;
        }
        public int GetByDni()
        {
            DataTable dt = BaseDatos.Consulta("select * from alumnos where dni = '" + Alumno.Dni + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                new Alumno(dt.Rows[0]["dni"].ToString(), dt.Rows[0]["nombre"].ToString(),
                    dt.Rows[0]["apellidos"].ToString(), dt.Rows[0]["telefono"].ToString(),
                    dt.Rows[0]["poblacion"].ToString());
                return 1;
            }
            return -1;
        }
        public int GetByCodigo()
        {
            DataTable dt = BaseDatos.Consulta("select * from cursos where codigo = '" + Curso.Codigo + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                new Curso(dt.Rows[0]["codigo"].ToString(), dt.Rows[0]["titulo"].ToString(),
                    dt.Rows[0]["n_plazas"].ToString(), dt.Rows[0]["precio"].ToString(),
                    dt.Rows[0]["lugar_realizacion"].ToString());
                return 1;
            }
            return -1;
        }
    }
}
