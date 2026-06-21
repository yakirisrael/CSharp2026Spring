namespace Lesson06;

public struct Item
{
    public ItemType type;
    public string name;

    public void PrintInfo()
    {
        Console.WriteLine($"{name} is a {type}");
    }
}