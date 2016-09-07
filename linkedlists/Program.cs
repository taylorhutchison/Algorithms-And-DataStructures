using System;
using System.Linq;

namespace LinkedLists
{
    public class Program
    {
        public static void Main(string[] args)
        {
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
 
           }
    }   
} 
