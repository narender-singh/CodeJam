using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam
{
    public static class OverSizedPancakeFlipper
    {
        public static int GetMinimumFlipsForPancakeRepresentation(string pr,int maxPancakeFlip)
        {
            int flips = 0;
            var charArray = pr.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i].Equals('+'))
                    continue;
                else if (i + maxPancakeFlip == charArray.Length && !CheckIfFlipPossible(ref charArray, maxPancakeFlip)) //end
                    return -1;
                Flip(ref charArray, i, maxPancakeFlip);
                flips++;
            }
            return flips;
        }

        private static bool CheckIfFlipPossible(ref char[] charArray,int maxPancakeFlip)
        {
            int location = charArray.Length - maxPancakeFlip;
            int oldIndex = location;
            while (location < oldIndex + maxPancakeFlip - 1)
            {
                if (charArray[location].Equals(charArray[location + 1]))
                    location++;
                else
                    return false;
            }
            return true;
        }

        public static void Flip(ref char[] cA, int index, int maxPancakeFlip)
        {
            int oldIndex = index;
            while (index < oldIndex + maxPancakeFlip)
            {
                if (cA[index].Equals('+'))
                    cA[index] = '-';
                else
                    cA[index] = '+';
                index++;
            }            
        }
    }
}
