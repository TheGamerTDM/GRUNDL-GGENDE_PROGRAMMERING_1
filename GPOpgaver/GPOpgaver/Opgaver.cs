using System;
using System.Collections.Generic;
using System.Text;

namespace GPOPgaver
{
    public static class Opgaver
    {
        /*
        * Introduktion til Algoritmer
        * Exercise 1. 
        * Describe an algorithm that interchanges the values of the variables x and y, using only assignment statements.
        * What is the minimum number of assignment statements needed to do so?
        */
        /// <summary>
        /// We need to change x and y with each other. X = Y and Y = X
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        public static void Interchange(ref int x, ref int y)
        {
            int tempx = x;

            x = y;

            y = tempx;
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
            int tempa = a;
            int tempb = b;

            a = c;
            b = tempa;
            c = tempb;
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 3.
         * A palindrome is a string that reads the same forward and backward.
         * Describe an algorithm for determining whether a string of n characters is a palindrome.
         */
        public static bool IsPalindrome(string s)
        {
            //Write your solution here
            int min = 0;
            int max = s.Length - 1;
            while (true)
            {
                if (min > max)
                {
                    return true;
                }
                char a = s[min];
                char b = s[max];
                if (char.ToLower(a) != char.ToLower(b))
                {
                    return false;
                }
                min++;
                max--;
            }
        }
        /*
         * Introduktion til Algoritmer
         * Exercise 4.a.
         * List all the steps used to search for 9 in the sequence 1, 3, 4, 5, 6, 8, 9, 11
         * Do this by completing the unit test for 4A
         */
        public static int StepsInLinearSearch(int searchFor, int[] intergerArray)
        {
            for (int i = 0; i < intergerArray.Length; i++)
            {
                if (searchFor == intergerArray[i])
                {
                    return i + 1;
                }
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
            //Write your solution here

            int mid = arrayStart + (arrayEnd - arrayStart) / 2;


            if (integerArray[mid] == searchFor)
                return 1;

            else if (integerArray[mid] > searchFor)
                return 1 + StepsInBinarySearch(integerArray, arrayStart, mid - 1, searchFor);

            return 1 + StepsInBinarySearch(integerArray, mid + 1, arrayEnd, searchFor);


        }
        /*
         * Introduktion til Algoritmer
         * Exercise 5.
         * Describe an algorithm based on the linear search for de-termining the correct position in which to insert a new element in an already sorted list.
         */
        public static int InsertSortedList(List<int> sortedList, int insert)
        {
            //Write your solution here


            for (int i = 0; i < sortedList.Count; i++)
            {
                if (sortedList[i + 1] > insert)
                {
                    sortedList.Insert(i, insert);
                    return i + 1;
                }
            }

            sortedList.Add(insert);
            return sortedList.Count;
        }
        /*
         * Exercise 6.
         * Arrays
         * Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num up to length.
         * Notice that num is also included in the returned array.
         */
        public static int[] ArrayOfMultiples(int num, int length)
        {
            //Write your solution here
            int[] temparray = new int[length];

            for (int i = 0; i < length; i++)
            {
                temparray[i] = num * (i + 1);
            }
            return temparray;

        }
        /*
         * Exercise 7.
         * Create a function that takes in n, a, b and returns the number of values raised to the nth power that lie in the range [a, b], inclusive.
         * Remember that the range is inclusive. a < b will always be true.
         */
        public static int PowerRanger(int power, int min, int max)
        {
            throw new NotImplementedException();
            //Write your solution here


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
            throw new NotImplementedException();
            //Write your solution here
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
         * Write a more effectiv version of this function.
         */
    }
}