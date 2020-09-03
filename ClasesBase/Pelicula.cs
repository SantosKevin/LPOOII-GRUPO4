using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClasesBase
{
    public class Pelicula
    {
        private int peli_codigo;
        private string peli_titulo;
        private int peli_duracion;
        private string peli_genero;
        private string peli_clase;
        private double peli_precio;

        public Pelicula()
        {
        }

        public int Peli_codigo { get => peli_codigo; set => peli_codigo = value; }
        public string Peli_titulo { get => peli_titulo; set => peli_titulo = value; }
        public int Peli_duracion { get => peli_duracion; set => peli_duracion = value; }
        public string Peli_genero { get => peli_genero; set => peli_genero = value; }
        public string Peli_clase { get => peli_clase; set => peli_clase = value; }
        public double Peli_precio { get => peli_precio; set => peli_precio = value; }

        public override string ToString()
        {
            return "Titulo: " + this.Peli_titulo + "\nDuracion: " + this.Peli_duracion
                + "\nGenero: " + this.Peli_genero + "\nClase: " + Peli_clase
                + "\nPrecio: " + this.Peli_precio;
        }
    }
}