using Xunit;
using System;
using Structures.Queue;


namespace Tests {
    
    public class PriorityQueueTests {

        [Fact]
        public void Enqueue_Increasing_Priority_Items(){
            var queue = new PriorityQueue<int>();
            queue.Enqueue(1,3);
            queue.Enqueue(2,2);
            queue.Enqueue(3,1);
            var item = queue.Peek();
            Assert.Equal(3, item);
        }

       [Fact]
       public void Enqueue_Same_Priority_Items(){
            var queue = new PriorityQueue<int>();
            queue.Enqueue(1,1);
            queue.Enqueue(2,1);
            queue.Enqueue(3,1);
            queue.Enqueue(4,1);
            var item = queue.Peek();
            Assert.Equal(1, item);
        }

       [Fact]
       public void Enqueue_Different_Priority_Items(){
            var queue = new PriorityQueue<int>();
            queue.Enqueue(1,99);
            queue.Enqueue(2,77);
            queue.Enqueue(3,103);
            queue.Enqueue(4,89);
            var item = queue.Peek();
            Assert.Equal(2, item);
        }

    }

}