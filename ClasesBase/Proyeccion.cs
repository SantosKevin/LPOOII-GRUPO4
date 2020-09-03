using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Proyeccion
    {
        private int proy_codigo;
        private DateTime proy_fecha;
        private int proy_hora;
        private int proy_nroSala;
        private int peli_codigo;

        public int Proy_codigo { get => proy_codigo; set => proy_codigo = value; }
        public DateTime Proy_fecha { get => proy_fecha; set => proy_fecha = value; }
        public int Proy_hora { get => proy_hora; set => proy_hora = value; }
        public int Proy_nroSala { get => proy_nroSala; set => proy_nroSala = value; }
        public int Peli_codigo { get => peli_codigo; set => peli_codigo = value; }
    }
}