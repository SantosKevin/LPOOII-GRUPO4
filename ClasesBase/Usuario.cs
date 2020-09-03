using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Usuario
    {
        private int usu_id;
        private string usu_nombreUsuario;
        private string usu_contrasenia;
        private string usu_apellidoNombre;
        private int rol_codigo;

        public Usuario()
        {
        }

        public Usuario(string usu_nombreUsuario, string usu_contrasenia, int rol_codigo)
        {
            this.usu_nombreUsuario = usu_nombreUsuario;
            this.usu_contrasenia = usu_contrasenia;
            this.rol_codigo = rol_codigo;
        }

        public int Usu_id { get => usu_id; set => usu_id = value; }
        public string Usu_nombreUsuario { get => usu_nombreUsuario; set => usu_nombreUsuario = value; }
        public string Usu_contrasenia { get => usu_contrasenia; set => usu_contrasenia = value; }
        public string Usu_apellidoNombre { get => usu_apellidoNombre; set => usu_apellidoNombre = value; }
        public int Rol_codigo { get => rol_codigo; set => rol_codigo = value; }
    }
}