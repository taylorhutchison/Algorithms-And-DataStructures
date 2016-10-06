using Structures.LinkedList;

namespace Structures.Queue {

    public class LinkedListQueue<T>: IQueue<T>{
        private LinkedList<T> queue;
        public void Enqueue(T item){
            var node = new Node<T>(item);
            if(queue==null){
                this.queue = new LinkedList<T>(node);
            }
            else {
                queue.AddBack(node);
            }
        }

        public T Dequeue(){
            return queue.Head.Value;
        }

        public T Peek(){
            return queue.Head.Value;
        }

        public int Count { get {return 0;}}
        public int Size { get {return 0;}}
    }

}