using System;

namespace Pelicula
{
    //Navarrete Silva Luis Gerardo
    //Poo
    class Program
    {
        class Pelicula
        {
            private string titulo, pais, director;
            private Int16 año;

            public void SetTitulo(string titulo)
            {
                this.titulo=titulo;
            }
            public string GetTitulo()
            {
                return this.titulo;
            }
            public void SetAño(Int16 año)
            {
                this.año=año;
            }
            public Int16 GetAño()
            {
                return this.año;
            }
            public void SetPais(string pais)
            {
                this.pais=pais;
            }
            public string GetPais()
            {
                return this.pais;
            }
            public void SetDirector(string director)
            {
                this.director=director;
            }
            public string GetDirector()
            {
                return this.director;
            }
            public Pelicula(string titulo, Int16 año, string pais, string director)
            {
                this.titulo=titulo;
                this.año=año;
                this.pais=pais;
                this.director=director;
            }

            static void Main(string[] args)
            {
                Pelicula p1 = new Pelicula(titulo);
                p1.SetTitulo("La La Land");
                p1.SetAño(2016);
                p1.SetPais("USA");
                p1.SetDirector("Damien Chazelle");
                Console.WriteLine("{0},{1},{2},{3}",p1.GetTitulo(),p1.GetAño(),p1.GetPais(),p1.GetDirector());
                
                Pelicula p2 = new Pelicula(titulo);
                p2.SetTitulo("La forma del agua");
                p2.SetAño(2017);
                p2.SetPais("USA");
                p2.SetDirector("Guillermo del toro");
                Console.WriteLine("{0},{1},{2},{3}",p2.GetTitulo(),p2.GetAño(),p2.GetPais(),p2.GetDirector());
            }
        }
    }
}
