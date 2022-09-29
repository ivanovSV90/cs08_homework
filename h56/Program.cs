// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] numbers = new int[4, 4];
System.Console.WriteLine("Случайный массив");
InputArray(numbers);
PrintArray(numbers);
System.Console.WriteLine($"Строка с наименьшей суммой элементов № {SearchSmallestSumStringArray(numbers) + 1}");

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

int SearchSmallestSumStringArray(int[,] numbers)
{
    int[] tempArray = new int[numbers.GetLength(1)];
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            tempArray[i] += numbers[i, j];
        }
    }
    
    int min = 0;
    for (int k = 1; k < tempArray.Length; k++)
    {
        if (tempArray[k] < tempArray[min])
            min = k;
    }
    return min;
}