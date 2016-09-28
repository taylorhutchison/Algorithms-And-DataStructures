namespace Structures.Stack {

    public class Stack<T> {
           private const int _initialSize = 4;
           private int _size;
           private T[] _items;

           public int Count {get; private set;}
           public int Size {
               get {
                    return _size;
               }
           }

           private void Reallocate(){
               if(_items==null){
                   _size = _initialSize;
                   _items = new T[_size];
                   Count = 0;
               }
               else if(Count == _size){
                   _size = _size * 2;
                   var newArray = new T[_size];
                   _items.CopyTo(newArray,0);
                   _items = newArray;
               }
           }

           public void Push (T item){
               Reallocate();
               _items[Count] = item;
               Count++;
           }

           public T Peek(){
               return _items[Count-1];
           }

           public T Pop(){
                var item = Peek();
                Count = Count - 1;
                return item;
           }
           
    }

}