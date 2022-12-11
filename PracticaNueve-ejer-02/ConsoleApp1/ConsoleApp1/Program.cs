using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 5cb99e6 (NET)

// 1- Desarrollar un programa que permita cargar 5 nombres de personas y sus edades respectivas. 
//Luego de realizar la carga por teclado de todos los datos imprimir los nombres de las personas mayores de edad (mayores o iguales a 18 años), se tendrá que crear una clase "Persona" que contenga las propiedades "Nombre" y "Edad".
//Utilizar todos los componentes vistos hasta la fecha (bucles, funciones, clases).

<<<<<<< HEAD
=======
=======
//2- Desarrollar el ejercicio anterior, pero ahora al introducir el nombre, se especificara si es Alumno o Profesor, 
//con lo que se crearan 2 clases nuevas que Heredaran ambas de "Persona".
//Si es Alumno, se pedirá el numero de alumno, si es profesor, se pedirá la materia que imparte.
>>>>>>> 6361be0 (,NET)
>>>>>>> 5cb99e6 (NET)
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
<<<<<<< HEAD
=======
<<<<<<< HEAD
>>>>>>> 5cb99e6 (NET)



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

    

<<<<<<< HEAD
=======
=======
            ArrayList lista = new ArrayList(); 

            for (int i = 0; i < 3; i++)
            {

            
               WriteLine("Ingrese nombre y edad de la persona");
                  var Nombre = ReadLine();
                  var Edad = Convert.ToInt32(ReadLine());
          
            
                WriteLine("¿ Es profesor o alumno ?");
                  var Ocupacion = ReadLine(); 
               
                if (Ocupacion == "Profesor")

                {
                Profesor Profesor = new Profesor();
                WriteLine("Ingrese la materia que imparte");
                  var Materia = ReadLine();
                Profesor.Nombre = Nombre;
                Profesor.Edad = Edad;
                lista.Add(Profesor); 
                WriteLine(" " + Nombre + " es  " + Ocupacion + " de la materia " + Materia);
                ReadLine();

                 } 
               
               else
                {
                    Alumno alumno = new Alumno(); 
                   WriteLine("Ingrese numero del alumno");
                    var NumAlumno = Convert.ToInt32(ReadLine());
                    alumno.Nombre = Nombre;
                     alumno.Edad = Edad;
                  
                    lista.Add(alumno);
                    
                    WriteLine(" " + Nombre + " numero de alumno " + NumAlumno);
                ReadLine();
               }
                
              

            }



            for(int i = 0; i < 3; i++ )
            {

                WriteLine("Personas en la lista :"  + i);
                ReadLine();
            }


            // Falta que imprima las personas que estan emn la lista 
        }       
    }       
}

                

                


                  
                   
                
                

    
>>>>>>> 6361be0 (,NET)
>>>>>>> 5cb99e6 (NET)
