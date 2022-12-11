using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace ConsoleApp1
{
    class Animal
    {
        public string Tipo { get; set;  } 
        public string colorPelo { get; set; }
        public bool esDomestico { get; set; }
        public int cantPatas { get; set; }


        public void imprime()
        {
           WriteLine(" Ficha del animal:" + this.Tipo  + "  -  "  + this.colorPelo + "  -  " + this.esDomestico + "  -  " + this.cantPatas);

        }
       
    }
}

