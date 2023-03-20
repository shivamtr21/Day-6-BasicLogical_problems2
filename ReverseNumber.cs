using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProblems
{
    public class ReverseNumber
    {
        public static void NumberReverse()
        {
            int rem;
            int reverse = 0;
             

            Console.WriteLine("Enter your number");
            int N = Convert.ToInt32(Console.ReadLine());

            
             while(N != 0)
            {
                rem = N % 10;


                reverse = reverse * 10 + rem;
                N = N / 10;

               

            }
             

             
            Console.WriteLine("Reverse num = " + reverse);
        }
    }
}
