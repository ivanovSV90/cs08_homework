// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


int[,] numbersA = new int[3, 3];
System.Console.WriteLine("Случайная матрица A");
InputArray(numbersA);
PrintArray(numbersA);

int[,] numbersB = new int[3, 2];
System.Console.WriteLine("Случайная матрица B");
InputArray(numbersB);
PrintArray(numbersB);


int[,] numbersC = new int[numbersA.GetLength(0), numbersB.GetLength(1)];
MultiplicationArray(numbersA, numbersB, numbersC);



void InputArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            numbers[i, j] = new Random().Next(0, 10);
        }
    }
}


void PrintArray(int[,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            System.Console.Write($"{numbers[i, j],4}");
        }
        System.Console.WriteLine();
    }
}

void MultiplicationArray(int[,] numbersA, int[,] numbersB, int[,] numbersC)
{
    if (numbersA.GetLength(1) == numbersB.GetLength(0))
    {
        for (int i = 0; i < numbersC.GetLength(0); i++)
        {
            for (int j = 0; j < numbersC.GetLength(1); j++)
            {
                for (int k = 0; k < numbersC.GetLength(1); k++)
                {
                    numbersC[i, j] += numbersA[i, k] * numbersB[k, j];
                }
            }
        }
        System.Console.WriteLine("Произведение двух матриц");
        PrintArray(numbersC);
    }
    else System.Console.WriteLine("Нельзя умножать матрицы с такими размерами");
}