// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите первое число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите заданное число: ");
int b = int.Parse(Console.ReadLine() ?? "0");

if (a % b == 0)
{
    Console.WriteLine($"Число {a} кратно числу {b}");
}

else
{
    Console.WriteLine($"Остаток равен {a % b}");
}
