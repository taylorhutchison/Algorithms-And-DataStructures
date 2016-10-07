using Xunit;
using System;
using Structures.BinaryTree;


namespace Tests {
    
    public class BinaryTreeTests {

        [Fact]
        public void Create_Tree(){
            var tree = new BinaryTree<int>();
            tree.Insert(7);
            tree.Insert(6);
            tree.Insert(8);
            tree.Insert(4);
            tree.Insert(5);
            Assert.Equal(5,tree.Root.Left.Left.Right.Value);
        }

    }

}