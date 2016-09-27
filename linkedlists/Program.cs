using System;
using System.Linq;
using Structures;

namespace LinkedLists
{
    public class Program
    {
        public static void DemonstrateLinkedList(){
            Console.WriteLine("Demonstrating a Linked List");
            var n1  = new Node {Value = 1 };
            var n2  = new Node {Value = 2 };
            var n3  = new Node {Value = 3 };
            var n4  = new Node {Value = 4 };
            var ll = new LinkedList(n1);
            ll.Add(n2);
            ll.Add(n4);
            ll.Add(n3);
           
            var n5 = new Node {Value = 5};
            var n6 = new Node {Value =6 };
            ll.AddFront(n5);
            ll.AddBack(n6);
            ll.ToList().ForEach(n => Console.WriteLine(n.Value));
            Console.Write("\n\n");
        }

        public static void DemonstrateDoublyLinkedList(){
            Console.WriteLine("Demonstrating a Doubly Linked List");
            var n1  = new DoubleNode<int> {Value = 1 };
            var n2  = new DoubleNode<int> {Value = 2 };
            var n3  = new DoubleNode<int> {Value = 3 };
            var n4  = new DoubleNode<int> {Value = 4 };
            var dll = new DoublyLinkedList<int>(n1);
            dll.Add(n2);
            dll.Add(n4);
            dll.Add(n3);
            var n5 = new DoubleNode<int> {Value = 5};
            var n6 = new DoubleNode<int> {Value = 6 };
            dll.AddFront(n5);
            dll.AddBack(n6);
            dll.ToList().ForEach(n => Console.WriteLine(n.Value));
            Console.Write("\n\n");
        }
        public static void Main(string[] args)
        {
            DemonstrateLinkedList();
            DemonstrateDoublyLinkedList();
        }
    }   
} 
