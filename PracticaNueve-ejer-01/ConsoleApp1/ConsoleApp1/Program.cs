using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


// 1- Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas. 
//Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas mayores de edad (mayores o iguales a 18 años), se tendrá que crear una clase "Persona" que contenga las propiedades "Nombre" y "Edad".
//Utilizar todos los componentes vistos hasta la fecha (bucles, funciones, clases).

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {



            //Lista
            List<Persona> personas = new List<Persona>();

            for (int i = 0; i < 5; i++)
            {
                WriteLine("Ingrese nombre y edad de la persona");
                var nombre = ReadLine();
                var edad = Convert.ToInt32(ReadLine());

                personas.Add(new Persona { Nombre = nombre, Edad = edad });

            }

            foreach (var Persona in personas)
            {
                if (cumple(Persona))
                    WriteLine("" + Persona.Nombre + " es mayor de 18 años");
            }
            ReadLine();

        }
            
               public static bool cumple(Persona persona)
                {
                  if (persona.Edad >= 18) 
                      return true;

                  return false; 
                  
                }
                     
      }      
}         

    

