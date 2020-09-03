using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Lógica de interacción para WinAddCliente.xaml
    /// </summary>
    public partial class WinAddCliente : Window
    {
        public WinAddCliente()
        {
            InitializeComponent();
        }

       /*
        * da de alta un nuevo cliente
        */
        private void BtnAceptar_Click(object sender, RoutedEventArgs e)
        {
            Cliente oCliente = new Cliente();
            capturar_datos(oCliente);
            if (validar_email(oCliente.Cli_email) ){
                var confirmResult = MessageBox.Show(oCliente.ToString(),
                                     "Agregar? Si/No",
                                     MessageBoxButton.YesNo, MessageBoxImage.Question);
                if (confirmResult == MessageBoxResult.Yes)
                {
                    MessageBox.Show("Se agrego correctamente", "Agregado", MessageBoxButton.OK, MessageBoxImage.Information);
                    limpiar_campos();
                }
            }
            else
                MessageBox.Show("Formato email incorrecto");
        }

        /*
         * limpia los campos del formulario de clientes
         */
        public void limpiar_campos()
        {
            foreach (object obj in stckCliente.Children)
            {
                if (obj is StackPanel)
                {
                    StackPanel hijo = (StackPanel)obj;
                    foreach (object o in hijo.Children)
                    {
                        if (o is Border)
                        {
                            Border brd = (Border)o;
                            if(brd.Child is TextBox)
                            {
                                TextBox txt = (TextBox)brd.Child;
                                txt.Text = "";
                            }
                        }
                    }
                }
            }
        }

        /*
         * captura los datos del formulario cliente
         */
        public void capturar_datos(Cliente oCliente)
        {
            oCliente.Cli_dni = Convert.ToInt32(txtDni.Text);
            oCliente.Cli_apellido = txtApellido.Text;
            oCliente.Cli_nombre = txtNombre.Text;
            oCliente.Cli_telefono = Convert.ToInt32(txtTel.Text);
            oCliente.Cli_email = txtEmail.Text;
        }

        /*
        *valida el email con un patron 
        */
        public bool validar_email(string email)
        {
            String expresion;
            expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
            if (Regex.IsMatch(email, expresion))
            {
                if (Regex.Replace(email, expresion, String.Empty).Length == 0)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        //metodos clicks
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

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
