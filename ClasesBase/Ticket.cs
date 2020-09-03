using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Ticket
    {
        private int tick_nro;
        private DateTime tick_fechaVenta;
        private int cli_id;
        private int proy_codigo;
        private string but_fila;
        private int but_nro;

        public int Tick_nro { get => tick_nro; set => tick_nro = value; }
        public DateTime Tick_fechaVenta { get => tick_fechaVenta; set => tick_fechaVenta = value; }
        public int Cli_id { get => cli_id; set => cli_id = value; }
        public int Proy_codigo { get => proy_codigo; set => proy_codigo = value; }
        public string But_fila { get => but_fila; set => but_fila = value; }
        public int But_nro { get => but_nro; set => but_nro = value; }
    }
}