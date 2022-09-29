// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


int[,] numbers = new int[4, 4];
CreateSpiralArray(numbers);
PrintArray(numbers);


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

void CreateSpiralArray(int[,] numbers)
{
    int count = 1;
    int i = 0;
    int j = 0;
    while (count < numbers.GetLength(0) * numbers.GetLength(1) + 1)
    {
        numbers[i, j] = count++;

        if (i <= j + 1 && i + j < numbers.GetLength(1) - 1)
        {
            j++;
        }
        else if (i < j && i + j >= numbers.GetLength(0) - 1)
        {
            i++;
        }
        else if (i >= j && i + j > numbers.GetLength(1) - 1)
        {
            j--;
        }
        else
        {
            i--;
        }
    }
}

