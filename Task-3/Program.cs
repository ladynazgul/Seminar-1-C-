// Показать числа от -N до N

Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");

for (int i = -n; i <= n; i++)
{
    Console.WriteLine(i);
}
Console.ReadKey();