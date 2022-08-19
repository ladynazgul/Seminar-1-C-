// Удалить вторую цифру трёхзначного числа

Console.Clear();
System.Console.WriteLine("Введите трехзначное число: ");
int Number = int.Parse(Console.ReadLine() ?? "0");
int NewNumber = 0;

int NumberWithoutSecDig()
{
    NewNumber = Number / 100 * 10 + Number % 10;
    return NewNumber;
}

NumberWithoutSecDig();

System.Console.WriteLine();
System.Console.WriteLine($"Если из числа {Number} удалить вторую цифру, получится число {NewNumber}");
System.Console.WriteLine();