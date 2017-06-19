using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeJam
{
    public static class SavePoision
    {
        static List<Tuple<int,int,int,int>> Snakes;
        static int max = 0;

        public static Tuple<int,int,int> FindMaxAreaCoveredAndReturnRemainingColumn(Tuple<int,int,int> data)
        {
            Tuple<int, int> remaining = new Tuple<int,int>(data.Item1,data.Item2);
            for(int i =0; i<max;i++)
            {
                foreach (var item in Snakes.Where(s => s.Item1 == i))
                {
                    if (item.Item2 <= remaining.Item1 && item.Item4 >= remaining
                        .Item1)
                    {
                        
                    }
                } 
                
            }
        }
    }
}
