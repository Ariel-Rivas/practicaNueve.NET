using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//3- Crear una Clase Base "Vehículo", y 3 clases derivadas de Vehículo, Coche, Barco, Avión, crea unos métodos 
//en vehículo, y sobrecargarlos en la clase derivada.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Avion avionComercial = new Avion(" Airbus A320 ", " blanco  ", " Boeing  ", 2019, 890, 12);
            Coche autoDeportivo = new Coche(" Audi SQ5 ", " negro ", " Audi ", 2022, 250, 4);
            Barco barco = new Barco(" Fragata ", " blanco ", " Q-2 ", 2022, 13, 0);


            avionComercial.Imprime();
            autoDeportivo.Imprime();
            barco.Imprime();

            ReadLine();
        }
    }
}
// Revisar ejercicio 