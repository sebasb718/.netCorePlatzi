using System;

namespace CoreEscuela
{
    class CoreEscuela
    {
        public string nombre;
        public string direccion;
        public int añoFundacion;
        public string CEO;
        public void Timbrar()
        {
            Console.Beep(2000,3000);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var miEscuela = new CoreEscuela();
            miEscuela.nombre = "Sebas Escuela";
            miEscuela.direccion = "calle falsa 123";
            miEscuela.añoFundacion = 1993;
            Console.WriteLine("Voy a timbrar");
            miEscuela.Timbrar();
            //Console.WriteLine("Hello World!");
        }
    }
}
