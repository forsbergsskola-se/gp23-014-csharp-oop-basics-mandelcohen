namespace P3LevelUp;

public class Player
{
    public int Level;
    public int Exp;
    
    public void GrantExperience(int level, int exp)
    {
        int userInput = int.Parse(Console.ReadLine());
        exp += userInput;
        do
        {
            if (exp > 100)
            {
                level++;
                exp = 0;
            }
        } while (exp > 0);
    }
}