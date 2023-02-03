using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yahtzee
{
    public interface IRandom
    {
        int Next(int lowerBound, int upperBOund);
    }
}
