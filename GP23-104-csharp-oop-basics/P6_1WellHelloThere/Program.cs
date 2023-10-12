

Lightsaber lightsaber = new Lightsaber();
ObiWan obiWan = new ObiWan();

Console.WriteLine(lightsaber);
Console.WriteLine(obiWan.Weapon);

obiWan.Weapon = lightsaber;

Console.WriteLine(obiWan.Weapon);
Console.WriteLine("General Kenobi!");
