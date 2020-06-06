using System;
using System.Collections.Generic;

namespace Z1
{
    class Program
    {
        // ako cemo mjenjati vrijednosti objekta potreban je deepclone, jer shallowclone samo referencira vrijednosti originalnog objekta
        static void Main(string[] args)
        {
            Dataset values = new Dataset("D:\\values.csv");
            Dataset valuesShallowCopy = (Dataset)values.ShallowClone();
            Dataset valuesDeepCopy = (Dataset)values.DeepClone();


            Console.WriteLine("Prije promjene");
            Console.WriteLine("\n");

            values.PrintData();
            Console.WriteLine("\n");
            valuesShallowCopy.PrintData();
            Console.WriteLine("\n");
            valuesDeepCopy.PrintData();

            Console.WriteLine("\n");
            Console.WriteLine("===============================");
            Console.WriteLine("Poslije promjene");
            Console.WriteLine("\n");

            values.AddData();

            values.PrintData();
            Console.WriteLine("\n");
            valuesShallowCopy.PrintData();
            Console.WriteLine("\n");
            valuesDeepCopy.PrintData();
        }
    }
}
