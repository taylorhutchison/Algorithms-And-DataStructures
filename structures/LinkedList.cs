using System;
using System.Collections;
using System.Collections.Generic;

namespace Structures {

    public class LinkedList<T>: IEnumerable<Node<T>> {
       
        private Node<T> _head;
        private Node<T> _tail;
        private Node<T> _current;

        public IEnumerator<Node<T>> GetEnumerator(){
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

        public Node<T> Next(){
            var next = this._current?.Next;
            this._current = next;
            return next;
        }
        
        public void Reset(){
            this._current = this._head;
        }

        public void Add(Node<T> node){
            this._tail.Next = node;
            this._tail = node;
        }

        public void AddFront(Node<T> node){
            node.Next = this._head;
            this._head = node;
        }

        public void AddBack(Node<T> node){
            this._tail.Next = node;
            this._tail = node;
        }

        public LinkedList(Node<T> node){
            this._head = node;
            this._tail = node;
            this._current = node;
        }
    }


}
