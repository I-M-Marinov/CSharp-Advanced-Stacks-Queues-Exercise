
int[] ruleNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int pushElements = ruleNumbers[0];
int popElements = ruleNumbers[1];
int checkIfNumberIsPresent  = ruleNumbers[2];

int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
Stack<int> numbersStack = new Stack<int>(pushElements);

foreach (var number in inputNumbers)
{
    numbersStack.Push(number);
}

for (int i = 0; i < popElements ; i++)
{
    numbersStack.Pop();
}

if (numbersStack.Contains(checkIfNumberIsPresent))
{
    Console.WriteLine("true");
}
else if(!numbersStack.Contains(checkIfNumberIsPresent))
{
    if (numbersStack.Count == 0)
    {
        Console.WriteLine(0);
    }
    else
    {
        int lowestNumber = numbersStack.Min();
        Console.Write($"{lowestNumber}");
    }

    
}