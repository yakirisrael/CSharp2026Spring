namespace Lesson08;

public class Player
{
    
    private int ownId;

    public Player()
    {
        ownId =  IdGenerator.IncrementID();
    }


    
    public int GetOwnId()
    {
        return ownId;
    }

    public void PrintInfo()
    {
        Console.WriteLine($"shared id = {IdGenerator.GetId()} , own id = {ownId}");
    }
    
    public static void PrintSharedInfo()
    {
        Console.WriteLine($"shared id = {IdGenerator.GetId()}");
    }
}