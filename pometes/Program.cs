using System;
using System.Globalization;
namespace Pometes
{
    public class EjPometes
    {
        public static void Main()
        {
            const string MsgPometes = "Quantes pometes té el pomer?: ";
            int numPometes;
            Console.WriteLine(MsgPometes);
            numPometes  =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(caigudaPometes(numPometes));
            

        }
        public static int caigudaPometes (int numPometes)
        {
            if (numPometes == 0)
            {
                return 1;
            }
            else
            {
                Console.WriteLine($"{numPometes} pometes té el pomer\r\nde {numPometes} una de {numPometes} una\r\n{numPometes} pometes té el pomer\r\nde {numPometes} una se'n caigué");
                Console.WriteLine();
                return caigudaPometes(numPometes - 1);
            }
        }
    }
}