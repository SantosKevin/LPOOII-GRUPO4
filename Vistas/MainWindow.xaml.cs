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
using System.Windows.Navigation;
using System.Windows.Shapes;
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Usuario[] usuarios = new Usuario[2];
        public Usuario usuarioConectado;

        public MainWindow()
        {
            InitializeComponent();
            btnNormal.Visibility = Visibility.Collapsed;
            this.usuarioConectado = new Usuario();
            cargarUsuarios();
            modificar_menu();

        }

        public void actualizar_nombre()
        {
            lblNombre.Content = usuarioConectado.Usu_nombreUsuario;
        }

        public void cargarUsuarios()
        {
            Usuario u1 = new Usuario("admin", "123", 1);
            Usuario u2 = new Usuario("vende", "123", 2);
            this.usuarios[0] = u1;
            this.usuarios[1] = u2;
        }

        public Usuario verificarUsuario(string usu, string pass)
        {
            int indice = -1;
            for (int i = 0; i < this.usuarios.Length; i++)
            {
                if (usu == usuarios[i].Usu_nombreUsuario && pass == usuarios[i].Usu_contrasenia)
                {
                    indice = i;                
                }
            }
            Usuario uEncontrado = new Usuario();
            if (indice != -1)
            {
                uEncontrado.Rol_codigo = usuarios[indice].Rol_codigo;
                uEncontrado.Usu_nombreUsuario = usuarios[indice].Usu_nombreUsuario;
            }
            return uEncontrado;
        }


        public void modificar_menu()
        {
           if(usuarioConectado.Rol_codigo == 1)
            {
                btnClientes.Visibility = Visibility.Collapsed;
                btnTicket.Visibility = Visibility.Collapsed;
            }
           if(usuarioConectado.Rol_codigo == 2)
            {
                btnUsuarios.Visibility = Visibility.Collapsed;
                btnProyec.Visibility = Visibility.Collapsed;
                btnPeli.Visibility = Visibility.Collapsed;
                btnButacas.Visibility = Visibility.Collapsed;
            }
            
            
        }

        //apariencia

        private void BtnMin_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void BtnMax_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Maximized;
            btnMax.Visibility = Visibility.Collapsed;
            btnNormal.Visibility = Visibility.Visible;
        }
        private void BtnNormal_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Normal;
            btnNormal.Visibility = Visibility.Collapsed;
            btnMax.Visibility = Visibility.Visible;
        }

        private void BtnClose_Click(object sender, RoutedEventArgs e)
        {
            App.Current.Shutdown();
        }

        //abrir las ventanas hijas

        public void abrir_win_hija(UIElement e)
        {
            gridCentral.Children.Clear();
            gridCentral.Children.Add(e);
        }
        private void BtnClientes_Click(object sender, RoutedEventArgs e)
        {
            abrir_win_hija(new WinClientes());
        }

        private void BtnPeli_Click(object sender, RoutedEventArgs e)
        {
            abrir_win_hija(new WinPelis());
        }

        //para mover la ventana a nuestro gusto
        private void DockPanel_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                DragMove();
        }

        private void BtnClientes_Click_1(object sender, RoutedEventArgs e)
        {
            abrir_win_hija(new WinClientes());
        }

        private void BtnButacas_Click(object sender, RoutedEventArgs e)
        {
            WinAsignacionButacas wAsignButacas = new WinAsignacionButacas();
            wAsignButacas.ShowDialog();
        }

        private void BtnCerrarSesion_Click(object sender, RoutedEventArgs e)
        {
            WinLogin wlogin = new WinLogin();
            this.Hide();
            wlogin.Show();
        }
    }
}
