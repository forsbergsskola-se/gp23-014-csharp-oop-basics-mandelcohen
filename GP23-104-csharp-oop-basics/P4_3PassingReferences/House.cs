namespace P4_3PassingReferences;

public class House
{
    public string owner = "Mandel";

    public void PrintOwner()
    {
        Console.WriteLine($"This house is owned by {owner}");
    }
}