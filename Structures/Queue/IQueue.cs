namespace Structures.Queue {
    public interface IQueue<T> {
        void Enqueue(T item);
        T Dequeue();
        T Peek();
        int Count {get;}
        int Size {get;}
    }

}