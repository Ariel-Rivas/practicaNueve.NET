using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//5- Crea una clase estática "Producto" , con un método estático , que sume 2 valores pasados por parámetro, 
//úsalo desde otro lugar.

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

          var result =  Producto.suma(122,564);


            WriteLine(result);
            ReadLine();
               
        }
    }
}
