namespace Structures {
    public class PriorityNode<T>: Node<T>{
        public int Priority {get; private set;}
        public PriorityNode(T val, int priority):base(val){
            Priority = priority;
        }
    }
}