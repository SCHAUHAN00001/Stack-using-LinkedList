using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Stack
{
    internal class Program
    {
        class Node
        {
           public int element;
            public Node next;
            public Node(int e, Node n)
            {
                element = e;
                next = n;
            }
        }
        class Stack_LinkedList
        {
            Node top;
            int size;
            public Stack_LinkedList()
            {
                top = null;
                size = 0;

            }
            public int length()
            {
                return size;
            }
            public bool isEmpty()
            {
                return size == 0;
            }
            public void push(int e)
            {
                Node newest = new Node(e, null);
                if(isEmpty())
                {
                    top = newest;
                }
                else
                {
                    newest.next = top;
                    top = newest;
                }
                size++;
            }
            public int pop()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                int e = top.element;
                top = top.next;
                size--;
                return e;
            }
            public int Top()
            {
                if (isEmpty())
                {
                    Console.WriteLine("Stack is empty");
                    return -1;
                }
                return top.element;
            }
            public void display()
            {
                Node p = top;
                while(p!= null)
                {
                    Console.WriteLine(p.element);
                    p= p.next;
                }
                Console.WriteLine();
            }
            
           
            


        }
        static void Main(string[] args)
        {
            Stack_LinkedList s = new Stack_LinkedList();
            Console.WriteLine("Creating a stack  using LinkedList (push())");
            s.push(6);
            s.push(5);
            s.push(4);
            s.push(3);
            s.push(2);
            s.push(1);
            s.display();
            Console.WriteLine("Size --> " + s.length());
            Console.WriteLine();
            Console.WriteLine("Removing Element using LIFO (pop()): ");
            s.pop();
            s.display();
            Console.WriteLine("Size --> " + s.length());
            Console.WriteLine();
            Console.WriteLine("Finding Top of the element (Top())");

            s.display();
            Console.WriteLine("Top elempent which inserted in last: " + s.Top());
            Console.WriteLine("Size --> " + s.length());

            Console.ReadLine();


        }
    }
}
