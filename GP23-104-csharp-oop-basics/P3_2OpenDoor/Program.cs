
using P3_2OpenDoor;

House blueHouse = new House();
House redHouse = new House();

void PrintDoors()
{
    string blueHouseDoor = blueHouse.IsDoorOpen ? "Open" : "Closed";
    string redHouseDoor = redHouse.IsDoorOpen ? "Open" : "Closed";
    
    Console.WriteLine($"{blueHouseDoor} and {redHouseDoor}");
}

PrintDoors();
blueHouse.OpenDoor();
PrintDoors();
redHouse.OpenDoor();
PrintDoors();
blueHouse.CloseDoor();
PrintDoors();