// Показать последнюю цифру трехзначного числа

int number = new Random().Next(100, 1000);
int a = number % 10;
Console.WriteLine("Число: " + number);
Console.WriteLine("Последняя цифра: " + a);
Console.ReadKey(true);