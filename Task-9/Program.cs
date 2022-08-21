// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число: ");
int a = int.Parse(Console.ReadLine() ?? "0");

if (a / 100 > 0)
{
    Console.WriteLine($"Третьей цифрой числа {a} является {a % 10}");
}
else
{
    Console.WriteLine($"У числа {a} нет третьей цифры");
}