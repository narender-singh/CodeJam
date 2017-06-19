using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam
{
    class BathroomStalls
    {        
        static void Main(string[] args)
        {
            int T;
            T = int.Parse(Console.ReadLine());
            go(T);           
        }
        
        public static void go(int tn)
        {
            long n, k;
            n = int.Parse(Console.ReadLine());
            k = int.Parse(Console.ReadLine());
            long Z = g(n, k);
            Console.Write("Case #{1}: {2} {3}\n", tn, Z / 2, (Z - 1) / 2);
        }

        public static long g(long n, long k)
        {
            --k;
            long sz = n;
            long q0 = 1, q1 = 0;
            for (; ; )
            {
                if (k < q1) return sz + 1;
                k -= q1;
                if (k < q0) return sz;
                k -= q0;

                long p0 = 0, p1 = 0;
                if ((sz & 1) >= 1)
                {
                    sz /= 2;
                    p0 += q0 * 2;
                    p0 += q1;
                    p1 += q1;
                }
                else
                {
                    sz--; sz /= 2;
                    p0 += q0;
                    p1 += q0;
                    p1 += q1 * 2;
                }
                q0 = p0;
                q1 = p1;
            }
        }
    }
}




