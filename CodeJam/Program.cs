using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam
{
    class Program
    {
        static void Main(string[] args)
        {
            TidyNumbersProblem();
            //OverSizedPancakeFlipperProblem();
        }

        public static void TidyNumbersProblem()
        {
            Console.Write("\n Enter the No : ");
            var k = long.Parse(Console.ReadLine());
            var res = TidyNumbers.GetLastLargestTidyNumber(k);
            Console.Write("\n TestCase #1 : " + res);
            Console.ReadLine();
        }

        public static void OverSizedPancakeFlipperProblem()
        {
            Console.Write("\n Enter the string : ");
            var s = Console.ReadLine();
            Console.Write("\n Enter the Flipper size : ");
            var k = int.Parse(Console.ReadLine());
            var res = OverSizedPancakeFlipper.GetMinimumFlipsForPancakeRepresentation(s, k);
            Console.Write("Testcase #1 : " + (res >= 0 ? res.ToString() : "IMPOSSIBLE"));
            Console.ReadLine();
        }
    }
}
