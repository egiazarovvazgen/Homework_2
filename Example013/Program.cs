// Программа, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

Console.WriteLine("Введите число: ");
int num = int.Parse(Console.ReadLine()!);

if (num > 99)
{
    int ShowThirdDigit(int num)
    {
        while (num > 999)
        {
            num = num / 10;
        }
        int thirdDigit = num % 10;
        return thirdDigit;
    }
    Console.WriteLine("Третья цифра заданного числа: " + ShowThirdDigit(num));
}
else
{
    Console.WriteLine("Третьей цифры нет");
}