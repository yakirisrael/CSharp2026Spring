// See https://aka.ms/new-console-template for more information


int rows = 30;
int columns = 10;
string symbol = "@ ";

// outer loop
for (int i = 1; i <= rows; i++)
{
    //inner loop
    for (int j = 1; j <= columns; j++)
    {
        Console.Write(symbol);
    }
    Console.WriteLine();
}

/*
int hp = 100;

for (int i = 1; i <= 200; i++)
{
    hp -= 10;
    Console.WriteLine(hp);

    if (hp <= 0)
    {
        Console.WriteLine("You are dead");
        string newMenu = "MainMenu";
        Console.WriteLine("open " + newMenu);
    }
    else Console.WriteLine("you are alive");
}
*/




/*
if (hp <= 0)
{
    Console.WriteLine("You are dead");
    string newMenu = "MainMenu";
    Console.WriteLine("open " + newMenu);
}
else Console.WriteLine("you are alive");
*/