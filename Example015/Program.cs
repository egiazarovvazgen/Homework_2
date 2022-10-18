// Программа, которая принимает на вход цифру, обозначающую день недели, 
// и проверяет, является ли этот день выходным

Console.WriteLine("Введите номер дня недели: ");
int num = int.Parse(Console.ReadLine()!);

if (multiplicity(num))
{
    Console.WriteLine("Это выходной день");
}
else
{
    Console.WriteLine("Это не выходной день");
}

bool multiplicity(int num)
{
    return 8 > num && num > 5;
}