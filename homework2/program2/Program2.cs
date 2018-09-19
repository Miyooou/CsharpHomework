using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program2
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 2, 4, 3, 6, 5 };
            for(int i=0;i<5;i++)
            {
                if(numbers[i]>numbers[i+1])
                {
                    int j = numbers[i + 1];
                    numbers[i + 1] = numbers[i];
                    numbers[i] = j;
                }
            }
            Console.Write("最大值为" + numbers[5]);
            for (int i = 0; i < 5; i++)
            {
                if (numbers[i] < numbers[i + 1])
                {
                    int j = numbers[i + 1];
                    numbers[i + 1] = numbers[i];
                    numbers[i] = j;
                }
            }
            Console.Write("最小值为" + numbers[5]);
            double a;
            a = numbers[0] + numbers[1] + numbers[2] + numbers[3] + numbers[4] + numbers[5];
            double b;
            b = a / 6;
            Console.Write("平均值为" + b);
            Console.Write("和为" + a);
        }
    }
}
