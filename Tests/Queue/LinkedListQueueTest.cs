using Xunit;
using System;
using Structures.Queue;


namespace Tests {
    
    public class LinkedListQueueTests {

        [Fact]
        public void Enqueue_And_Dequeue_Single_Item(){
            IQueue<int> queue = new LinkedListQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            var item = queue.Peek();
            Assert.Equal(1, item);
        }

        [Fact]
        public void Enqueue_And_Dequeue_Multiple_Items(){
            IQueue<int> queue = new LinkedListQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            var item = queue.Peek();
            Assert.Equal(5,item);
        }

        [Fact]
        public void Enqueue_Adds_To_Count(){
            IQueue<int> queue = new LinkedListQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.Equal(3,queue.Count);
        }

        [Fact]
        public void Dequeue_Subtracts_To_Count(){
            IQueue<int> queue = new LinkedListQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();
            queue.Dequeue();
            Assert.Equal(1,queue.Count);
        }


    }

}