namespace P3LevelUp;

public class Player
{
    public int Level;
    public int Exp;
    
    public void GrantExperience(int Level, int Exp)
    {
        Console.WriteLine($"Level: {Level} and Experience {Exp}");
        int userInput = int.Parse(Console.ReadLine());
        this.Exp += userInput;

        int maxExpToLevel = 100;

        while (this.Exp >= maxExpToLevel)
        {
            this.Level++;
            this.Exp -= maxExpToLevel;
        } 
    }
}