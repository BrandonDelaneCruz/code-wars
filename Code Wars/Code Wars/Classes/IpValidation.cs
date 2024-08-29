using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Code_Wars.Classes
{
    internal class IpValidation
    {
        public static bool IsValidIp(string ipAddres)
        {
            List<string> listOfInt = ipAddres.Split('.').ToList();
            bool toReturn = false;

            if (listOfInt.Count == 4)
            {
                toReturn = !listOfInt.Any(x => x.StartsWith("0"));
            }
            else
            {
                toReturn = false;
            }

            return toReturn;
        }
    }
}


// 10 % 2 = 0
// 11 % 2 = 1
// 12 % 2 = 0
