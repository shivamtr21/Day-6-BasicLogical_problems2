using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProblems
{
    public class CupanNumber
    {
        public static void Couponnumbers()
        {
            Console.WriteLine("Enter the length of the coupon number:");
            int length = int.Parse(Console.ReadLine());

            string couponNumber = GenerateCouponNumber(length);

            Console.WriteLine("Coupon number: " + couponNumber);

        }

        static string GenerateCouponNumber(int length)
        {
            Random random = new Random();
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());

        }
    }
}
