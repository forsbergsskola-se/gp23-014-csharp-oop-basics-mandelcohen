namespace P3LevelUp;

public class Player
{
    public int Level;
    public int Exp;
    
    public void GrantExperience(int levelValue, int expValue)
    {
        Console.WriteLine($"Level: {levelValue} and Experience {expValue}");
        int userInput = int.Parse(Console.ReadLine());
        expValue += userInput;

        int maxExpToLevel = 100;

        while (expValue >= maxExpToLevel)
        {
            levelValue++;
            expValue -= maxExpToLevel;
        } 

        Level = levelValue;
        Exp = expValue;
    }
}