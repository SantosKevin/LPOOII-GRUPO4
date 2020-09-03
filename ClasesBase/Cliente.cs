using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Cliente
    {
        private int cli_dni;
        private string cli_apellido;
        private string cli_nombre;
        private string cli_email;
        private int cli_telefono;
        private int cli_id;

        public Cliente()
        {
        }

        public int Cli_dni { get => cli_dni; set => cli_dni = value; }
        public string Cli_apellido { get => cli_apellido; set => cli_apellido = value; }
        public string Cli_nombre { get => cli_nombre; set => cli_nombre = value; }
        public string Cli_email { get => cli_email; set => cli_email = value; }
        public int Cli_telefono { get => cli_telefono; set => cli_telefono = value; }
        public int Cli_id { get => cli_id; set => cli_id = value; }

        public override string ToString()
        {
            return "DNI: " + this.Cli_dni + "\nNombre: " + this.Cli_nombre
                + "\nApellido: " + this.Cli_apellido + "\nTelefono: " + Cli_telefono
                + "\nEmail: " + this.Cli_email;
        }
    }
}