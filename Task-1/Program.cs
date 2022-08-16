// По двум заданным числам проверить, является ли первое квадратом второго
Console.Write("Введите первое число: ");
string numA = Console.ReadLine();
int a = int.Parse(numA);
Console.Write("Введите второе число: ");
string numB = Console.ReadLine();
int b = int.Parse(numB);

if (a == b * b)
{
    Console.WriteLine($"Число {a} является квадратом {b}");
}
else 
{
    Console.WriteLine($"Число {a} не является квадратом {b}");
}
