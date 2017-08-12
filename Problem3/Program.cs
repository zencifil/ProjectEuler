/*
 * 
 * The prime factors of 13195 are 5, 7, 13 and 29.
 * What is the largest prime factor of the number 600851475143 ?
 * 
 */

using System;

namespace Problem3 {
    public class Program {
        static void Main(string[] args) {
            var result = LargestPrimeFactor(600851475143);
            Console.WriteLine(result);
            Console.ReadLine();
        }

        public static bool IsPrime(int number) {
            var sqrt = Math.Ceiling(Math.Sqrt(number));
            for (var i = 2; i < sqrt; i++) {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        public static int LargestPrimeFactor(long number) {
            var sqrt = Math.Ceiling(Math.Sqrt(number));
            var retVal = -1;
            for (var i = 2; i < sqrt; i++) {
                if (number % i == 0 && IsPrime(i)) {
                    retVal = i > retVal ? i : retVal;
                }
            }
            return retVal;
        }
    }
}
