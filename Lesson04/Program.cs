// See https://aka.ms/new-console-template for more information

string UserName = "yakir";
string Password = "12345";
//GreetUser(UserName);

UserName = "Adi";
//GreetUser(Password);

//Console.WriteLine(Factorial(5));
SpawnEnemiesRecusivly(3);




void GreetUser(string name)
{
    Console.WriteLine("Hello " +  name);
}

int Factorial(int n)
{
    if (n == 0)
        return 1;
    
    return n * Factorial(n - 1);
}

void SpawnEnemiesRecusivly(int numberOfEnemies)
{
    if (numberOfEnemies == 0)
        return;
    
    Console.WriteLine("Spawning enemy " +  numberOfEnemies);
    SpawnEnemiesRecusivly(numberOfEnemies - 1);
}