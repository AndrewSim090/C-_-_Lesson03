Console.Clear();
Console.Write("Введите пятизначное число: ");
string UserNamber1 = Console.ReadLine() ?? "";
int number_a = int.Parse(UserNamber1);

if (number_a >= 10000 && number_a <= 100000)
{
    int numA = number_a % 10;
    int numB = number_a / 10000;
    if (numA == numB)
    {
        int numA1 = number_a % 100 / 10;
        int numB1 = number_a / 1000 % 10;
        if (numA1 == numB1)
        {
            Console.Write($"{number_a} - Является палиндромом");
        }
    }

    else
    {
        Console.WriteLine($"{number_a} - НЕ является палиндромом");
    }
}
else
{
    Console.WriteLine("Ошибка!");
}