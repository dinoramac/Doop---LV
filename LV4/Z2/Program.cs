using System;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            Analyzer3rdParty party = new Analyzer3rdParty();
            Adapter adapter = new Adapter(party);

            Dataset listsInList = new Dataset();
            listsInList.LoadDataFromCSV("D:\\Github\\Doop---LV\\LV4\\Z2\\values.csv");

            double[] rowAverage = adapter.CalculateAveragePerRow(listsInList);
            double[] columnAverage = adapter.CalculateAveragePerColumn(listsInList);

            Console.WriteLine("Avg row: ");
            foreach (var item in rowAverage)
            {
                Console.WriteLine(item.ToString());
            }

            Console.Write("\n");
            Console.WriteLine("Avg column: ");
            foreach (var item in columnAverage)
            {
                Console.WriteLine(item.ToString());
            }
            Console.Write("\n");
        }
    }
}
