using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program3
{
    class Program3
    {
        static void Main(string[] args)
        {
            int i, j;
            for (i=2; i <= 100; i++) 
            {
                for (j = 2; j < i; j++)
                
                    if (i % j == 0)
                    {
                        break;
                    }

                    if (j == i)
                    {
                      
                        Console.WriteLine( j + "是素数");
                    }
                
            }
          
        }
    }
}
