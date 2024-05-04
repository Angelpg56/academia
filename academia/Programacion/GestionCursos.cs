using Mysqlx.Datatypes;
using Org.BouncyCastle.Math;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace academia
{
    class GestionCursos
    {
        public Curso Curso { set; get; }

        public GestionCursos()
        {
            Curso = new Curso();
        }
        public string Error()
        {
            return BaseDatos.Error;
        }
        public Curso Primero()
        {
            Curso = GetOneBySql("select * from cursos Order BY codigo");
            return Curso;
        }
        public Curso Ultimo()
        {
            Curso = GetOneBySql("select * from cursos Order BY codigo desc");
            return Curso;
        }

        public Curso Siguiente()
        {
            return GetOneBySql("select * from cursos where codigo > '" + Curso.Codigo + "'");
        }

        public Curso Anterior()
        {
            return GetOneBySql("select * from cursos where codigo < '" + Curso.Codigo + "' Order BY codigo desc");
        }
        public int Edit()
        {
            string sql = "select * from cursos where codigo = '" + Curso.Codigo + "'";
            if (BaseDatos.Consulta(sql).Rows.Count > 0)
            {
                sql = "update cursos set lugar_realizacion = '" + Curso.Realizacion + "', titulo = '"
                    + Curso.Titulo + "', n_plazas = '" + Curso.Plazas + "', precio = '"
                    + Curso.Precio + "' where codigo = '" + Curso.Codigo + "'";
                return BaseDatos.Modificacion(sql);
            }
            return -1;
        }

        public int Insert()
        {
            string sql = "select * from cursos where codigo = '" + Curso.Codigo + "'";
            if (!(BaseDatos.Consulta(sql).Rows.Count > 0))
            {
                sql = "insert into cursos (codigo, titulo, n_plazas, precio, lugar_realizacion) values('"
                    + Curso.Codigo + "', '" + Curso.Titulo + "', '" + Curso.Plazas + "', '"
                    + Curso.Precio + "', '" + Curso.Realizacion + "')";
                if(BaseDatos.Modificacion(sql) != -1)
                {
                    return 1;
                }
                else
                    MessageBox.Show("Hubo un problema al añadir el curso", "Aviso");
            }
            else
                MessageBox.Show("Hubo un problema al añadir el curso (Ya hay un curso registrado con ese codigo)", "Aviso");
            return -1;
        }
        public int Remove()
        {
            string sql = "delete from cursos where codigo = '" + Curso.Codigo + "'";
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea continuar?", "Confirma, por favor",
                 MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1);
            if (respuesta == DialogResult.OK)
                if (BaseDatos.Modificacion(sql) != -1)
                {
                    return 1;
                }
                return -1;
        }

        public Curso GetById(string codigo)
        {
            DataTable dt = BaseDatos.Consulta("select * from cursos where codigo = '" + codigo + "'");
            if (dt != null && dt.Rows.Count > 0)
            {
                Curso a = new Curso(dt.Rows[0]["codigo"].ToString(), dt.Rows[0]["titulo"].ToString(),
                    dt.Rows[0]["n_plazas"].ToString(), dt.Rows[0]["precio"].ToString(),
                    dt.Rows[0]["lugar_realizacion"].ToString());
                return a;
            }
            return null;
        }

        public List<Curso> GetAll()
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

        public Curso GetOneBySql(string sql)
        {
            DataTable dt = BaseDatos.Consulta(sql);
            if (dt != null && dt.Rows.Count > 0)
            {
                Curso a = new Curso(dt.Rows[0]["codigo"].ToString(), dt.Rows[0]["titulo"].ToString(),
                    dt.Rows[0]["n_plazas"].ToString(), dt.Rows[0]["precio"].ToString(), 
                    dt.Rows[0]["lugar_realizacion"].ToString());
                return a;
            }
            return null;
        }

        public DataTable GetAllBySql(string sql)
        {
            return BaseDatos.Consulta(sql);
        }
    }
}

