/*
Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.Write("Введите число M: ");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число N: ");
int userNumberN = Convert.ToInt32(Console.ReadLine());

printRange(userNumberM, userNumberN);

void printRange(int M, int N)
{
    Console.WriteLine(SumNum(M - 1, N));
}

int SumNum(int M, int N)
{
    int score = M;
    if (M == N)
        return 0;
    else
    {
        M++;
        score = M + SumNum(M, N);
        return score;
    }
}