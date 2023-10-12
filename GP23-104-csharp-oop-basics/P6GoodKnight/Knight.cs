
namespace P6GoodKnight;

public class Knight
{
    public Shield Shield;
    public Sword Sword;

    public void GetHit(Sword sword)
    {
        if (sword == null && Shield != null)
        {
            Console.WriteLine("Knights Shield fends off the attack.");
            return ;
        }
        if (sword != null && Shield != null)
        {
            Console.WriteLine("Knights Shield was pierced by the sword.");
            Shield = null;
            return;
        }
        if (Shield == null)
        {
            Console.WriteLine("The Knight has no Shield and is wounded.");
        }
    }

    public void Attack(Knight defender)
    {
        if (Sword == null)
        {
            Console.WriteLine("Knight attacks with Bare Hands.");
            return;
        }
        Console.WriteLine("Knight attacks Knight with Sword.");
    }
}