// See https://aka.ms/new-console-template for more information
using Lesson06;

Item it = new Item();
it.name = "Mighty Axe";
it.type = ItemType.Axe;
it.PrintInfo();

Item it2 = new Item();
it2.name = "Magniv Talor";
it2.type = ItemType.TalorMagic;
it2.PrintInfo();

ItemType type = ItemType.TalorMagic;
Console.WriteLine(type);
Console.WriteLine((int)type);
type = ItemType.Dagger;
Console.WriteLine(type);
Console.WriteLine((int)type);

/*double[] playersScores = {100.3, 50.2, 170};

double sum = 0;
foreach (double score in playersScores)
{
   sum += score;
}

Console.WriteLine("sum = " + sum);


string s = "Talor Porat";
Console.WriteLine("length = " + s.Length);
int spaceIndex = s.IndexOf(" ");
Console.WriteLine(s.Substring(spaceIndex).Trim());
string Borat = s.Replace("P", "B");
Console.WriteLine(Borat.ToLower());
Console.WriteLine(Borat.Contains("orat"));


char[] characters = Borat.ToCharArray();
Console.WriteLine(characters[3]);
foreach (char c in characters)
{
   Console.WriteLine(c);
}*/








