using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace academia
{
    class Curso
    {
        public string Codigo { get; set; }
        public string Titulo { get; set; }
        public string Plazas { get; set; }
        public string Precio { get; set; }
        public string Realizacion { get; set; }

        public Curso(string codigo, string titulo, string plazas, string precio, string realizacion)
        {
            Codigo = codigo;
            Titulo = titulo;
            Plazas = plazas;
            Precio = precio;
            Realizacion = realizacion;
        }
        public Curso(string codigo)
        {
            Codigo = codigo;
        }
        public Curso()
        {
        }
    }
}
