/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/ 

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

void PrintNumbers(int number, int count, int sum)
{
    if (count <= number)
    {
        sum = sum + count;
        PrintNumbers(number, count + 1, sum);
    }
    else Console.WriteLine(sum);
}

int numberM = GetNumber("Введите число M:");
int numberN = GetNumber("Введите число N:");
int summ = 0;
PrintNumbers(numberN, numberM, summ);