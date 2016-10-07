using Structures.LinkedList;

namespace Structures.Queue {

    public class LinkedListQueue<T>: IQueue<T>{
        private LinkedList<T> queue;
        private int _count = 0;
        public void Enqueue(T item){
            var node = new Node<T>(item);
            if(queue==null){
                this.queue = new LinkedList<T>(node);
            }
            else {
                queue.AddBack(node);
            }
            _count++;
        }

        public T Dequeue(){
            _count--;
            return queue.RemoveHead().Value;
        }

        public T Peek(){
            return queue.Head.Value;
        }

        public int Count { get {return _count;}}
        public int Size { get {return Count;}}
    }

}