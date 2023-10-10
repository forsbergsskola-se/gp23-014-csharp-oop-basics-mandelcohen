
using P2Fields;

Player playerA = new Player();

playerA.Gold = 200;
playerA.Stone = 110;
playerA.Wood = 53;

playerA.Level = 12;
playerA.Experience = 123;

playerA.hasVIPSubscription = true;
playerA.isPVPenabled = false;

playerA.Name = "Marc";
playerA.Email = "marc@zacu.de";

Console.WriteLine(@$"Name: {playerA.Name}
Email: {playerA.Email}
Level: {playerA.Level}
Experience: {playerA.Experience}
Gold: {playerA.Gold}
Stone: {playerA.Stone}
Wood: {playerA.Wood}");

string hasVIP = playerA.hasVIPSubscription ? "Active" : "Inactive";
Console.WriteLine($"VIP status: {hasVIP}");

string hasPVP = playerA.isPVPenabled ? "Enabled" : "Disabled";
Console.WriteLine($"PVP status: {hasPVP}");