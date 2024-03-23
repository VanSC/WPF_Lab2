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
    /// Lógica de interacción para ListaCamiones.xaml
    /// </summary>
    public partial class ListaCamiones : Window
    {
        private List<Camion> listaCamiones;
        public ListaCamiones(List<Camion> camiones)
        {
            InitializeComponent();

            listaCamiones = camiones;

            icCamiones.ItemsSource = listaCamiones;
        }
    }
}
