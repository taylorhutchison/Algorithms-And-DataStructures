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
            Assert.Equal(99, item);
        }

    }

}