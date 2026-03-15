using System.Numerics;

while (true)
{
    Console.WriteLine("Введите исходную строку( exit для выхода из программы )");
    string s1 = Console.ReadLine();
    if (s1 == "exit") return 0;
    Console.WriteLine("Введите строку для сравнения");
    string s2 = Console.ReadLine();
    int[,] LD = new int[s1.Length + 1, s2.Length + 1];
    for (int i = 0; i <= s1.Length; i++) 
    {
        for (int j = 0; j <= s2.Length; j++) 
        {
            if (i == 0 || j == 0) LD[i, j] = i + j;
            else if (i > j) LD[i, j] = LD[i - 1, j] + 1;
            else if (j < i) LD[i, j] = LD[i, j - 1] + 1;
            else if (i > 2 && j > 2 && s1[i - 1] == s2[j - 2] && s1[i - 2] == s2[j - 1]) LD[i, j] = LD[i - 2, j - 2] + 1;
            else if (s1[i - 1] != s2[j - 1]) LD[i, j] = LD[i - 1, j - 1] + 1;
            else LD[i, j] = LD[i - 1, j - 1];
        }
    }
    Console.WriteLine($"Расстояние Левенштейна равно {LD[s1.Length, s2.Length]}\n");
}
return 0;
