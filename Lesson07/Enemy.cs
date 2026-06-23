namespace Lesson07;



public class Enemy
{
    private string name;
    private EnemyType type;
    private int health;

    private int StartHealth = 100;
    public Enemy(string name, EnemyType type)
    {
        this.name = name;
        this.type = type;
        this.health = StartHealth;
    }

    public Enemy()
    {
        this.name = "DefaultEnemy";
        this.type = EnemyType.Ogre;
        this. health = StartHealth;
    }

    public void Attack()
    {
        Console.WriteLine($"{name} is attacking");
    }

    public int GetHealth()
    {
        if (health <= 0)
            return 0;
        
        return health;
    }

    public void SetHealth(int hp)
    {
        if (hp <= 0)
        {
            health = 0;
            return;
        }
        health = hp;
    }

    public void SetName(string newName)
    {
        if (string.IsNullOrEmpty(newName))
        {
            name = "TheAllMightTalor";
        }
        else
        {
            name = newName;
        }
    }

    public string GetName()
    {
        return name;
    }
}