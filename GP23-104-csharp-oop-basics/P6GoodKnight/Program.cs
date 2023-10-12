
Knight attacker = new Knight();
Knight defender = new Knight
{
    shield = new Shield()
};

attacker.Attack(defender);
defender.GetHit(attacker.sword);

attacker.sword = new Sword();
Console.WriteLine("Equipping sword...");

attacker.Attack(defender);
defender.GetHit(attacker.sword);

attacker.Attack(defender);
defender.GetHit(attacker.sword);

