// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

int x = new Random().Next(10, 100);
Console.WriteLine($"Дано число {x}");
string s = x.ToString();

int a = int.Parse(s[0].ToString());
int b = int.Parse(s[1].ToString());

if (a>b)
{
    Console.WriteLine($"Наибольшая цифра {a}");
}
else
{
    Console.WriteLine($"Наибольшая цифра {b}");
}