var numbers = new int[3] { 10, 20, 30 };
System.Console.WriteLine(numbers[^1]);
await Start();
System.Console.WriteLine(numbers[^1]);

async Task Start()
{
    await Print("Inicio");
    ref var number = ref GetNumber();
    UpdateNumber(ref number);
    await Print("Final");
}

ref int GetNumber()
{
    return ref numbers[^1];
}

void UpdateNumber(ref int number)
{
    number++;
}


async Task Print(string name)
{
    await Task.Delay(500);
    System.Console.WriteLine(name);
}