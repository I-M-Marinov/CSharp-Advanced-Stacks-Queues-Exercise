int[] ruleNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
int[] inputNumbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

int pushElements = ruleNumbers[0];
int popElements = ruleNumbers[1];
int checkIfNumberIsPresent = ruleNumbers[2];

Queue<int> numbersStack = new Queue<int>(inputNumbers.Take(pushElements));


for (int i = 0; i < popElements; i++)
{
    numbersStack.Dequeue();
}

if (numbersStack.Contains(checkIfNumberIsPresent))
{
    Console.WriteLine("true");
}
else if (!numbersStack.Contains(checkIfNumberIsPresent))
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