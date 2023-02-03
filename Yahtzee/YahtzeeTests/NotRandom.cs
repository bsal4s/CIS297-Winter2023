using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Yahtzee;

namespace YahtzeeTests
{
    internal class NotRandom : IRandom
    {
        private List<int> numbers;
        private int currentIndex;

        public NotRandom(List<int> numbers)
        {
            this.numbers = numbers;
            currentIndex = 0;
        }
        public int Next(int lowerBound, int upperBOund)
        {
            int number = numbers[currentIndex];
            currentIndex++;
            return number;
        }
    }
}
