using Xunit;
using System;
using System.Linq;
using Structures.LinkedList;

namespace Tests
{
    public class LinkedListTests
    {
        private LinkedList<int> CreateList(int[] numbers){
            var ll = new LinkedList<int>();
            foreach(var num in numbers){
                ll.Add(new Node<int>(num));
            }
            return ll;
        }
           
        [Fact]
        public void LinkedList_Head_Is_First_Inserted_Node() 
        {
            var list = CreateList(new int[]{1,2,3,4,5});
            var head = list.Head;
            Assert.Equal(1, head.Value);
        }

        [Fact]
        public void LinkedList_Head_Is_First_Inserted_Node() 
        {
            var list = CreateList(new int[]{1,2,3,4,5});
            var head = list.Head;
            Assert.Equal(1, head.Value);
        }
    }
}
