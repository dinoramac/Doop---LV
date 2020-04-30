using System;

namespace Z3
{
    //3. zadatak
    class Program
    {

        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();

            Console.Write("Unesite broj stranica kockica: ");
            int numberOfSides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uneseni broj stranica kockica je " + numberOfSides);

            int lowerBound = 10;
            int upperBound = 20;

            Die[] die = new Die[20];
            for (int i = 0; i < 20; i++)
            {
                die[i] = new Die(numberOfSides, lowerBound, upperBound);
                diceRoller.InsertDie(die[i]);
            }

            diceRoller.RollAllDice();

            foreach (int i in diceRoller.GetRollingResults())
            {
                Console.WriteLine(i);
            }

            //Console.Write("Broj kockica: ");
            //Console.WriteLine(diceRoller.DiceCount);

        }
    }
}
