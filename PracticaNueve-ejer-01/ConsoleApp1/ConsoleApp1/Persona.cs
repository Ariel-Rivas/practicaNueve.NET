﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 
namespace ConsoleApp1
{
    class Persona
    {
       public string Nombre { get; set; } 
       public  int  Edad { get; set; }

        public Persona()
        {

        }
        public Persona(string nombre, int Edad) 
       {
            this.Nombre = nombre;
            this.Edad = Edad; 
       }
    }
}
