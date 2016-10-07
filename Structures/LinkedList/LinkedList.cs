using System;
using System.Collections;
using System.Collections.Generic;

namespace Structures.LinkedList {

    public class LinkedList<T>: IEnumerable<Node<T>> {

        public Node<T> Head {get; private set;}
        public Node<T> Tail {get; private set;}
        public Node<T> Current {get; private set;}

        public IEnumerator<Node<T>> GetEnumerator(){
           this.Current = this.Head;
           while(this.Current != null){
                yield return this.Current;
                this.Current = this.Current.Next;
           }    
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }

        public Node<T> Next(){
            var next = this.Current?.Next;
            this.Current = next;
            return next;
        }

        public Node<T> RemoveHead(){
            var head = Head;
            Head = Head.Next;
            return head;
        }
        
        public void Reset(){
            this.Current = this.Head;
        }

        public void Add(Node<T> node){
            if(this.Head == null){
                this.Head = node;
                this.Tail = node;
                this.Current = node;
            }
            else {
                this.Tail.Next = node;
                this.Tail = node;
            }
        }

        public void AddFront(Node<T> node){
            node.Next = this.Head;
            this.Head = node;
        }

        public void AddBack(Node<T> node){
            this.Tail.Next = node;
            this.Tail = node;
        }

        public LinkedList(){}

        public LinkedList(Node<T> node){
            this.Head = node;
            this.Tail = node;
            this.Current = node;
        }
    }


}
