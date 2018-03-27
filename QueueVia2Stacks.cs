using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTests
{
    class QueueVia2Stacks
    {
        private Stack<int> queueStack1 = new Stack<int>();
        private Stack<int> queueStack2 = new Stack<int>();

        public QueueVia2Stacks() { }

        public void Enque(int nodeVal)
        {
            queueStack1.Push(nodeVal);
            return;
        }

        public int Deque()
        {
            while (queueStack1.Count > 0)
            {
                queueStack2.Push(queueStack1.Pop());
            }
            int nodeVal = queueStack2.Pop();
            while (queueStack2.Count > 0)
            {
                queueStack1.Push(queueStack2.Pop());
            }
            return nodeVal;
        }

        public int Peek()
        {
            while (queueStack1.Count > 0)
            {
                queueStack2.Push(queueStack1.Pop());
            }
            int nodeVal = queueStack2.Peek();
            while (queueStack2.Count > 0)
            {
                queueStack1.Push(queueStack2.Pop());
            }
            return nodeVal;
        }

        public void Clear()
        {
            while(queueStack1.Count > 0)
            {
                queueStack1.Pop();
            }
            return;
        }
    }
}
