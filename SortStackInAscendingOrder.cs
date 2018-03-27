using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTests
{
    class SortStackInAscendingOrder
    {
        public static Stack<int> SortStackAscending(Stack<int> stack)
        {
            if(stack.Count <= 0)
            {
                return null;
            }
            Stack<int> stack2 = new Stack<int>();
            int temp = 0;
            stack2.Push(stack.Pop());
            while (stack.Count > 0)
            {
                temp = stack.Pop();
                if (stack2.Count > 0 && temp > stack2.Peek())
                {
                    stack2.Push(temp);
                }
                else
                {
                    while (stack2.Count > 0  && temp < stack2.Peek())
                    {
                            stack.Push(stack2.Pop());
                    }
                    if(stack2.Count > 0)
                    {
                        stack.Push(temp);
                    }
                    else
                    {
                        stack2.Push(temp);
                    }
                }
            }
            while (stack2.Count > 0)
            {
                stack.Push(stack2.Pop());
            }
            return stack;
        }

        public static void TestSort()
        {
            Stack<int> stack = new Stack<int>();
            stack.Push(5);
            stack.Push(11);
            stack.Push(15);
            stack.Push(4);
            stack.Push(9);
            stack.Push(2);
            stack.Push(3);

            stack = SortStackAscending(stack);

            Console.Write("Stack: ");
            while(stack.Count > 0)
            {
                Console.Write(" " + stack.Pop());
            }
            Console.Write("\n");
        }
    }
}
