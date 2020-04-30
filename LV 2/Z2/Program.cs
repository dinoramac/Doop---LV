using System;

namespace Z2
{
    //2. zadatak
    class Program
    {

        static void Main(string[] args)
        {
            DiceRoller diceRoller = new DiceRoller();
            Random randomGenerator = new Random();

            Console.Write("Unesite broj stranica kockica: ");
            int numberOfSides = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Uneseni broj stranica kockica je " + numberOfSides);

            Die[] die = new Die[20];
            for (int i = 0; i < 20; i++)
            {
                die[i] = new Die(numberOfSides, randomGenerator);
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
