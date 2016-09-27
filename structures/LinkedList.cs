using System;
using System.Collections;
using System.Collections.Generic;

namespace Structures {

    public class LinkedList: IEnumerable<Node> {
       
        private Node _head;
        private Node _tail;
        private Node _current;

        public IEnumerator<Node> GetEnumerator(){
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

        public Node Next(){
            var next = this._current?.Next;
            this._current = next;
            return next;
        }
        
        public void Reset(){
            this._current = this._head;
        }

        public void Add(Node node){
            this._tail.Next = node;
            this._tail = node;
        }

        public void AddFront(Node node){
            node.Next = this._head;
            this._head = node;
        }

        public void AddBack(Node node){
            this._tail.Next = node;
            this._tail = node;
        }

        public LinkedList():this(new Node()){
        }

        public LinkedList(Node node){
            this._head = node;
            this._tail = node;
            this._current = node;
        }
    }


}
