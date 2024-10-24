// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

string[] edificio1 = new string[5];
for (int x = 0; x < edificio1.Length; x++)
{
    Console.Write($"Ingrese nombre {x + 1}: ");
    edificio1[x] = Console.ReadLine();
}
Console.Clear();
for (int x = 0; x < edificio1.Length; x++)
{
    Console.WriteLine(edificio1[x]);
}
Console.WriteLine();
string[] edificio2 = { "tu", "papas", "hermano", "tio", "primo" };
foreach (string e in edificio2)
{
    Console.WriteLine(e);
}
Console.WriteLine("\n¿A quién busca en edificio 2?: ");
string bus = Console.ReadLine().ToLower();
for (int x = 0; x < edificio2.Length; x++)
{
    if (edificio2[x] == bus)
    {
        Console.Write($"\nEstá en el piso {x + 1}");
        break;
    }
}