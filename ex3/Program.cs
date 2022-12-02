/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
   Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29 */

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int AckermannFunction (int numberM, int numberN)
{
    if (numberM == 0) return numberN + 1;
    if (numberM != 0 && numberN == 0) return AckermannFunction(numberM - 1, 1);
    if (numberM > 0 && numberN > 0) return AckermannFunction(numberM - 1, AckermannFunction(numberM, numberN - 1));
return AckermannFunction(numberM, numberN);
}


int numberM = GetNumber("Введите число M:");
int numberN = GetNumber("Введите число N:");
Console.Write(AckermannFunction(numberM, numberN));