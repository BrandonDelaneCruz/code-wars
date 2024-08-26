using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars.Classes
{
    internal class TitleCaseQuestion
    {
        public static string TitleCase(string title, string minorWords = "")
        {
            List<string> stringToParse = title.Split(' ').ToList();
            List<string> minorWord = minorWords.Split(' ').ToList();
            List<string> wordsToReturn = new List<string>();

            foreach (string i in stringToParse)
            {
                string lowerI = i.ToLower();
                
                foreach (string j in minorWord)
                {
                    string lowerJ = j.ToLower();

                    if (lowerI != lowerJ)
                    {
                        List<char> charList = lowerI.ToCharArray().ToList();
                        charList[0] = Char.ToUpper(charList[0]);
                        char[] thisIsStupid = charList.ToArray();
                        string thisIsReallyStupid = new string(thisIsStupid);
                        wordsToReturn.Add(thisIsReallyStupid);
                    }
                    else
                    {
                        wordsToReturn.Add(i);
                    }
                }
            }


            string valueToReturn = string.Join(" ", stringToParse);
            Char.ToUpper(valueToReturn[0]);

             
            return valueToReturn;
        }
    }
}

