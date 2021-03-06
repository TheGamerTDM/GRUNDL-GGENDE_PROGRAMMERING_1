using System;
using System.Collections.Generic;
using System.Text;

namespace GPOpgaver
{
    public static class Opgaver
    {
        /*
        * Introduktion til Algoritmer
        * Exercise 1. 
        * Describe an algorithm that interchanges the values of the variables x and y, using only assignment statements.
        * What is the minimum number of assignment statements needed to do so?
        */
        public static void Interchange(ref int x, ref int y)
        {
            //Write your solution here
            (x, y) = (y, x);
        }
        /*
        * Introduktion til Algoritmer
        * Exercise 2. 
        * 2.Describe an algorithm that uses only assignment statements to replace thevalues of the triple(x, y, z) with (z, x, y).
        * What is the minimum number of assignment statements needed?
        */
        public static void InterchangeTriple(ref int a, ref int b, ref int c)
        {
            //Write your solution here
            (a, b, c) = (c, a, b);
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 3.
         * A palindrome is a string that reads the same forward and backward.
         * Describe an algorithm for determining whether a string of n characters is a palindrome.
         */
        public static bool IsPalindrome(string s)
        {
            int i = 0;
            int j = s.Length - 1;
            while (true)
            {
                if (i > j)
                    return true;

                char x = s[i];
                char y = s[j];
                if (char.ToLower(x) != char.ToLower(y))
                    break;
                i++;
                j--;
            }
            return false;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.a.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4A
         */
        public static int StepsInLinearSearch(int searchFor, int[] intergerArray)
        {
            //Write your solution here
            for (int i = 0; i < intergerArray.Length; i++)
            {
                // Return i + 1 since we are counting the steps and the loop start at 0
                if (searchFor == intergerArray[i])
                    return i + 1;
            }
            return 0;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.b.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4B
         */
        public static int StepsInBinarySearch(int[] integerArray, int arrayStart, int arrayEnd, int searchFor)
        {
            if (arrayEnd >= arrayStart)
            {
                int middle = arrayStart + (arrayEnd - arrayStart) / 2;

                if (integerArray[middle] == searchFor)
                {
                    return 1;
                }

                if (integerArray[middle] > searchFor)
                {
                    return 1 + StepsInBinarySearch(integerArray, arrayStart, middle - 1, searchFor);
                }
                return 1 + StepsInBinarySearch(integerArray, middle + 1, arrayEnd, searchFor);
            }
            return -1;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 5.
         * Describe an algorithm based on the linear search for de-termining the correct position in which to insert a new element in an already sorted list.
         */
        public static int InsertSortedList(List<int> sortedList, int insert)
        {
            for (int i = 0; i < sortedList.Count; i++)
            {
                if (insert == sortedList[i])
                    throw new Exception("Cannot insert a value that already exists!");

                if (insert < sortedList[i + 1])
                {
                    // If the enumertation is on first loop we cant say i - 1 for check
                    if (i == 0)
                        continue;
                    if (insert > sortedList[i - 1])
                    {
                        // return pos + 1, since we want the space between the numbers
                        return i + 1;
                    }
                }
            }
            return 0;
        }
        /*
         * Exercise 6.
         * Arrays
         * Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.
         * Notice that num is also included in the returned array.
         */
        public static int[] ArrayOfMultiples(int num, int length)
        {
            int[] multiples = new int[length];

            for (int i = 0; i < length; i++)
            {
                Console.WriteLine(i);
                multiples[i] = num * (i + 1);
            }

            return multiples;
        }
        /*
         * Exercise 7.
         * Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range [a, b], inclusive.
         * Remember that the range is inclusive. a < b will always be true.
         */
        public static int PowerRanger(int power, int min, int max)
        {
            int count = 0;
            int index = 0;

            while (true)
            {
                index++;
                double result = Math.Pow(index, power);
                if (result > max) break;
                if (result < min) continue;
                Console.WriteLine($"{index}^{power}={Math.Pow(index, power)}");
                count++;


            }
            return count;
        }
        /*
         * Exercise 8.
         * Create a Fact method that receives a non-negative integer and returns the factorial of that number.
         * Consider that 0! = 1.
         * You should return a long data type number.
         * https://www.mathsisfun.com/numbers/factorial.html
         */
        public static long Factorial(int n)
        {
            if (n == 0)
                return 1;
            long result = n;
            for (int i = n - 1; i > 0; i--)
            {
                result *= i;
            }
            return result;
        }
        /*
         * Exercise 9.
         * Write a function which increments a string to create a new string.
         * If the string ends with a number, the number should be incremented by 1.
         * If the string doesn't end with a number, 1 should be added to the new string.
         * If the number has leading zeros, the amount of digits should be considered.
         */
        public static string IncrementString(string txt)
        {
            throw new NotImplementedException();
            //Write your solution here
        }
        /*
         * Exercise 10.
         * Write a method to validate a sercure password.
         *     The password must contain at least one uppercase character.
         *     The password must contain at least one lowercase character.
         *     The password must contain at least one number.
         *     The password must contain at least one special character ! @ # $ % ^ & * ( ) + = - { } [ ] : ; " ' ? < > , . _
         *     The password must be at least 8 characters in length.
         *     The password must not be over 25 characters in length.
         */
        public static bool ValidatePassword(string password)
        {
            throw new NotImplementedException();
            //Write your solution here
        }
    }
}