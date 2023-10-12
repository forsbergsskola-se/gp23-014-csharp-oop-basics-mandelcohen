using System.Reflection.Metadata.Ecma335;

namespace P6GoodKnight;

public class Knight
{
    public Shield Shield;
    public Sword Sword;

    public void GetHit(Sword sword)
    {
        if (sword != null)
        {
            Console.WriteLine("Knight Shield fends off attack");
            return ;
        }
        Console.WriteLine("Knights Shield was pierced by the sword.");
    }

    public void Attack(Knight defender)
    {
        if (defender.Shield != null)
        {
            Console.WriteLine("Knight attacks Knight with Sword.");
            return;
        }
        Console.WriteLine("Knight attacks with Bare Hands");    
    }
}