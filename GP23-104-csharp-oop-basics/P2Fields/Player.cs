namespace P2Fields;

public class Player
{
    //Resources
    public int Gold;
    public int Stone;
    public int Wood;
    
    //Level and exp
    public int Level;
    public int Experience;
    
    // active or inactive extras
    public bool hasVIPSubscription;
    public bool isPVPenabled;
    
    // user can configure
    public string Name;
    public string Email;
}