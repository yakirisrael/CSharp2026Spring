
LinkedList<string> monsters = new();// {"Balor", "TalOrc", "Zombie"};
Console.WriteLine("Count = " + monsters.Count);
monsters.AddLast("Talor");
monsters.AddLast("Talor2");

//Console.WriteLine("Count = " + monsters.Count + " Capacity = " + monsters.Capacity);

monsters.Remove("Zombie");

var node = monsters.Find("Talor");
if (node != null)
    Console.WriteLine(node.Next.Previous.Value);


/*
//monsters.Insert(0, "ZombieReturn");
foreach (string monster in monsters)
{
    Console.WriteLine(monster);
}
monsters.Add("Add");

monsters.Clear();
monsters.TrimExcess();
monsters.Add("Add");

Console.WriteLine("Count = " + monsters.Count + " Capacity = " + monsters.Capacity);


Console.WriteLine("is contain = " + monsters.Contains("ZombieReturn"));
*/