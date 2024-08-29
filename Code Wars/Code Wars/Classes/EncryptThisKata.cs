using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars.Classes
{
    public class EncryptThisKata
    {
        public static string EncryptThis(string input)
        {
            List<string> inputSplit = input.Split(' ').ToList();
            List<string> strings = new List<string>();

            foreach (string s in inputSplit) 
            {
                string[] stringToConvertArray = s.ToCharArray().Select(c => c.ToString()).ToArray();

                List<string> newStr = new List<string>();

                for (int i = 0; i < stringToConvertArray.Length; i++)
                {
                    if (i == 0)
                    {
                        int firstChar = s.First();
                        newStr.Add(firstChar.ToString());
                    }
                    else if (i == 1)
                    {
                        string strForSecond = s.Last().ToString();
                        newStr.Add(strForSecond);
                    }
                    else if (i == stringToConvertArray.Length - 1)
                    {
                        string finalStr = stringToConvertArray[1].ToString();
                        newStr.Add(finalStr);
                    }
                    else
                    {
                        string otherStr = stringToConvertArray[i];
                        newStr.Add(otherStr);
                    }

                }

                string combinedString = string.Join("", newStr);
                strings.Add(combinedString);
            }

            string combinedStrings = string.Join(" ", strings);

            return combinedStrings;
        }
    }
}
