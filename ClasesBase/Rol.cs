using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Rol
    {
        private int rol_codigo;
        private string rol_descripcion;

        public int Rol_codigo { get => rol_codigo; set => rol_codigo = value; }
        public string Rol_descripcion { get => rol_descripcion; set => rol_descripcion = value; }
    }
}