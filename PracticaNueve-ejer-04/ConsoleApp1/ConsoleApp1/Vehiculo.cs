using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace ConsoleApp1
{
    class Vehiculo
    {
        public int Ruedas{ get; set; }
        public int puertasPrivadas{get; set;}
    
    public Vehiculo()
    {
        Ruedas = 0;
        puertasPrivadas = 0;
    }

    public Vehiculo(int ruedas)
    {
            Ruedas = ruedas;
            puertasPrivadas = 0;
    }

    public Vehiculo(int ruedas, int puertas)
    {
        Ruedas = ruedas;
        puertasPrivadas = puertas;
    }

        public void Imprime()
        {
            WriteLine("Cantidad de ruedas " + this.Ruedas + " - puertas privadas: " + this.puertasPrivadas );
        }
    }
}

