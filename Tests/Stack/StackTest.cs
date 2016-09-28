using Xunit;
using Structures.Stack;

namespace Tests {

    public class StackTests {

        [Fact]
        public void Peeking_At_Single_Item_In_Stack(){
            var stack = new Stack<int>();
            stack.Push(1);
            Assert.Equal(1,stack.Peek());
        }

        [Fact]
        public void Popping_Multiple_Items_Off_Stack_And_Peeking_At_Single_Item_In_Stack(){
            var stack = new Stack<int>();
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Pop();
            stack.Pop();
            Assert.Equal(2,stack.Peek());
        }

        [Fact]
        public void Adding_Hundreds_Of_Items_To_Stack(){
            var stack = new Stack<int>();
            for(int i = 0; i <= 200; i++){
                stack.Push(i);
            }
            Assert.Equal(200, stack.Peek());
        }

        [Fact]
        public void Adding_One_Thousand_Items_To_Stack(){
            var stack = new Stack<int>();
            for(int i = 0; i <= 1000; i++){
                stack.Push(i);
            }
            Assert.Equal(1024, stack.Size);
        }

    }

}