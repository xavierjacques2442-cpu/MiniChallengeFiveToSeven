using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFiveToSeven.Services
{
    public class RevsersIt
    {
        public string ReverseTheString(string input)
        {
            if (string.IsNullOrEmpty(input))
            {
                return "Input string is null or empty.";
            }
            else
            {
            string reversed = new string(input.Reverse().ToArray());
            return $"You entered: {input}. Reversed: {reversed}";
            }
        }
    }
}