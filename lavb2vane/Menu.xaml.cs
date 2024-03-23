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

namespace lavb2vane
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Ingresos_operacionClick(object sender, RoutedEventArgs e)
        {
            OperacionesIngresos ingresos = new OperacionesIngresos();
            ingresos.ShowDialog();

        }

        private void Registro_CamionClick(object sender, RoutedEventArgs e)
        {
           RegistroCamiones camione = new RegistroCamiones();
           camione.ShowDialog();
        }
    }
}
