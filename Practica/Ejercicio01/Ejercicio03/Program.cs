
using System.Security.Cryptography;

string[] nom = { "jose", "oscar", "carmen", "alexa" };

Console.Write("Ingrese un nombre a buscar: ");
string buscar = Console.ReadLine();

int indice = Array.IndexOf(nom, buscar);

if (indice != -1)
{
    Console.WriteLine($"{buscar} está en la posición {indice}");
}
else
    Console.WriteLine("No existe");