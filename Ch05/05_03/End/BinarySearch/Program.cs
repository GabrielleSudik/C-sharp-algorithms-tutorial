//.net's Array class already contains search methods
//eg, a BinarySearch method, just like what you learned.
//if you right click it, you can go to the definition
//and see what you need to use it.
//plus all the other methods like Sort, IndexOf, etc...

using System;
using static System.Console;

/// <summary>
/// Here we search an entire sorted array.
/// </summary>
public class Example
{
    public static void Main()
    {
        string[] dinners = {"Pasta",
                              "Apple Pie",
                              "Tuna Melt",
                              "Mushroom Omelet",
                              "Duck",
                              "Eggplant"};

        WriteLine();
        WriteLine("\nContent of array:");
        WriteLine("------------------");
        foreach (string dinner in dinners)
        {
            WriteLine(dinner);
        }

        WriteLine("\nContent after Sort:");
        WriteLine("------------------");
        Array.Sort(dinners);
        
        foreach (string dinner in dinners)
        {
            WriteLine(dinner);
        }

        WriteLine("\nBinarySearch for 'Beet Salad':");
        int index = Array.BinarySearch(dinners, "Beet Salad");
        DislpayWhere(dinners, index);

        WriteLine("\nBinarySearch for 'Tuna Melt':");
        index = Array.BinarySearch(dinners, "Tuna Melt");
        DislpayWhere(dinners, index);
    }

    private static void DislpayWhere<T>(T[] array, int index)
    {
        if (index < 0)
        {            
            index = ~index;

            Write("Not found. Sorts between: ");

            if (index == 0)
                Write("beginning of array and ");
            else
                Write("{0} and ", array[index - 1]);

            if (index == array.Length)
                WriteLine("end of array.");
            else
                WriteLine("{0}.", array[index]);
        }
        else
        {
            WriteLine("Found at index {0}.", index);
        }
    }
}