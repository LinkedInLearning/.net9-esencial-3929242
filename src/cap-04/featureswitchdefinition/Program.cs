using System.Diagnostics.CodeAnalysis;

if (MyClass.IsEnabled)
{
    var m = new MyClass();
    m.Process();
}

class MyClass
{
    [FeatureSwitchDefinition("MyClass.IsEnabled")]
    public static bool IsEnabled 
        => AppContext.TryGetSwitch("MyClass.IsEnabled", out bool isEnabled) ? isEnabled : true;

    public void Process()
    {
        Console.WriteLine(nameof(Process));
        ProcessLargeData();
        ProcessStrings();
    }
    private void ProcessLargeData()
    {
        var data = new byte[1024 * 1024];
        for (int i = 0; i < data.Length; i++)
        {
            data[i] = (byte)(i % 256);
        }
        Console.WriteLine($"Processed {data.Length} bytes");
    }
    private void ProcessStrings()
    {
        var strings = new List<string>();
        for (int i = 0; i < 1000; i++)
        {
            strings.Add($"This is string {i} with some additional content to make it larger {Guid.NewGuid()}");
        }
        Console.WriteLine($"Processed {strings.Count} strings");
    }

}