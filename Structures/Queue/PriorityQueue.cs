using Structures;
using Structures.LinkedList;

namespace Structures.Queue {
    public class PriorityQueue<T>: LinkedListQueue<T> {
        public override void Enqueue(T val){
            Enqueue(val,0);
        }
        public void Enqueue(T val, int priority){
            var node = new PriorityNode<T>(val, priority);
            if(queue==null){
                this.queue = new LinkedList<T>(node);
            }
            else {
                queue.Reset();
                PriorityNode<T> previous = null;
                PriorityNode<T> current = queue.Head as PriorityNode<T>;
                while(true){
                    if(node.Priority < current.Priority){
                        if(previous == null){
                            queue.AddFront(node);
                        }
                        else {
                            previous.Next = node;
                            node.Next = current;
                        }
                        break;
                    }
                    else if (current.Next == null){
                        queue.AddBack(node);
                        break;
                    }
                    previous = current;
                    current = queue.Next() as PriorityNode<T>;
                }
            }
            _count++;
        }
    }
}