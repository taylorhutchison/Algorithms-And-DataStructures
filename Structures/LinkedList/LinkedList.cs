using System;
using System.Collections;
using System.Collections.Generic;
using Structures;

namespace Structures.LinkedList {

    public class LinkedList<T>: IEnumerable<INode<T>> {

        public INode<T> Head {get; private set;}
        public INode<T> Tail {get; private set;}
        public INode<T> Current {get; private set;}

        public IEnumerator<INode<T>> GetEnumerator(){
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

        public INode<T> Next(){
            var next = this.Current?.Next;
            this.Current = next;
            return next;
        }

        public INode<T> RemoveHead(){
            var head = Head;
            Head = Head.Next;
            return head;
        }
        
        public void Reset(){
            this.Current = this.Head;
        }

        public void Add(INode<T> node){
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

        public void AddFront(INode<T> node){
            node.Next = this.Head;
            this.Head = node;
        }

        public void AddBack(INode<T> node){
            this.Tail.Next = node;
            this.Tail = node;
        }

        public LinkedList(){}

        public LinkedList(INode<T> node){
            this.Head = node;
            this.Tail = node;
            this.Current = node;
        }
    }


}
