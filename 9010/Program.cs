﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9010
{
    internal class Program
    {
        static void Main(string[] args)
        {
        }



        //1
        // param: positive number and a digit
        // return: true if number has digit
        // n=1537, 3 true
        // n=1567, 8 false
        public static bool hasDigit(int n, int m)
        {
            return false;
        }
        //2
        // param: 2 positive numbers
        // return: true if same length
        // n=1537, 4882 true
        // n=1567, 56 false
        public static bool isSameLength(int n, int m)
        {
            return false;

        }
        //3
        // param: positive number
        // return: true if Digits Descending Order
        // n=97532 true
        // n=96482 false
        // n=97533 false 
        public static bool isDigitsDescendingOrder(int n)
        {
            return false;

        }
        //4
        // param: positive number n and 2 digit number m
        // return: m is not in n
        // n=456787 m=56 false
        // n=456787 m=47 true
        public static bool noNumInside(int n, int m)
        {
            return false;

        }
        //5
        // param: positive number
        // return: n is 2power (2,4,8,16....)
        // n=1024 true
        // n=1025 false
        public static bool is2power(int n)
        {
            return false;

        }


        //6
        // param: 2 positive numbers
        // return: n is divided by m
        // use only +/-
        // n=8 m=2 true
        // n=8 m=3 false
        public static bool isDivided(int n, int m)
        {
            if (n == 0) return true;
            if (n < m) return false;
            return isDivided((n - m), m);
        }
        //7
        // param: positive number
        // return: sum digits in odd places == sum digits in even places
        // n = 12364 return true (1+3+4 == 2+6)
        //note - The divisibility by 11 rule states that if the difference between the sum of the digits at odd
        //places and the sum of the digits at even places of the number, is 0 or divisible by 11
        //then the given number is also divisible by 11.
        public static bool divisibleBy11(int num)
        {
            return alternatingDigitsSum(num) == alternatingDigitsSum(num / 10);
        }
        private static int alternatingDigitsSum(int num) //return sum of odd-indexed digits
        {
            if (num == 0) return 0;
            return num % 10 + alternatingDigitsSum(num / 100);
        }

        //8
        // param: positive number
        // return: true n is prime number
        // n=7, 29 true
        // n=1568 false
        public static bool isPrime(int n) // handle base cases
        {
            int sqrt = (int)Math.Sqrt(n);
            return isPrime(n, sqrt);
        }

        public static bool isPrime(int n, int m)
        {
            if (m == 1) return true; //didn't find divisor, so prime
            if (n % m == 0) return false; //did find divisor
            return isPrime(n, m - 1); //make the divisor smaller by one

        }
        //9
        // param: positive number
        // return: true if number includes even digit
        // n = 145731 true
        // n=1351  false        
        static bool ExistEven(int n)
        {
            if (n == 0) return false;
            if (n % 2 == 0) return true;
            return ExistEven(n / 10);

        }

        //10
        // param: positive number
        // return: true if all digits are even
        // n = 145731 false
        // n=1351  true  
        static bool AllEven(int n)
        {
            if (n == 0) return true;
            if (n % 2 != 0) return false;
            return AllEven(n / 10);
        }
    }

}

