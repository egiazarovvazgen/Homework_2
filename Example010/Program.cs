// Программа, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа

Console.WriteLine("Введите трёхзначное число: ");
int num = int.Parse(Console.ReadLine()!);

int ShowSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = (num - firstDigit * 100) / 10;
    return secondDigit;
}

int secondDigit = ShowSecondDigit(num);
Console.WriteLine("Вторая цифра этого числа: " + secondDigit);