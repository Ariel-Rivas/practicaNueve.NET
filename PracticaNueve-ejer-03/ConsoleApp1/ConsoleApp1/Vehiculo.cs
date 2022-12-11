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
        public string Nombre { get; set; }
        public string Color { get; set; }
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public int VelMax { get; set; }
        public int CantRuedas { get; set; }



        public Vehiculo() // Constructor vacio
        {

        }
        public Vehiculo(string nombre, string color, string marca, int modelo, int velMax, int cantRuedas) // Constructor lleno
        {
            Nombre = nombre;
            Color = color;
            Marca = marca;
            Modelo = modelo;
            VelMax = velMax;
            CantRuedas = cantRuedas;
        }

        public void Imprime()
        {
            Console.WriteLine("Vehiculo: " + this.Nombre + " - color: " + this.Color + " - marca:" + this.Marca + " - modelo: " + this.Modelo + " - velocidad maxima: " + this.VelMax + " - cantidad de ruedas: " + this.CantRuedas);
        }
        public virtual bool EstaParaVenta(bool venta)
        {

            return venta;
          
        }
    }
}
