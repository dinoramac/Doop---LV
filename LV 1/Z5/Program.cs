using System;

namespace Z5
{
    class Program
    {
        //5. Zadatak
        static void Main(string[] args)
        {
            //1. zabiljeska
            Console.WriteLine("1. Zabiljeska");
            Zabiljeska zabiljeska1 = new Zabiljeska();
            Console.WriteLine(zabiljeska1.ToString());
            Console.Write("\n");


            //================4. Zadatak==================
            Console.WriteLine("Unesite tekst: ");
            string tekst = Console.ReadLine();
            zabiljeska1.Tekst = tekst;
            Console.WriteLine(zabiljeska1.Tekst);
            Console.Write("\n");

            //Neradi zbog -> Private
            //Console.WriteLine("Unesite autora: ");
            //string autor = Console.ReadLine();
            //zabiljeska1.Autor = autor;
            //Console.Write("\n");
            //Console.WriteLine(zabiljeska1.autor);
            //Console.Write("\n");


            Console.WriteLine("Unesite vaznost: ");
            int vaznost = Convert.ToInt32(Console.ReadLine());
            zabiljeska1.Vaznost = vaznost;
            Console.Write("\n");
            Console.WriteLine(zabiljeska1.Vaznost);
            Console.Write("\n");


            //================5. Zadatak==================

            //2. zabiljeska
            Console.WriteLine("2. Zabiljeska");
            Zabiljeska zabiljeska2 = new Zabiljeska("Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.", "Albert Einstein", 1);
            Console.WriteLine(zabiljeska2.ToString());
            Console.Write("\n");

            //3. zabiljeska
            Console.WriteLine("3. Zabiljeska");
            Zabiljeska zabiljeska3 = new Zabiljeska("A man who dares to waste one hour of time has not discovered the value of life.", "Charles Darwin");
            Console.WriteLine(zabiljeska3.ToString());
            Console.Write("\n");
        }
    }
}
