﻿using System;
using System.Collections.Generic;
using System.Text;

/// <summary>
/// The following code example demonstrates several features of the 
/// LinkedList<T> class.
/// </summary>
namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            DemoLinkedListFeatures();
        }
      
        private static void DemoLinkedListFeatures()
        {
            
            //in this library, LinkedList is a generic
            //you can make a list of any type by <namingIt>
            //here we're just making the original list, based on the array of words.
            string[] words = { "the", "actor", "jumped", "over", "the", "director" };
            LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence, "The linked list values:");

            //now we're just adding something as First            
            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");

            //move a node from First to Last
            //do it by creating a temporary node that "copies" First
            //then delete First, then add its copy as Last.
            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence, "Test 2: Move first node to be last node:");
            
            //this just changes the value of the last node
            //by deleting the old last, and adding a new last.
            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence, "Test 3: Change the last node to 'yesterday':");
            
            //move the last node to first
            //again, by using a temporary placeholder 
            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence, "Test 4: Move last node to be first node:");

            //look for last occurance of a certain word (the)
            sentence.RemoveFirst();
            LinkedListNode<string> current = sentence.FindLast("the");
            IndicateNode(current, "Test 5: Indicate last occurence of 'the':");
            
            //add some words where we say.
            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");
            IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the':");
            
            //sets "actor" as the node.
            current = sentence.Find("actor");
            IndicateNode(current, "Test 7: Indicate the 'actor' node:");
            
            //add words before the current node (actor)
            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "skinny");
            IndicateNode(current, "Test 8: Add 'quick' and 'skinny' before 'actor':");

        
            Console.ReadLine();
        }

        private static void Display(LinkedList<string> words, string test)
        {
            Console.WriteLine(test);
            foreach (string word in words)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }

        private static void IndicateNode(LinkedListNode<string> node, string test)
        {
            Console.WriteLine(test);
            if (node.List == null)
            {
                Console.WriteLine("Node '{0}' is not in the list.\n",
                    node.Value);
                return;
            }

            StringBuilder result = new StringBuilder("(" + node.Value + ")");
            LinkedListNode<string> nodeP = node.Previous;

            while (nodeP != null)
            {
                result.Insert(0, nodeP.Value + " ");
                nodeP = nodeP.Previous;
            }

            node = node.Next;
            while (node != null)
            {
                result.Append(" " + node.Value);
                node = node.Next;
            }

            Console.WriteLine(result);
            Console.WriteLine();
        }
    }
}
