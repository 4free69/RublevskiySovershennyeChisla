using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rublevskiy.SovershennyeChisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            int sum = 0;
            while(i <= 2)
            {
                for(int x = 2; ; x++)
                {
                    for (int y = x - 1; y >= 1; y--)
                    {
                        if (x % y == 0)
                            sum = sum + y;
                        continue;
                    }
                    if(sum == x)
                    {
                        Console.Write(x + ",");
                        i++;
                    }
                    sum = 0;
                }
            }
            Console.ReadKey();
        }
    }
}
