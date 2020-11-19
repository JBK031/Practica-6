using System;

namespace Programa_2
{
    /*2.Crear una clase Contacto. Esta clase deberá tener los atributos "nombre, apellidos, telefono y direccion". 
     * También deberá tener un método "SetContacto", de tipo void y con los parámetros string, que permita cambiar el valor de los atributos. 
     * También tendrá un método "Saludar", que escribirá en pantalla "Hola, soy " seguido de sus datos. 
     * Crear también una clase llamada ProbarContacto. 
     * Esta clase deberá contener sólo la función Main, que creará dos objetos de tipo Contacto, 
     * les asignará los datos del contacto y les pedirá que saluden.
     */
    class Contacto
    {
        private string nombre;
        private string apellido;
        private long telefono;
        private string direccion;

        public Contacto()
        {
            Console.WriteLine("Introducir el nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine("Introducir el apellido: ");
            apellido = Console.ReadLine();
            Console.WriteLine("Introducir el numero de telefono: ");
            telefono = long.Parse(Console.ReadLine());
            Console.WriteLine("Introducir la direccion: ");
            direccion = Console.ReadLine();
        }
   
        public void  Saludar() 
        {
            Console.WriteLine("Hola, soy "+nombre +"" +apellido+" Mi numero de telefono es "+telefono+" La direccion es "+direccion);
        }
    }
    class ProbarContacto
    {
        static void Main(string[] args)
        {
            Contacto contacto = new Contacto();
            contacto.Saludar();
        }
    }
}
