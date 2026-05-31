// See https://aka.ms/new-console-template for more information

float health; //declare on a float variable that will contain health valure

/* the application is doing the following:
 
 reading a name and health from the console input
 very smart application
 
 */
Console.WriteLine("Please enter your name:");
string name = Console.ReadLine();
Console.WriteLine("Aha your name is " + name);

Console.WriteLine("Please enter your health:");
string healthStr = Console.ReadLine();
health = float.Parse(healthStr);
Console.WriteLine($"your health = {health} ");


