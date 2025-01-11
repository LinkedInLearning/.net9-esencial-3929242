var h = new Hello();
Action<string> s = h.SayHello;
s.Invoke("Rodrigo");
public class Hello
{
    public void SayHello(string name)
    {
        Console.WriteLine($"Hola {name}");
    }

    public void SayHello(int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine("¡Hola!");
        }
    }

    public void SayHello(string name, int number)
    {
        for (int i = 0; i < number; i++)
        {
            Console.WriteLine($"Hola, {name}");
        }
    }
}