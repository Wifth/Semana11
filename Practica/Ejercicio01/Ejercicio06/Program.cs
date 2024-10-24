// See https://aka.ms/new-console-template for more information

int[] num = new int[0];
int posicion = 0, datos;
char t;

Console.Write("Ingresar el número: ");
do
{

    while (!int.TryParse(Console.ReadLine(), out datos))
    {
        Console.Write("Error: Ingrese número: ");
    }
    Array.Resize(ref num, num.Length + 1);
    num[posicion] = datos;
    posicion++;

    do
    {
        Console.Write("\nDesea seguir registrando (s/n): ");
        t = char.ToLower(Console.ReadKey().KeyChar);
        Console.WriteLine();
    } while (t != 's' && t != 'n');

} while (t == 's');
Console.WriteLine("\nLista de números registrados: ");
foreach(int i in num)
Console.WriteLine(i);