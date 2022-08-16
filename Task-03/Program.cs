// Найти максимальное из трех чисел
Console.Write("Введите первое число: ");
string A = Console.ReadLine();
int a = int.Parse(A);
Console.Write("Введите второе число: ");
string B = Console.ReadLine();
int b = int.Parse(B);
Console.Write("Введите третье число: ");
string C = Console.ReadLine();
int c = int.Parse(C);

int max = a;

if (a > max) max = a;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("max = ");
Console.WriteLine(max);

// В таком варианте нужно после каждого числа нажимать "ентер", иначе программа зависает. Мой изначальный вариант был лучше.
