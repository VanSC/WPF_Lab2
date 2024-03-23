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
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void IniciarSesion_Click(object sender, RoutedEventArgs e)
        {
            Menu menu = new Menu();

            string username = txtUsername.Text;
            string password = txtPassword.Password;

            if (username == "vanessa" && password == "vane1234")
            {
                MessageBox.Show("Bienvenido al sistema " + username);
                menu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Credenciales invalidos");
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
