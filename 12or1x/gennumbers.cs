using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StaticRandom;
using Verhoeff;
using Wintellect.PowerCollections;
using ThreadLocalCryptoRandom;

namespace _12or1x
{
    public class gennumbers
    {
        public static string genMyDigits()
        {
            var numbers = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next().ToString();
            var generatedVerhoeff = Verhoeff.VerhoeffChecker.generateVerhoeff(numbers);
            //Console.WriteLine(numbers);
            int x = Convert.ToInt32(generatedVerhoeff);
            if (x%2 == 0)
            {
                return "even";
            }
            else
            {
                return "odd";
            }
            //return  generatedVerhoeff;
        }

        public static string genCheckedDigits()
        {
            var numbers = gen11Digits();
            var generatedVerhoeff = Verhoeff.VerhoeffChecker.generateVerhoeff(numbers);
            //Console.WriteLine(numbers);
            return numbers + generatedVerhoeff;
        }

        public static string gen11Digits()
        {
            var d1 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9).ToString();
            var d2 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9);
            var d3 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9);
            var d4 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9);
            var d5 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9);
            var d6 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9);
            var d7 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9);
            var d8 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9);
            var d9 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9);
            var d10 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9);
            var d11 = ThreadLocalCryptoRandom.ThreadLocalCryptoRandom.Next(0, 9);

            return d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10 + d11;
        }
    }
}