using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program1
    {
        static void Main(string[] args)
        {
            int number,i=2,j=2;
            Console.Write("Input a number:");
            string s;
            s = Console.ReadLine();
            number = int.Parse(s);
            while (number > 1)
            {
                for ( ; j <= number; j++)
                {
                   
                   if (number%j==0)
                    {
                        int k = 0;
                      
                        for (i=2 ;i<j&&j>2;i++)
                    {
                            if (j % i == 0)
                            {
                                k = k + 1;
                            
                                
                            }
                           
                    }
                        if (k == 0)
                        {
                            Console.WriteLine(j);
                        
                          
                        }
                        k = 0;
                    }


                }
           

                    }
        }
    }
}
