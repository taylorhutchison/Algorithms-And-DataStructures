using Structures;

namespace Structures.Stack {

    public class Stack<T>{
           protected const int _initialSize = 4;
           protected int _size = 0;
           protected T[] _items;

           public int Count {get; protected set;}
           
           public int Size {
               get {
                    return _size;
               }
           }
           public void Push (T item){
               Resize();
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
           private void Resize(){
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
           
    }

}