namespace P3_1People;

public class Person
{
    public string name;
    
    public void Greeting()
    {
        Console.WriteLine($"Hello, {this.name}");
    }
}