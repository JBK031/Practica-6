using System;

namespace Programa_3
{
    class Program
    {
        /*3.Crear tres clases ClaseA, ClaseB, ClaseC que ClaseB herede de ClaseA y ClaseC herede de ClaseB. 
         * Definir un constructor a cada clase que muestre un mensaje. Luego definir un objeto de la clase ClaseC.
         */
       class ClaseA 
        {
        public ClaseA() 
            {
                Console.WriteLine("Clase");
            }
        }
        class ClaseB : ClaseA 
        { 
        public ClaseB()
            {
                ClaseA clasea = new ClaseA();

            }
        }
        class ClaseC : ClaseB 
        {
            ClaseB claseb = new ClaseB();
        }
        static void Main(string[] args)
        {
            ClaseC clase = new ClaseC();
            Console.ReadKey();
        }
    }
}
