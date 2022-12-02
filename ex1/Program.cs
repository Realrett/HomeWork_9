/* Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
в промежутке от N до 1. Выполнить с помощью рекурсии.
N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" */

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

string recursy(int num)
{
    string str = string.Empty;
    if (num == 1) return num.ToString();
    return num + " " + recursy(num - 1);
}

int n = GetNumber("Введите число N: ");
Console.WriteLine();
Console.WriteLine(recursy(n));