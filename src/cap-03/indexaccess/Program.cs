var c = new Counter
{
    Numbers = 
    {
        [^1] = 1,
        [^2] = 2,
        [^3] = 3,
        [^4] = 4,
        [^5] = 5,
    }
};

foreach (var item in c.Numbers)
{
    System.Console.WriteLine(item);
}

class Counter 
{
    public int[] Numbers { get; set; } = new int[5];
}