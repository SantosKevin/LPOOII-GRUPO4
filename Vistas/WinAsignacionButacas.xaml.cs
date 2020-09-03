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
    /// Lógica de interacción para WinAsignacionButacas.xaml
    /// </summary>
    public partial class WinAsignacionButacas : Window
    {
        public int filas, columnas;
        public Butaca[,] listaButacas;

        public WinAsignacionButacas()
        {
            InitializeComponent();
            btnNormal.Visibility = Visibility.Collapsed;
            filas = 8; columnas = 10;
            listaButacas = new Butaca[filas, columnas];
            inicializar_grid();
            colocar_filas();
        }

        /*
         * inicializa el grid central donde estaran todas los cuadrados representados las butacas
         */
       public void inicializar_grid()
       {
            // Define the Rows
            for (int i = 0; i < filas; i++)
            {
                RowDefinition rowDef1 = new RowDefinition();
                myGrid.RowDefinitions.Add(rowDef1);
            }
            // Define the Columns
            for (int i=0; i < columnas; i ++)
            {
                ColumnDefinition colDef1 = new ColumnDefinition();
                myGrid.ColumnDefinitions.Add(colDef1);
            }
          
            // Add the elements cell to the Grid
            for(int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    Button btn = new Button();
                    btn.Content = i + " "+ j;
                    btn.FontSize = 20;
                    btn.Width = 40;
                    btn.Height = 40;
                    btn.HorizontalContentAlignment = HorizontalAlignment.Center;
                    btn.FontWeight = FontWeights.Bold;
                    Grid.SetRow(btn, i);
                    Grid.SetColumn(btn, j);
                    btn.Click += new RoutedEventHandler(handlerComun_Click);
                    // Add the TextBlock elements to the Grid Children collection
                    myGrid.Children.Add(btn);
                    //como pide el tp en esa butaca
                    if (i == 1 && j == 2)
                    {
                        btn.Background = Brushes.Red;
                        crear_butacas(i, j, "ocup");
                    }
                    else
                    {
                        btn.Background = Brushes.Gray;
                        crear_butacas(i, j, "disp");
                    }
                }
            }
            
        }

        /*
         * crea los objetos butacas para agregarlos a la lista 
         */
        public void crear_butacas(int i, int j, string estado)
        {
            Butaca butaca = new Butaca();
            int fl = i + 65; char h = (char)fl;
            butaca.But_fila = Convert.ToString(fl);
            butaca.But_nro = j;
            butaca.But_estado = estado;
            listaButacas[i, j] = butaca;
        }

        /*
         * coloca las letras de las filas en la secccion izquierda
         */
        public void colocar_filas()
        {
            for(int i =0; i< filas; i++)
            {
                RowDefinition rowDef1 = new RowDefinition();
                gridFilas.RowDefinitions.Add(rowDef1);
                ColumnDefinition colDef1 = new ColumnDefinition();
                gridFilas.ColumnDefinitions.Add(colDef1);
                TextBlock txtFila = new TextBlock();
                txtFila.Text = Convert.ToString(Convert.ToChar(i + 65));
                txtFila.Foreground = Brushes.White;
                txtFila.FontSize = 20;
                txtFila.Margin = new Thickness(0, 7, 0, 0);
                txtFila.FontWeight = FontWeights.Bold;
                Grid.SetRow(txtFila, i);
                Grid.SetColumn(txtFila, (filas / 2)- 1); //para sacar la mitad y qe quede al medioxD
                gridFilas.Children.Add(txtFila);
                gridFilas.HorizontalAlignment = HorizontalAlignment.Center;
            }
        }

        /*
         * el handler comun a todos los botones para capturar el evento click y cambiar el color
         */
        private void handlerComun_Click(Object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int f = Grid.GetRow(btn); int c = Grid.GetColumn(btn);
            Butaca seleccionada = listaButacas[f, c];
            if (seleccionada.But_estado == "disp")
            {
                btn.Background = Brushes.Green;
                listaButacas[f, c].But_estado = "selec";
            }
            else
            {
                if (seleccionada.But_estado == "selec")
                {
                    btn.Background = Brushes.Gray;
                    listaButacas[f, c].But_estado = "disp";
                }
            }
            
            
        }



        //botones del menu
        private void BtnCerrar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
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

        private void BtnCancelar_Click(object sender, RoutedEventArgs e)
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
