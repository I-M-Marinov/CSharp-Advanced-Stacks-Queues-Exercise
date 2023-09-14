int[] input = Console.ReadLine().Split().Select(int.Parse).ToArray();

int capacity = int.Parse(Console.ReadLine());

Stack<int> racks = new Stack<int>(input);    

int totalRacksUsed = 1;
int currentCapacity = 0;

while (racks.Count > 0)
{
    int currentValue = racks.Pop();

    if (currentValue + currentCapacity <= capacity)
    {
        currentCapacity += currentValue;
    }
    else
    {
        totalRacksUsed++;
        currentCapacity = currentValue;
    }
}

Console.WriteLine(totalRacksUsed);
