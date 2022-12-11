using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

//6- Crea una clase "Animal" con las siguientes propiedades: Tipo, color pelo, es domestico, numero de patas, 
//con el tipo de dato que creas conveniente. crea una instancia de esa clase, y asigna los valores a las propiedades.


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Animal();
           
            perro.Tipo = "cazador";
            perro.colorPelo = "marron";
            perro.esDomestico = true;
            perro.cantPatas = 4;

            perro.imprime();

            Animal gato = new Animal();
            gato.Tipo = "domestico";
            gato.colorPelo = "blanco";
            gato.esDomestico = true;
            gato.cantPatas = 4;

            gato.imprime(); 
            ReadLine();
        } 


    } 

}


