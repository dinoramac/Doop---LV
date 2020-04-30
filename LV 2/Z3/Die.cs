using System;
using System.Collections.Generic;
using System.Text;

namespace Z3
{
    //3. zadatak
    class Die
    {
        private int numberOfSides;
        private int lowerBound;
        private int upperBound;
        RandomGenerator random = RandomGenerator.GetInstance();

        public Die(int numberOfSides, int lowerBound, int upperBound)
        {
            this.numberOfSides = numberOfSides;
            this.random = random;
        }

        public int Roll()
        {
            int rolledNumber = random.NextInt(lowerBound, upperBound);
            return rolledNumber;
        }
    }
}
