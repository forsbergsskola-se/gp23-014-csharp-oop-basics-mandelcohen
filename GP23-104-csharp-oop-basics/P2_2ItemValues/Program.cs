
Item[] gold = new Item[3];

for (var i = 0; i < gold.Length; i++)
{
    gold[i] = new Item();
}

gold[0].GoldValue = 100;
gold[1].GoldValue = 200;
gold[2].GoldValue = 300;

for (var i = 0; i < gold.Length; i++)
{
    Console.WriteLine(gold[i].GoldValue);
}
