namespace Structures {

    public class Node<T>: INode<T>{

        public T Value {get; set;}
        public INode<T> Next {get; set;}

        public Node(T val){
            Value = val;
        }

    }
}
