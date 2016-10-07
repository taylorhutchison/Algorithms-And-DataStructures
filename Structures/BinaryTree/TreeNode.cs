using System;
namespace Structures.BinaryTree {
    public class TreeNode<T> where T : IComparable<T>{
        public T Value {get; private set;}
        public TreeNode<T> Left {get; set;}
        public TreeNode<T> Right {get; set;}
        public TreeNode(T val){
            Value = val;
        }
    }
}