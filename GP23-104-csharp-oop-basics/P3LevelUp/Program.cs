
using P3LevelUp;

Player player = new Player
{
    Level = 0,
    Exp = 0
};

Console.WriteLine($"Level: {player.Level} and Experience: {player.Exp}.");
player.GrantExperience(player.Level, player.Exp);

Console.WriteLine($"Level: {player.Level} and Experience: {player.Exp}.");
player.GrantExperience(player.Level, player.Exp);



