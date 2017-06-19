using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam
{
    public static class TidyNumbers
    {
        public static int[] SplitIt(long no)
        {
            int[] arr = new int[no.ToString().ToCharArray().Length];
            int i = 0;
            long current;
            while(no > 0)
            {
                current = no % 10;
                no /= 10;
                arr[i] = (int)current;
                i++;
            }
            return arr;
        }

        public static long GetLastLargestTidyNumber(long no)
        {
            //int previous = 0,current =0;
            long newNumber = 0;
            bool addZero = false;
            //while(no > 0)
            //{
            //    newNumber *= 10;
            //    current = no % 10;
            //    no /= 10;
            //    if (current <= previous || addZero)
            //    {
            //        addZero = true;
            //        continue;
            //    }
            //    previous = current;
            //    newNumber += current;
            //}
            //return newNumber - 1;
            var arr = SplitIt(no);
            
            for (int i = arr.Length - 1; i >= 0; i--)
            {
                newNumber *= 10;
                if (addZero)
                    continue;
                newNumber += arr[i];
                if (i < arr.Length - 1 && arr[i] >= arr[i - 1])
                {                
                    addZero = true;
                    continue;
                }
            }
            return newNumber - 1;

        }
    }
}
