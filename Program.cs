using System;

namespace Stack_Exercise
{
    public class stack<T>
    {
        private T[] stackData = new T[10];
        private const int STACK_MAX = 10;
        private int stackPtr = 0;

        public void push(T n)
        {
            if (stackPtr < STACK_MAX)
            {
                stackData[stackPtr] = n;
                stackPtr++;

            }
            else
            {
                Console.WriteLine("Stack Oveflow");
            }
        }
        public T pop()
        {
            T returnValue = default(T);
            if (stackPtr > 0)
            {
                stackPtr--;
                returnValue = stackData[stackPtr];
            }
            else
            {
                Console.WriteLine("Stack Underflow");
            }
            return returnValue;
        }
        public T peek()
        {
            T returnValue = default(T);
            if (stackPtr > 0)
            {
                returnValue = stackData[stackPtr - 1];
            }
            else
            {
                Console.WriteLine("Empty");
            }
            return returnValue;
        }

        // Use of ternary operator for conciseness
        public Boolean isEmpty()
        {
            return ((stackPtr > 0) ? false : true);
        }

        public Boolean isFull()
        {
            return ((stackPtr == STACK_MAX) ? true : false);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Expression checker!");
            stack<int> myStack = new stack<int>();
            for (int i = 0; i < 11; i++)
            {
                myStack.push(i);
            }
            stack<string> newStack = new stack<string>();
            newStack.push("Apples");

            // Brackets challenge
            stack<char> eStack = new stack<char>();
            string e = "(()))";
            char c;
            for (int p = 0; p < e.Length; p++)
            {
                c = e[p];
                if (c.Equals('('))
                {
                    eStack.push(c);
                    Console.WriteLine("Push (");
                }
                else if (c.Equals(')'))
                {
                    if (eStack.peek().Equals('('))
                    {
                        eStack.pop();
                        Console.WriteLine("Pop (");
                    }
                    else
                    {
                        Console.Write("Invalid Expression");
                    }
                }
            }
            if (eStack.isEmpty() == true)
            {
                Console.WriteLine("Valid Expression");
            }

        }
    }
}
