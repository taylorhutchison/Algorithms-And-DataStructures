using System;

namespace Structures.Queue
{
    public class Queue<T>: IQueue<T> {
        protected const int _initialSize = 4;
        protected int _size = 0;
        protected T[] _items;

        public int Count {get; protected set;}
           
        public int Size {
            get {
                return _size;
            }
        }

        private int _head = 0;
        private int _tail = 0;

        public void Enqueue(T item){
            if(_tail == _items.Length){
                if(_head==0){
                    Resize();
                }
                else {
                    Realign();
                }
            }
            _items[_tail] = item;
            Count++;
            _tail++;
        }

        public T Dequeue(){
            var item = _items[_head];
            Count--;
            _head++;
            return item;
        }

        public T Peek(){
            return _items[_tail];
        }

        private void Realign(){
            var newArray = new T[_items.Length];
            _items.CopyTo(newArray, _head);
            _head = 0;
            _tail = Count - 1;
        }

        private void Resize(){
            _size = _items.Length * 2;
            var newArray = new T[_size];
            _items.CopyTo(newArray, 0);
            _items = newArray;
            _head = 0;
        }

        public Queue(int size){
            _size = size;
            _items = new T[_size];
        }

        public Queue(){
            _size = _initialSize;
            _items = new T[_size];
        }
    }
}