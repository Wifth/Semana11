// See https://aka.ms/new-console-template for more information

char[] nom = { 'a', 'e', 'i', 'o', 'u' };
Console.WriteLine("Lista original: ");
foreach (char c in nom) 
    Console.WriteLine(c);
    Console.WriteLine();

Console.Write("Ingresar el caracter a modificar: ");
char modificar = char.Parse(Console.ReadLine());

int indice = Array.IndexOf(nom, modificar);

if (indice != -1) 
{
    Console.Write("Ingrese un nuevo caracter: ");
    char b = char.Parse(Console.ReadLine());
    Console.WriteLine("\nLista modificada: ");
    nom[indice] = modificar;
    foreach (char c in nom)
        Console.WriteLine(c);
}
else
{
    Console.WriteLine("\nNo se puede modificar, no existe");
}



