using System;

namespace Pelicula
{
    class Program
    {
        class Pelicula
        {
            public string titulo, pais, director;
            public int año;

            public void Imprimir()
            {
                Console.WriteLine("La La Land");
                Console.WriteLine(2016);
                Console.WriteLine("La forma del agua");
                Console.WriteLine(2017);
            }


            static void Main(string[] args)
            {
                Pelicula p1 = new Pelicula();
                p1.Imprimir();
                Pelicula p2 = new Pelicula();
            }
        }
    }
}
