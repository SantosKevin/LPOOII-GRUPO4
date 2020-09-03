using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Butaca
    {
        private string but_fila;
        private int but_nro;
        private int but_nroSala;
        private string but_estado;

        public string But_fila { get => but_fila; set => but_fila = value; }
        public int But_nro { get => but_nro; set => but_nro = value; }
        public int But_nroSala { get => but_nroSala; set => but_nroSala = value; }
        public string But_estado { get => but_estado; set => but_estado = value; }
    }
}