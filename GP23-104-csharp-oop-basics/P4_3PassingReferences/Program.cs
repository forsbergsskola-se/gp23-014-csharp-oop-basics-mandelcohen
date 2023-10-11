
using P4_3PassingReferences;

void Sell(House arg)
{
    arg.owner = "Alex";
}

House house = new House();

house.PrintOwner();
Sell(house);
house.PrintOwner();
