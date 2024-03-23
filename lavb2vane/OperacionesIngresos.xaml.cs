﻿using System;
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
    /// Lógica de interacción para OperacionesIngresos.xaml
    /// </summary>
    public partial class OperacionesIngresos : Window
    {
        public OperacionesIngresos()
        {
            InitializeComponent();
        }


        private void RegistroSalida_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Salida registrado correctamente");
        }
        private void back_click(object sender, RoutedEventArgs e)
        {
           Menu mn = new Menu();
           mn.ShowDialog();
           this.Close();
        }

    }
}
