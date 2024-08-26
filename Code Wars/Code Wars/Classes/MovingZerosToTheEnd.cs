using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Wars.Classes
{
    internal class MovingZerosToTheEnd
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> nonZero = arr.Where(x => x != 0).ToList();
            List<int> zero = arr.Where(x => x == 0).ToList();
            nonZero.AddRange(zero);

            int[] numbersToReturn = nonZero.ToArray();

            return numbersToReturn;
        }
    }
}
