using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTests
{
    public class StackWithMin
    {
        private Stack<int> valueStack = new Stack<int>();
        private Stack<int> minStack = new Stack<int>();
        public StackWithMin() { }

        public void Push(int nodeVal)
        {
            valueStack.Push(nodeVal);
            if(minStack.Count < 1)
            {
                minStack.Push(nodeVal);
            }
            else
            {
                if(nodeVal < minStack.Peek())
                {
                    minStack.Push(nodeVal);
                }
                else
                {
                    minStack.Push(minStack.Peek());
                }
            }
            return;
        }

        public int Pop()
        {
            minStack.Pop();
            return valueStack.Pop();
        }

        public int Peek()
        {
            return valueStack.Peek();
        }

        public void Clear()
        {
            valueStack.Clear();
            minStack.Clear();
        }

        public int GetMiniumn()
        {
            return minStack.Peek();
        }
    }
}
