using System;

namespace Z2
{
    class RandomGenerator
    {
        private static RandomGenerator instance;
        private Random generator;

        private RandomGenerator()
        {
            this.generator = new Random();
        }

        public static RandomGenerator GetInstance()
        {
            if (instance == null)
            {
                instance = new RandomGenerator();
            }

            return instance;
        }

        public double[][] Generate2DArray(int rows, int columns)
        {
            double[][] array2D = new double[rows][];

            for (int i = 0; i < rows; i++)
            {
                double[] row = new double[columns];
                array2D[i] = row;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    array2D[i][j] = generator.NextDouble();
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write(array2D[i][j].ToString("0.##\t"));
                }

                Console.WriteLine("\n");
            }

            return array2D;
        }
    }
}
