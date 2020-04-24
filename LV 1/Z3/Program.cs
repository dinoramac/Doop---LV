using System;

namespace Z3
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. zabiljeska
            Console.WriteLine("1. Zabiljeska");
            Zabiljeska zabiljeska1 = new Zabiljeska();
            Console.WriteLine(zabiljeska1.getTekst());
            Console.WriteLine(zabiljeska1.getAutor());
            Console.WriteLine(zabiljeska1.getVaznost());
            Console.Write("\n");
            Console.WriteLine("Unesite tekst: ");
            string tekst = Console.ReadLine();
            zabiljeska1.setTekst(tekst);
            Console.WriteLine(zabiljeska1.getTekst());
            Console.Write("\n");

            //2. zabiljeska
            Console.WriteLine("2. Zabiljeska");
            Zabiljeska zabiljeska2 = new Zabiljeska("Two things are infinite: the universe and human stupidity; and I'm not sure about the universe.", "Albert Einstein", 1);
            Console.WriteLine(zabiljeska2.getTekst());
            Console.WriteLine(zabiljeska2.getAutor());
            Console.WriteLine(zabiljeska2.getVaznost());
            Console.Write("\n");

            //3. zabiljeska
            Console.WriteLine("3. Zabiljeska");
            Zabiljeska zabiljeska3 = new Zabiljeska("A man who dares to waste one hour of time has not discovered the value of life.", "Charles Darwin");
            Console.WriteLine(zabiljeska3.getTekst());
            Console.WriteLine(zabiljeska3.getAutor());
            Console.WriteLine(zabiljeska3.getVaznost());
            Console.Write("\n");
        }
    }
}
