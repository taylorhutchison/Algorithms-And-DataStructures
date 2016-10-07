namespace Structures {

public class DoubleNode<T> {

    public T Value { get; set; }
    public DoubleNode<T> Previous {get; set;}
    public DoubleNode<T> Next {get; set;}

}
}
