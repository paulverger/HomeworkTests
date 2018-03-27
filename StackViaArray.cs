using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTests
{
    public class StackViaArray
    {
        private int[] stackArray = new int[5];

        public StackViaArray() { }

        private int _nCellsFilled = 0;

        public void Push(int nodeVal)
        {
            if (_nCellsFilled >= stackArray.GetLength(0))
            {
                Array.Resize(ref stackArray, 2 * _nCellsFilled);
            }
            stackArray[_nCellsFilled] = nodeVal;
            _nCellsFilled++;
            return;
        }

        public int Pop()
        {
            int NodeVal = stackArray[_nCellsFilled - 1];
            _nCellsFilled--;
            return NodeVal;
        }

        public int Peek()
        {
            return stackArray[_nCellsFilled - 1];
        }

        public void Clear()
        {
            _nCellsFilled = 0;
        }
    }
}
