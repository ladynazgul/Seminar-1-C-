// Даны два числа. Показать большее и меньшее число

Console.Write("Введите первое число: ");
string numA = Console.ReadLine();
int a = int.Parse(numA);
Console.Write("Введите второе число: ");
string numB = Console.ReadLine();
int b = int.Parse(numB);

if (a > b)
{
    Console.WriteLine($"Число {a} больше чем {b}");
}
else
{
    Console.WriteLine($"Число {b} больше чем {a}");
}

// Вариант Юли, закоменчу его для примера
// Console.Write("Введите первое число: ");
// string numA = Console.ReadLine();
// int number1 = int.Parse(numA);
// Console.Write("Введите второе число: ");
// string numB = Console.ReadLine();
// int number2 = int.Parse(numB);

// int max = number1;
// int min = number2;

// if (number1 > number2)
// {
//     max = number1;
//     min = number2;
// }
// else
// {
//   min = number1;
//    max = number2;
// }

// Console.WriteLine(min);
// Console.WriteLine(max);