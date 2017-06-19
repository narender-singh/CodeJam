using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam
{
    class SnakeProgression
    {
        public static void GetValidInValid(string inputString)
        {
            char start = 'H', end = 'T';                        
            var array = inputString.ToCharArray();
            int startPos = 0, endPos = array.Length - 1;
            bool isfailed = false;
            for (int i = 0; i <= array.Length/2; startPos++, endPos--, i++)
            {
                if (array[startPos] == '.' || array[endPos] == '.')
                    continue;
                if (array[startPos] == start)
                    start = start == 'H' ? 'T' : 'H';
                else
                    isfailed = true;
                if (array[endPos] == end)
                    end = end == 'H' ? 'T' : 'H';
                else
                    isfailed = true;
            }
            if (isfailed)
                Console.WriteLine("Invalid");
            else
                Console.WriteLine("Valid");

        }
    }
}
