// See https://aka.ms/new-console-template for more information

int[] playersScores = {100, 50, 170};

for (int i = 0; i < playersScores.Length; i++)
{
    playersScores[i] *= 2;
    
    Console.WriteLine(playersScores[i]);   
}

float[] custom = new float[playersScores.Length];
custom[0] = 1.3f;
custom[1] = 2.4f;
custom[2] = 3.5f;
//enemeisScores[30] = 4.5f;

Console.WriteLine(custom[0]);