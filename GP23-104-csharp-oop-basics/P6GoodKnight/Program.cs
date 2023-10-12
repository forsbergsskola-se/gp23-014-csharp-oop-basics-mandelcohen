
using P6GoodKnight;

Knight attacker = new Knight();
Knight defender = new Knight();

defender.Shield = new Shield();

attacker.Attack(defender);
defender.GetHit(attacker.Sword);

attacker.Sword = new Sword();
Console.WriteLine("Equipping sword...");

attacker.Attack(defender);
defender.GetHit(attacker.Sword);

attacker.Attack(defender);
defender.GetHit(attacker.Sword);

