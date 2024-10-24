// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

string[] edificio1 = new string[5];
for (int x = 0; x < edificio1.Length; x++)
{
    Console.WriteLine($"Ingrese nombre {x + 1}: ");
    edificio1[x] = Console.ReadLine();
}
Console.Clear();
for (int x = 0; x < edificio1.Length; x++)
{
    Console.WriteLine(edificio1[x]);
}
Console.WriteLine();
string[] edificio2 = { "Tú", "Papás", "Hermano", "Tío", "Primo" };
foreach (string e in edificio2)
{
    Console.WriteLine(e);
}