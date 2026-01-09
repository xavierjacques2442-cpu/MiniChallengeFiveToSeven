using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniChallengeFiveToSeven.Services
{
    public class NumberRevsers
    {
        public string ReverseNumber(string intput)
        {
            if  (string.IsNullOrEmpty(intput))
            return "Input is null or empty";
           
           if(!intput.All(char.IsDigit))
            return "Error: Input contains non-numeric characters";

         string resversed = new string(intput.Reverse().ToArray());
         return $"You entered {intput} and the reversed number is {resversed}";
        }
        
    }
}