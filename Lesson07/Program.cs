// See https://aka.ms/new-console-template for more information

using Lesson07;

Enemy e1 = new Enemy("TalorTheVillain", EnemyType.Dragon);
//e1.SetName("Yakir");
Console.WriteLine(e1.GetName());
Console.WriteLine(e1.GetHealth());
e1.SetHealth(10);
Console.WriteLine(e1.GetHealth());

Console.WriteLine(e1.GetName());
Console.WriteLine(e1.GetHealth());

Enemy e2 = new Enemy();
//e2.SetName(null);
//e2.SetHealth(90);

Console.WriteLine(e2.GetName());
Console.WriteLine(e2.GetHealth());