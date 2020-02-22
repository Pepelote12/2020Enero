using System;

namespace Pelicula
{
    class Program
    {
        class Pelicula
        {
            private string titulo, pais, director;
            private Int16 año;

            //public void Imprimir()
            //{
            //    Console.WriteLine("La La Land");
            //    Console.WriteLine(2016);
            //    Console.WriteLine("La forma del agua");
            //    Console.WriteLine(2017);
            //}

            public void SetTitulo(string titulo)
            {
                this.titulo=titulo;
            }
            public void SetAño(Int16 año)
            {
                this.año=año;
            }
            public string GetTitulo()
            {
                return this.titulo;
            }

            public Int16 GetAño()
            {
                return this.año;
            }

            static void Main(string[] args)
            {
                Pelicula p1 = new Pelicula();
                p1.SetTitulo("La La Land");
                p1.SetAño(2016);
                Console.WriteLine("{0},{1}",p1.GetTitulo(), p1.GetAño());
                
                Pelicula p2 = new Pelicula();
                p2.SetTitulo("La forma del agua");
                p2.SetAño(2017);
                Console.WriteLine("{0},{1}",p2.GetTitulo(), p2.GetAño());
            }
        }
    }
}
