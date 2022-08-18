// Вывести квадрат числа
// Console.Write("Введите число: ");
// string num = Console.ReadLine();
// int a = int.Parse(num);
// int result = a * a;
// Console.WriteLine(result);

// Вариант препода

Console.Write("Enter a number: ");
int number = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Square of number is " + (number*number));