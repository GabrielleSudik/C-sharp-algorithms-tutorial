using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //this Main method code is written after Node and SinglyLinkedList classes are created.

            //create your list then populate it:
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.insertFirst(100);
            myList.insertFirst(75);
            myList.insertFirst(50);
            myList.insertFirst(25);

            //check it out:
            myList.displayList();
            //it will print 25, 50, 75, 100...
            //because you've written the code so that whatever is added most recently
            //becomes the "head", ie, "first"
            //and it will always point to whatever was first just before it.

            //add something to the Tail:
            myList.insertLast(6);
            myList.displayList();
            //prints 25, 50, 75, 100, 6

            //remove the Head:
            myList.deleteFirst();
            myList.displayList();
            //prints 50, 75, 100, 6
        }

        //step one: create the node class:
        //ie, each part of the linked list
        public class Node
        {
            //each node has two components:
            public int data; //the "contents" of the node
            public Node next; //the node will point to its neighbor.

            //the class will have a method to print the data
            public void displayNode()
            {
                Console.WriteLine($"< {data} > points to {next}");
            }
        }

        //second, create a class for the linked list:
        //how to start it, add to it, subtract from it.
        public class SinglyLinkedList
        {
            //you'll need at least one Node to make the list:
            private Node first;

            //check to see if the list is empty:
            //it will be at first.
            public bool isEmpty()
            {
                return (first == null);
            }

            //populate the first node, passing in data.
            public void insertFirst(int data)
            {
                Node newNode = new Node();
                newNode.data = data;
                newNode.next = first;
                first = newNode;
            }

            //remove the first node:
            public Node deleteFirst()
            {
                Node temp = first;
                first = first.next;
                return temp;
            }

            //display the list:
            public void displayList()
            {
                Console.WriteLine("Linked list (first to last) ");
                Node current = first; //this will start the list at the first node.
                while (current != null)
                {
                    current.displayNode(); //references the Node class.
                    current = current.next; //ditto
                }
                Console.WriteLine();
            }

            //insert the last node:
            public void insertLast(int data)
            {
                Node current = first; //sets the first node as the "current node"
                while (current.next != null)
                {
                    current = current.next;
                    //this just loops through all the nodes
                    //each time moving the "current node" ahead to the next one.
                    //when there is no next node (it's null) the loop ends.
                }

                Node newNode = new Node(); //after the loop ends, create a new node
                newNode.data = data; //supply its data
                current.next = newNode; //set the next node to be the new node.
            }
        }
    }

}
