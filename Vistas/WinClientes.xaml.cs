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

namespace Vistas
{
    /// <summary>
    /// Lógica de interacción para WinClientes.xaml
    /// </summary>
    public partial class WinClientes : UserControl
    {
        public WinClientes()
        {
            InitializeComponent();
        }

        private void BtnAgregarCliente_Click(object sender, RoutedEventArgs e)
        {
            WinAddCliente wAddCli = new WinAddCliente();
            wAddCli.ShowDialog();
        }

        private void BtnAgregarCliente_Click_1(object sender, RoutedEventArgs e)
        {
            WinAddCliente wAddC = new WinAddCliente();
            wAddC.ShowDialog();
        }
    }
}
