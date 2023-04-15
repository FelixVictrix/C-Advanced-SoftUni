

string[] input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

Stack<int> stack = new Stack<int>();

stack.Push(int.Parse(input[0]));

for (int i = 1; i < input.Length; i += 2)
{
    string command = input[i];
    int number = int.Parse(input[i + 1]);

    if (command == "+")
    {
        int currentSum = stack.Pop() + number;
        stack.Push(currentSum);
    }
    else if (command == "-")
    {
        int currentSum = stack.Pop() - number;
        stack.Push(currentSum);
    }
}

{
    Console.WriteLine(stack.Pop());
}


