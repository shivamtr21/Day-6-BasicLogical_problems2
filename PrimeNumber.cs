using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProblems
{
    public class PrimeNumber
    {
        public static void CheckPrimeOrNot()
        {
            Console.WriteLine("Please enter a number");
            int N = Convert.ToInt32(Console.ReadLine());



            for (int i = 2; i <= N; i++)
            {
                int count = 0;

                for (int j = 2; j < i; j++)
                {
                    if ((i % j) == 0)
                    {
                        count = 1;
                        break;

                    }
                }
                if (count == 1)
                {
                    Console.WriteLine(i + " is not prime number");
                }
                else
                {
                    Console.WriteLine(i + " is prime number");
                }
            }
        }
    }
}
