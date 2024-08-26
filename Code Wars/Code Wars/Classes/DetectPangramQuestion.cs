using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars.Classes
{
    internal class DetectPangramQuestion
    {
        public static bool IsPangram(string str)
        {
            List<char> listOfCharacters = new List<char>
            {
                'a', 'b', 'c', 'd', 
                'e', 'f', 'g', 'h', 
                'i', 'j', 'k', 'l', 
                'm', 'n', 'o', 'p', 
                'q', 'r', 's', 't', 
                'u', 'v', 'w', 'x', 
                'y', 'z'
            };

            string newString = str.ToLower();

            List<char> listOfCharToParse = newString.ToCharArray().ToList();

            List<char> chars = listOfCharacters
                .Where(x => listOfCharToParse.Any(y => y == x)).ToList();
           
            if (chars.Count == 26)
            {
                return true;
            }
            else
                return false;

        }
    }
}
