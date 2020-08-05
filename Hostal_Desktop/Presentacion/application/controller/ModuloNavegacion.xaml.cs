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

namespace Presentacion.application.controller
{
    /// <summary>
    /// Lógica de interacción para ModuloNavegacion.xaml
    /// </summary>
    public partial class ModuloNavegacion : Window
    {
       

        public ModuloNavegacion()
        {
            InitializeComponent();
            
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int index = int.Parse(((Button)e.Source).Uid);

            GridCursor.Margin = new Thickness(10 + (150 * index), 0, 0, 0);

            switch (index)
            {
                case 0:

                    
                    ctrl_izq.DataContext = new AgregarCliente();
                    ctrl_der.DataContext = new Módulo_Cliente();
                    ctrl_der.Visibility = Visibility.Visible;


                    break;
                case 1:

                    //GridMain.Background = Brushes.Gray;
                    ctrl_izq.DataContext  = new ServicioComedor();
                    ctrl_der.DataContext = new MóduloComedor();
                    ctrl_der.Visibility = Visibility.Visible;
                    break;

                case 2:

                    ctrl_izq.DataContext = new AgregarFactura();
                    ctrl_der.DataContext = new MóduloFactura();
                    ctrl_der.Visibility = Visibility.Visible;
                    break;

                case 3:

                    ctrl_izq.DataContext = new ReservaHabitación();
                    ctrl_der.DataContext = new Habitaciones();
                    ctrl_der.Visibility = Visibility.Visible;
                    break;

                case 4:

                    ctrl_izq.DataContext = new AgregarHuesped();
                    ctrl_der.DataContext = new MóduloHuésped();
                    ctrl_der.Visibility = Visibility.Visible;
                    break;

                case 5:

                    ctrl_izq.DataContext = new Ingresar_Orden_de_compra();
                    ctrl_der.DataContext = new MóduloOrdenDeCompra();
                    ctrl_der.Visibility = Visibility.Visible;
                    break;

                case 6:

                    ctrl_izq.DataContext = new IngresarOrdeDePedido();
                    ctrl_der.DataContext = new MóduloOrdenDePedido();
                    ctrl_der.Visibility = Visibility.Visible;
                    break;

                case 7:

                    ctrl_izq.DataContext = new AgregarProveedor();
                    ctrl_der.DataContext = new MóduloProveedor();
                    ctrl_der.Visibility = Visibility.Visible;
                    break;

                case 8:

                    ctrl_izq.DataContext = new ModuloInforme();
                    ctrl_der.Visibility = Visibility.Hidden;
                    break;

                case 9:

                    
                    ctrl_izq.DataContext = new Ayuda();
                    ctrl_der.Visibility = Visibility.Hidden;
                                         
                    break;
            }
        }

        

       
        
    }
}
