using Structures.LinkedList;

namespace Structures.Queue {

    public class LinkedListQueue<T>: IQueue<T>{
        protected LinkedList<T> queue;
        protected int _count = 0;
        public virtual void Enqueue(T item){
            INode<T> node = new Structures.Node<T>(item) as INode<T>;
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