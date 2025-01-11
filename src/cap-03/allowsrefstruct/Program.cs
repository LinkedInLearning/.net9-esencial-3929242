using System.Runtime.CompilerServices;

MyClass<Span<int>> x = new();
x.Print(new Span<int>([1,2,3,4,5]));
class MyClass<T> where T: allows ref struct
{
    public void Print(T value)
    {
        var span = Unsafe.As<T, Span<int>>(ref value);
        span.Reverse();
        for (int i = 0; i < span.Length; i++)
        {
            System.Console.WriteLine(span[i]);
        }
    }
}