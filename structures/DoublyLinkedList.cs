using System;
using System.Collections;
using System.Collections.Generic;

namespace Structures {


public class DoublyLinkedList<T>: IEnumerable<DoubleNode<T>> {

    private DoubleNode<T> _head;
    private DoubleNode<T> _tail;
    private DoubleNode<T> _current;

    public IEnumerator<DoubleNode<T>> GetEnumerator(){
           this._current = this._head;
           while(this._current != null){
                yield return this._current;
                this._current = this._current.Next;
           }    
    }

    System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }

    public DoubleNode<T> Previous(){
            var previous = this._current?.Previous;
            this._current = previous;
            return previous;
    }

     public DoubleNode<T> Next(){
            var next = this._current?.Next;
            this._current = next;
            return next;
    }

    public void Add(DoubleNode<T> node){
            node.Previous = this._tail;
            this._tail.Next = node;
            this._tail = node;
    }

    public void AddFront(DoubleNode<T> node){
        node.Next = this._head;
        this._head.Previous = node;
        this._head = node;
    }

    public void AddBack(DoubleNode<T> node){
        node.Previous = this._tail;
        this._tail.Next = node;
        this._tail = node;
    }


    public DoublyLinkedList(DoubleNode<T> node){
            this._head = node;
            this._tail = node;
            this._current = node;
    }
}

}
