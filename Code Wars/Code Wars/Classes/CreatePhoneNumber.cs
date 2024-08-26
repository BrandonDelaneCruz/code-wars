using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars.Classes
{
    internal class CreatePhoneNumber
    {
        public static string PhoneNumber(int[] numbers)
        {
            return $"({string.Join("", numbers.Take(3))}) {string.Join("", numbers.Skip(3).Take(3))}-{string.Join("", numbers.Skip(6).Take(4))}";
        }
    }
}
