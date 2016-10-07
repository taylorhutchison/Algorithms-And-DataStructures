namespace Structures
{
    public interface INode<T> {
        T Value {get;}
        INode<T> Next {get; set;}
    }
}