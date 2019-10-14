using System;
using static System.Console;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            //this code written after BinarySearch method below.

            int theValue = 43;
            int[] array = new int[] { 11, 21, 37, 43, 55, 63, 67, 79 };

            WriteLine("Our array contains: ");
            Array.ForEach(array, x => Write(x + " ")); //Array is a built in class in System.
                                                       //and it has built in methods. Find 'em by typing dot.

            Write($"\nThe result of the binary search for {theValue} is array index: ");
            WriteLine(BinarySearch(array, theValue));
        }

        public static int BinarySearch(int[] a, int x) //pass in an array plus the int you're looking for
        {
            //check your notes for the non-code explanation
            //a = array
            //x = int we're looking for
            //p = first index of the array
            //q = midpoint
            //r = last index

            int p = 0;
            int r = a.Length - 1;

            while (p < r) //ie, while we are in the range of the array
            {
                int q = (p + r) / 2; //finds midpoint

                if (x < a[q])
                {
                    r = q - 1; //sets new r to just short of the old midpoint.
                }
                else if (x > a[q])
                {
                    p = q + 1; //sets new p to just past the old midpoint.
                }
                else
                {
                    return q; //if x = q, ie you found the match.
                }
            }

            return -1; //returned if x isn't in the array
        }

    }

}
