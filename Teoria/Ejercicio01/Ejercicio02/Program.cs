// See https://aka.ms/new-console-template for more information

Console.WriteLine("Ingrese cantidad de elementos: ");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];
Random ran = new Random();

for (int x = 0; x < n; x++) 
{
    numeros[x] = ran.Next(10, 99 + 1);    
}

string todos = String.Join(", ", numeros);
Console.WriteLine($"Números: {todos}");