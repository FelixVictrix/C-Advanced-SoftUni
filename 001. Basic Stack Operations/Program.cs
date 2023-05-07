using System;
using System.Collections.Generic;
using System.Linq;

namespace _001._Basic_Stack_Operations
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] values = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int stackSize = values[0];
            int numberOfElementsToPop = values[1];
            int elementToLookForInStack = values[2];

            Stack<int> stack = new Stack<int>(numbers);

            PopElements(numberOfElementsToPop, stack);
            FindElement(stack, elementToLookForInStack);

        }

        static void FindElement(Stack<int> stack, int elementToLookForInStack)
        {

            if (!stack.Any())
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(elementToLookForInStack))
            {
                Console.WriteLine("true");
            }
            else
            {
                int smallest = stack.Min();
                Console.WriteLine(smallest);
            }

        }

        static void PopElements(int numberOfElementsToPop, Stack<int> stack)
        {
            for (int i = 0; i < numberOfElementsToPop; i++)
            {
                stack.Pop();
            }
        }
    }
}
