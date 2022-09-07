// программа, кот принимает на вход пятизначное число и проверяет, является ли оно палиндромом

void CheckNumber(int number)
{
    int x1 = number / 10000;
    int x2 = number % 10;
    int y1 = number % 10000 / 1000;
    int y2 = number % 100 / 10;
    if (x1 == x2 && y1 == y2)
    {
        Console.WriteLine("Это палиндром!");
    }
    else
        Console.WriteLine("Это не палиндром");
}

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
CheckNumber(number);

