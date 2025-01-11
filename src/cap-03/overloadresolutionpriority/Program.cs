using System.Runtime.CompilerServices;

var m = new MyClass();
m.Process([1,2,3,4,5]);
class MyClass
{
    [OverloadResolutionPriority(1)]
    public void Process(params Span<int> span)
    {
        System.Console.WriteLine("Span");
    }

    public void Process(params int[] array)
    {
        System.Console.WriteLine("Array");
    }
}