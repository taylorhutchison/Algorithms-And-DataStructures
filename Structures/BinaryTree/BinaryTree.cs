using System;
namespace Structures.BinaryTree {
    public class BinaryTree<T> where T : IComparable<T> {
        public TreeNode<T> Root {get; private set;}
        private int _count = 0;
        public void Insert(T val){
            if(Root == null){
                Root = new TreeNode<T>(val); 
            } 
            else {
                Insert(Root, val);
            } 
            _count++;
        }
        private void Insert(TreeNode<T> node, T val){
            if(val.CompareTo(node.Value) < 0){
                if(node.Left == null){
                    node.Left = new TreeNode<T>(val);
                }
                else {
                    Insert(node.Left, val);
                }
            }
            else {
                if(node.Right == null){
                    node.Right = new TreeNode<T>(val);
                }
                else {
                    Insert(node.Right, val);
                }
            }
        }
    }
}