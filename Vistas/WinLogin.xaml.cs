using System;
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
    /// Lógica de interacción para WinLogin.xaml
    /// </summary>
    public partial class WinLogin : Window
    {
        MainWindow main = new MainWindow();

        public WinLogin()
        {
            InitializeComponent();
            btnNormal.Visibility = Visibility.Collapsed;
        }

       

        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        private void BtnMaxi_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            btnMaxi.Visibility = Visibility.Collapsed;
            btnNormal.Visibility = Visibility.Visible;

        }

        private void BtnNormal_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Normal;
            btnNormal.Visibility = Visibility.Collapsed;
            btnMaxi.Visibility = Visibility.Visible;
        }

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
            
        }

        private void TxtUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtUsername.Text == "Username" || txtUsername.Text == "")
                txtUsername.Text = "";

        }

        private void TxtUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if(txtUsername.Text == "")
                txtUsername.Text = "Username";
        }

        private void TxtPass_LostFocus(object sender, RoutedEventArgs e)
        {
            if (txtPass.Password == "")
                txtPass.Password = "Password";
        }

        private void TxtPass_GotFocus(object sender, RoutedEventArgs e)
        {
            if (txtPass.Password == "Password" || txtPass.Password == "")
                txtPass.Password = "";
        }

        private void BtnIngreso_Click(object sender, RoutedEventArgs e)
        {
            string usu = txtUsername.Text;
            string pass = txtPass.Password;
            Usuario encontrado = main.verificarUsuario(usu, pass);
            if (encontrado.Usu_nombreUsuario != null)
            {
                //MessageBox.Show(encontrado.Usu_nombreUsuario + " " + encontrado.Rol_codigo);
                this.Hide();
                main.usuarioConectado.Usu_nombreUsuario = encontrado.Usu_nombreUsuario;
                main.usuarioConectado.Rol_codigo = encontrado.Rol_codigo;
                main.modificar_menu();
                main.actualizar_nombre();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Datos incorrectos", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void DockMenu_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }


    }
}
