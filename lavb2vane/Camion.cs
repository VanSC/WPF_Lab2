using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lavb2vane
{
    public class Camion
    {
        public double PesoMaximo { get; set; }
        public string Placa { get; set; }
        public double PesoVacio { get; set; }

        public Camion(double pesoMaximo, string placa, double pesoVacio)
        {
            PesoMaximo = pesoMaximo;
            Placa = placa;
            PesoVacio = pesoVacio;
        }
    }
}
