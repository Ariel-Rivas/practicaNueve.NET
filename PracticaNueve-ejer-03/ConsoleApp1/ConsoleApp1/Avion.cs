using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp1
{
    class Avion : Vehiculo
    {
        public Avion(string nombre, string color, string marca, int modelo, int velMax, int cantRuedas) : base(nombre, color, marca, modelo, velMax, cantRuedas)
        {
        }
        public override bool EstaParaVenta(bool venta)
        {
            //siempre devuelve true, como cambio de la sobrecarga

            return false;



        }
    }
}
