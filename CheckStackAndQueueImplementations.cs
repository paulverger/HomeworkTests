using System;
using System.Collections.Generic;
using System.Text;

namespace HomeworkTests
{
    class CheckStackAndQueueImplementations
    {
        public static void CheckStackViaList()
        {
            StackViaList myStack = new StackViaList();
            myStack.Push(5);
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(8);
            myStack.Push(4);

            Console.Write("StackViaList Peek 1 = " + myStack.Peek().ToString() + "\n");
            Console.Write("StackViaList Pop 1 = " + myStack.Pop().ToString() + "\n");
            Console.Write("StackViaList Pop 2 = " + myStack.Pop().ToString() + "\n");

            myStack.Clear();

            myStack.Push(25);
            Console.Write("StackViaList Peek 2 = " + myStack.Peek() + "\n");       
        }

        public static void CheckStackViaArray()
        {
            StackViaArray myStack = new StackViaArray();
            myStack.Push(2);
            myStack.Push(3);
            myStack.Push(4);
            myStack.Push(5);
            myStack.Push(6);
            myStack.Push(7);
            myStack.Push(8);

            Console.WriteLine("Top of stack is " + myStack.Peek().ToString());

            Console.Write("Stack from top is: ");
            for(int i=0;i<7;i++)
            {
                Console.Write(" " + myStack.Pop().ToString());
            }
            Console.Write("\n");

            myStack.Clear();
            myStack.Push(15);
            Console.WriteLine("New top of stack is " + myStack.Peek().ToString());
        }

        public static void CheckQueueVia2Stacks()
        {
            QueueVia2Stacks queue = new QueueVia2Stacks();

            queue.Enque(1);
            queue.Enque(2);
            queue.Enque(3);
            queue.Enque(4);
            queue.Enque(5);
            queue.Enque(6);
            queue.Enque(7);

            Console.WriteLine("1: Next element in queue is " + queue.Peek().ToString());
            Console.Write("1234567: Queue was: ");
            for(int i=0;i<7;i++)
            {
                Console.Write(" " + queue.Deque().ToString());
            }
            Console.Write("\n");
            queue.Enque(15);
            queue.Enque(16);
            Console.WriteLine("15: Next element in queue is now " + queue.Peek().ToString());
            queue.Clear();
            queue.Enque(21);
            queue.Enque(22);
            Console.WriteLine("21: Next element in queue is now " + queue.Peek().ToString());
        }

        public static void CheckStackWithMin()
        {
            StackWithMin stack = new StackWithMin();
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(9);
            stack.Push(1);

            Console.WriteLine("1:  Top of stack is " + stack.Peek());
            Console.WriteLine("1: Minimum value on stack is " + stack.GetMiniumn());
            stack.Pop();
            Console.WriteLine("9:  Top of stack is " + stack.Peek());
            Console.WriteLine("2: Minimum value on stack is " + stack.GetMiniumn());
            stack.Clear();
            stack.Push(5);
            Console.WriteLine("5: Minimum value on stack is " + stack.GetMiniumn());
            stack.Push(6);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(8);
            Console.WriteLine("8:  Top of stack is " + stack.Peek());
            Console.WriteLine("2: Minimum value on stack is " + stack.GetMiniumn());
            return;
        }
    }
}
