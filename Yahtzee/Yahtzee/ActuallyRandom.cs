using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public class ActuallyRandom : IRandom
    {
        private Random random;

        public ActuallyRandom()
        {
            random = new Random();
        }
        public int Next(int lowerBound, int upperBOund)
        {
            return random.Next(lowerBound, upperBOund);
        }
    }
}
