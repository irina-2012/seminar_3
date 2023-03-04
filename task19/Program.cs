// Задача 19  Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет  0  1   2   3   4   
// 12821 -> да   1  2  8   2    1
// 23432 -> да
Console.Clear();
Console.WriteLine("Введите пятизначное число: ");
string num = Console.ReadLine();

void Number(string num)
{
    if (int.Parse(num) > 1000 && int.Parse(num) < 100000)
    {
        if (num[0] == num[4] && num[1] == num[3])
        { Console.WriteLine($"{num} -> да"); }
        else Console.WriteLine($"{num} -> нет");
    }
    else Console.WriteLine("Введено неверное число");
}
Number(num);