using Xunit;
using System;
using Structures.Queue;


namespace Tests {
    
    public class QueueTests {

        [Fact]
        public void Enqueue_And_Dequeue_Single_Item(){
            IQueue<int> queue = new Queue<int>(4);
            queue.Enqueue(1);
            var item = queue.Dequeue();
            Assert.Equal(1, item);
        }

        [Fact]
        public void Enqueue_And_Dequeue_Multiple_Items(){
            IQueue<int> queue = new Queue<int>(4);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            var first = queue.Dequeue();
            var second = queue.Dequeue();
            Assert.Equal(1, first);
            Assert.Equal(2, second);
        }

        [Fact]
        public void Force_Queue_To_Resize(){
            IQueue<int> queue = new Queue<int>(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Enqueue(4);
            Assert.Equal(6, queue.Size);
        }

    }

}