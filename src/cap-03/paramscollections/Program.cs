// See https://aka.ms/new-console-template for more information
Console.WriteLine(MyFunction(1, 2, 3, 4, 5));

int MyFunction(params List<int> ints)
{
    return ints.Sum();
}