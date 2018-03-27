using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTests
{
    public class StackViaList
    {
        private List<int> stackList = new List<int>();

        public StackViaList() { }

        public void Push(int nodeVal)
        {
            stackList.Add(nodeVal);
            return;
        }

        public int Pop()
        {
            int nodeVal = stackList[stackList.Count - 1];
            stackList.RemoveAt(stackList.Count - 1);
            return nodeVal;
        }

        public int Peek()
        {
            return stackList[stackList.Count - 1];
        }

        public void Clear()
        {
            stackList.RemoveRange(0, stackList.Count - 1);
        }


    }
}
