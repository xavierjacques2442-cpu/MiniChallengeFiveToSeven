using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFiveToSeven.Services
{
    public class OddOrEven
    {
        public string IsOdd(int number)
        {
            if (number % 2 != 0)
            {
                return $"{number} is odd.";
            }
            else
            {
                return $"{number} is even.";
            }
        }
        
    }
}