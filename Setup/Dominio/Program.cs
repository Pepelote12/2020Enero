using System;

namespace Dominio
{
    class Dominio
    {
        int Espacio1, Espacion2;
        public static void suma(ref int x, ref int y)
        {
            z=x+y;
        }
        static void Main(string[] args)
        {
            int x= 10; int y=12;
            Dominio.suma(ref x, ref y)
            Console.WriteLine(z);
        }
    }
}
