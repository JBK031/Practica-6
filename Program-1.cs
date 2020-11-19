using System;

namespace Programa_1
{
    /*Crear una clase Persona que tenga como atributos el "cedula, nombre, apellido y la edad 
     * (definir las propiedades para poder acceder a dichos atributos)". Definir como responsabilidad un método para mostrar ó imprimir. 
     * Crear una segunda clase Profesor que herede de la clase Persona. Añadir un atributo sueldo ( y su propiedad) 
     * y el método para imprimir su sueldo. 
     * Definir un objeto de la clase Persona y llamar a sus métodos y propiedades. 
     *También crear un objeto de la clase Profesor y llamar a sus métodos y propiedades. 
     */
    class Persona
    {
        private long cedula;
        private string nombre;
        private string apellido;
        private int edad;

        public Persona()
        {
            Console.WriteLine("Introducir la cedula:");
            cedula = long.Parse(Console.ReadLine());
            Console.WriteLine("Introducir su nombre:");
            nombre = Console.ReadLine();
            Console.WriteLine("Poner su apellido:");
            apellido = Console.ReadLine();
            Console.WriteLine("Poner su edad:");
            edad = int.Parse(Console.ReadLine());
        }

        public void Mostrar() 
        {
            Console.WriteLine("Su cedula es: " + cedula);
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su apellido es: " + apellido);
            Console.WriteLine("Su edad es: " + edad);
        }
    }

    class Profesor 
    {
        private int sueldo;

        public Profesor() 
        {
           

            Console.WriteLine("Introducir su sueldo:");
            sueldo = int.Parse(Console.ReadLine());
        }

        public void imprimir() 
        {
            
            Console.WriteLine("Tiene un sueldo de: RD$"+sueldo);
        }
    }


        class Program
        {
            static void Main(string[] args)
            {
            Persona persona = new Persona();
            persona.Mostrar();
            Profesor profesor = new Profesor();
            profesor.imprimir();
            }
        }
    }
    
