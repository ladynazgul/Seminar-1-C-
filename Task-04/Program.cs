// Выяснить, является ли число четным
Console.Write("Введите число: ");
string num = Console.ReadLine();
int a = int.Parse(num);

if (a % 2 == 0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}