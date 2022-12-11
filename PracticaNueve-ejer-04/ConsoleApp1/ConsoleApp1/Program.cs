using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


//4- Crear una Clase Vehículo, con las propiedades , Ruedas, puertas privadas, crear 3 constructores para asignar los 
//valores de las propiedades, 
//el constructor por defecto y 2 constructores mas que creas convenientes. 

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo bicicleta = new Vehiculo(); // 0 ruedas - 0 puertas
            Vehiculo auto = new Vehiculo(4, 0); // 4 ruedas - 0 puertas 
            Vehiculo camioneta = new Vehiculo(4, 4); // 4 ruedas - 4 puertas 

            bicicleta.Imprime();
            auto.Imprime();
            camioneta.Imprime();
            ReadLine(); 
        }
    }
}
