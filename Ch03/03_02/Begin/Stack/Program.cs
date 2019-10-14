using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//new! cool!
using static System.Console;
//lets you skip writing Console.WriteLine, etc..
//you just need WriteLine, etc now.

namespace Stack
{
    class Program
    {
        static void Main(string[] args)
        {
            //we're writing the main method code last

            Stack theStack = new Stack(4); //limit it to 4 elements
            theStack.push("Working Girl");
            theStack.push("Raiders");
            theStack.push("Amadeus");
            theStack.push("Gilda"); //pops first, because added last.
            theStack.push("Mars"); //a fifth. it won't be added.

            WriteLine("\nLet's peek at the top of the stack:");
            WriteLine($"{theStack.peek()} is at the top of the stack.");


            //pop the stack until it's empty:
            WriteLine("\nThe stack contains:");
            while (!theStack.isEmpty())
            {
                string movie = theStack.pop();
                WriteLine(movie);
            }

        }
    }

        //step one: create a Stack class
    public class Stack
    {
        private int maxSize;
        private string[] stackArray; //we'll make an array of movies
        private int top; //index position of last movie in the stack

        //the constructor:
        public Stack(int size)
        {
            maxSize = size;
            stackArray = new string[maxSize];
            top = -1; //prof says -1 is always the top of the array. hmm.
            //I think he means when you start with an empty array...
            //see the if/else in "push"
            //if you add a movie, you'll increate the array index by +1
            //so starting at -1 means 0 becomes the first array index, as it should.
            //thumbsup.
        }

        //push method to add elements:
        public void push(string m)
        {
            //first, check if the stack is full
            //cuz we have a maxSize.
            //needs help of isFull method below.
            if (isFull())
            {
                WriteLine("This stack is full");
            }
            else
            {
                //will increate the array index by one
                //and add the movie to that spot.
                top++;
                stackArray[top] = m;
            }
        }

        private bool isFull()
        {
            return (maxSize -1 == top);
            //this compares the most recent array index (top)
            //to the maxSize.
            //if array is full, the method above won't let you add more movies.

        }

        //pop method:
        public string pop()
        {
            //like with push(), check to see whether pop is empty first.
            if (isEmpty())
            {
                WriteLine("The stack is empty");
                return "--";
            }
            else
            {
                int oldTop = top; //copy the current top index
                top--; //reduce the array pointers by one
                return stackArray[oldTop]; //return whatever was previously in the top position.
            }
        }

        public bool isEmpty()
        {
            return (top == -1);
            //this just checks if the array index is at -1
            //if so, we know the array is empty.
        }

        //a peek method, to see what's on top of the stack
        public string peek()
        {
            return stackArray[top];
        }
    }
    

    
}
