using System;
using System.Collections.Generic;

namespace lista_de_pelicula
{
    class Program
    {
        class Pelicula
        {
            //Navarrete Silva Luis Gerardo
            //Cd Setup, Cd l_pelicula, Cd lista_de pelicula
            public string titulo;
            public void Imprime()
            {
                Console.WriteLine(titulo);
            }
            public Pelicula(string t)
            {
                titulo=t;
            }

        }
        static void Main(string[] args)
        {
            List<Pelicula> Peli = new List<Pelicula>();
            Peli.Add(new Pelicula("La La Land"));
            Peli.Add(new Pelicula("La forma del agua"));
            Peli.Add(new Pelicula("Birdman"));
            Peli.Add(new Pelicula("El artista"));
            Peli.Add(new Pelicula("EL padrino"));

            foreach (Pelicula a in Peli)
            {
                a.Imprime();
            }
        }
    }
}
