
using System;

namespace Z2
{
    class Program
    {
        static void Main(string[] args)
        {
            RandomGenerator generator = RandomGenerator.GetInstance();
            double[][] arr0 = generator.Generate2DArray(2, 3);
            double[][] arr1 = generator.Generate2DArray(3, 6);
        }
        // instancira i generira višedimenzionalno polje
    }
}
