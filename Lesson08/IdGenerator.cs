namespace Lesson08;

public static class IdGenerator
{
    private static int id = 100;
    
    public static int GetId()
    {
        return id;
    }

    public static int IncrementID()
    {
        return ++id;
    }
}