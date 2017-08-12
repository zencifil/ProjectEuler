/*
 * 
 * If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.
 * Find the sum of all the multiples of 3 or 5 below 1000.
 * 
 */

using System;

namespace Problem1 {
    public static class Program {
        static void Main(string[] args) {
            var limit = 999;
            var sum = SumOfIntegers(limit);
            Console.WriteLine("Sum is " + sum);
            Console.ReadLine();
        }

        public static int SumOfIntegers(int limit) {
            var sum = 0;
            for (var i = 1; i <= limit; i++) {
                if (IsDivisibleBy3(i) || IsDivisibleBy5(i))
                    sum += i;
            }

            return sum;
        }

        public static bool IsDivisibleBy3(int number) {
            return number % 3 == 0;
        }

        public static bool IsDivisibleBy5(int number) {
            return number % 5 == 0;
        }
    }
}
