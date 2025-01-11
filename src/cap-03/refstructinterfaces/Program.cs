var s = new MyStruct();
s.Start();
interface IProcess
{
    void Start();
}
ref struct MyStruct : IProcess
{
    public void Start()
    {
        System.Console.WriteLine("Start!");
    }
}