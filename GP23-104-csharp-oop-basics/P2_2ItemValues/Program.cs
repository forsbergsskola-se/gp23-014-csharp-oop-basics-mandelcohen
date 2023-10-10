
Item[] gold = new Item[3];

for (var i = 0; i < gold.Length; i++)
{
    gold[i] = new Item();
}

gold[0].GoldValue = 100;
gold[1].GoldValue = 200;
gold[2].GoldValue = 300;

Console.WriteLine(gold[0].GoldValue);
Console.WriteLine(gold[1].GoldValue);
Console.WriteLine(gold[2].GoldValue);