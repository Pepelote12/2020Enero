using System;

namespace Pelicula
{
    class Program
    {
        class Pelicula
        {
            public string titulo, pais, director;
            public Int16 año;


            static void Main(string[] args)
            {
                Pelicula p1 = new Pelicula();
                Console.WriteLine("La La Land, 2016");
                
                Pelicula p2 = new Pelicula();
                Console.WriteLine("La forma del agua, 2017");
            }
        }
    }
}
