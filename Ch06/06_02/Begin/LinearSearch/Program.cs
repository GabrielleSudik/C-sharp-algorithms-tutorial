using System;
using static System.Console;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //this code written after the methods below.

            int theValue = 7;
            int[] array = new int[] { 4, 9, 3, 2, 7, 6, 1 };

            WriteLine("The array contains: ");
            Array.ForEach(array, x => Write(x + " "));

            Write($"\nThe result of the linear search for {theValue} is index: ");
            WriteLine(LinearSearch(array, theValue));
            WriteLine(BetterLinearSearch(array, theValue));
        }

        static int LinearSearch(int[] a, int x)
        {
            int answer = -1; //default if you don't get a match

            //check each element of array against target x.
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    answer = i;
                    break; //dunno if break works here.
                        //you tested by debugging... break DOES work here.
                }
                //an inefficiency in the code:
                //once you set answer, the for loop will keep running.
                //guess you can't put "break" in the if statement?? (update: you can)
                //so see below for how using multiple return lines is more efficient.
            }

            return answer;
        }

        //the substance of this method is the same
        //but the for loop will "break" when you get a match.
        static int BetterLinearSearch(int[] a, int x)
        {
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i] == x)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
