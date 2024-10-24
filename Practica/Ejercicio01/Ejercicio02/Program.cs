// See https://aka.ms/new-console-template for more information

int[] num = { 4, 8, 10, 25 };

Console.WriteLine("Lista original: ");
foreach (int i in num)
    Console.WriteLine(i);

Console.WriteLine("\nLista modificada: ");

num[2] = 36;
foreach (int i in num)
    Console.WriteLine(i);