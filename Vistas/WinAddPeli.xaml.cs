﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para WinAddPeli.xaml
    /// </summary>
    public partial class WinAddPeli : Window
    {
        public WinAddPeli()
        {
            InitializeComponent();
        }

        /*
         * da de alta una pelicula
        */
        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            Pelicula oPeli = new Pelicula();
            capturar_datos(oPeli);
            if (true) //validaciones luego
            {
                var confirmResult = MessageBox.Show(oPeli.ToString(),
                                     "Agregar? Si/No",
                                     MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (confirmResult == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Se agrego correctamente", "Agregado", MessageBoxButton.OK, MessageBoxImage.Information);
                    limpiar_campos();
                }
            }
            else
            {   // que onda xd
                MessageBox.Show("algo incorrecto");
            }
               
        }

        /*
         *captura los datos de los textboxs del formulario de alta peliculas
         */
        public void capturar_datos(Pelicula oPeli)
        {
            oPeli.Peli_titulo = txtTitulo.Text;
            oPeli.Peli_duracion = Convert.ToInt32(txtDuracion.Text);
            oPeli.Peli_genero = devolver_cadena_checkbox(cmbGenero);
            oPeli.Peli_clase = devolver_cadena_checkbox(cmbClase);
            oPeli.Peli_precio = Convert.ToDouble(txtPrecio.Text);
        }

        /*
         *devuelve una concatenacion de los checkboks seleccionados
         */
        public string devolver_cadena_checkbox(ComboBox cmb)
        {
            string cadena = "";
            foreach (CheckBox chk in cmb.Items)
            {
                if (chk.IsChecked == true)
                {
                    cadena += ", " + chk.Content;
                }
            }
            return cadena;
        }

        /*
         * limpia los campos del formulario de clientes
         */
        public void limpiar_campos()
        {
            foreach (object obj in stckPeli.Children)
            {
                if (obj is StackPanel)
                {
                    StackPanel hijo = (StackPanel)obj;
                    foreach (object o in hijo.Children)
                    {
                        if (o is Border)
                        {
                            Border brd = (Border)o;
                            if (brd.Child is TextBox)
                            {
                                TextBox txt = (TextBox)brd.Child;
                                txt.Text = "";
                            }
                            else //limpiando los checkboks
                            {
                                if(brd.Child is ComboBox)
                                {
                                    ComboBox cmb = (ComboBox)brd.Child;
                                    foreach (CheckBox chk in cmb.Items)
                                    {
                                        if (chk.IsChecked == true)
                                        {
                                            chk.IsChecked = false;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //metodos clicks
        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void DockMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }
    }
}
