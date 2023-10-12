
public class Knight
{
    public Shield shield;
    public Sword sword;

    public void GetHit(Sword sword)
    {
        if (sword == null && shield != null)
        {
            Console.WriteLine("Knights Shield fends off the attack.");
            return ;
        }
        if (sword != null && shield != null)
        {
            Console.WriteLine("Knights Shield was pierced by the sword.");
            shield = null;
            return;
        }
        if (shield == null)
        {
            Console.WriteLine("The Knight has no Shield and is wounded.");
        }
    }

    public void Attack(Knight defender)
    {
        if (sword == null)
        {
            Console.WriteLine("Knight attacks with Bare Hands.");
            return;
        }
        Console.WriteLine("Knight attacks Knight with a Sword.");
    }
}