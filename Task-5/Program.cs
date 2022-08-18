// Показать вторую цифру трёхзначного числа

int number = new Random().Next(100, 1000);
int a = (number % 100 - number % 10) / 10;
Console.WriteLine("Число: " + number);
Console.WriteLine("Вторая цифра: " + a);
Console.ReadKey(true);