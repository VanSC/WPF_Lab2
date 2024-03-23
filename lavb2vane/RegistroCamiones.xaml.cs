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
    /// Lógica de interacción para RegistroCamiones.xaml
    /// </summary>
    public partial class RegistroCamiones : Window
    {
        private List<Camion> listaCamiones = new List<Camion>();

        public RegistroCamiones()
        {
            InitializeComponent();
        }

        private void Registrar_Click(object sender, RoutedEventArgs e)
        {
            double PesoMaximo = double.Parse(txtPesoMax.Text);
            string Placa = txtPlaca.Text;
            double PesoVacio = double.Parse(txtPesoVacio.Text);


            Camion nuevoCamion = new Camion(PesoMaximo, Placa, PesoVacio);
            listaCamiones.Add(nuevoCamion);

            txtPesoMax.Clear();
            txtPlaca.Clear();
            txtPesoVacio.Clear();

            MessageBox.Show("Camión registrado exitosamente.");
        }

        private void Listar_Click( object sender, RoutedEventArgs e )
        {
            ListaCamiones listaCamionesWindow = new ListaCamiones(listaCamiones);
            listaCamionesWindow.Show();
        }
    }
}
