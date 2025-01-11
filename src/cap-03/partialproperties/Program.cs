var m = new MyClass();
m.Name = "Rodrigo";
System.Console.WriteLine(m.Name);
public partial class MyClass
{
    public partial string Name { get; set; }
}

public partial class MyClass
{
    private string name;
    public partial string Name 
    {
        get => name;
        set => name = value;
    }
}