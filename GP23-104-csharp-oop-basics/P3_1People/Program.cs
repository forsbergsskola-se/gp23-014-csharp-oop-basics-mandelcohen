
using P3_1People;

Person[] persons = new Person[3];

for (var i = 0; i < persons.Length; i++)
{
    persons[i] = new Person();
}

for (var i = 0; i < persons.Length; i++)
{
    Console.WriteLine("Give me a name:");
    persons[i].name = Console.ReadLine();
}

for (var i = 0; i < persons.Length; i++)
{
    persons[i].Greeting(persons[i].name);
}