namespace P4_1Replacing;

public class Plant
{
    public bool isGrown;

    public void PrintStatus()
    {
        string result = isGrown ? "tree" : "seed";
        Console.WriteLine($"Plant is a {result}");
    }

    public void Grow()
    {
        if (isGrown)
        {
            Console.WriteLine("Plant has already grown.");
            return;
        }
        Console.WriteLine("Plant is growing.");
        isGrown = true;
    }
}