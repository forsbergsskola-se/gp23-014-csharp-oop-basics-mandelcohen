namespace P3_2OpenDoor;

public class House
{
    public bool IsDoorOpen;
    
    public bool OpenDoor()
    {
        return IsDoorOpen = true;
    }

    public bool CloseDoor()
    {
        return IsDoorOpen = false;
    }
}