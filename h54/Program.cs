// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] numbers = new int[4, 4];
System.Console.WriteLine("Исходный случайный массив");
InputArray(numbers);
PrintArray(numbers);

System.Console.WriteLine("Отсортированный по убыванию массив в каждой строке");
SortArray(numbers);
PrintArray(numbers);

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

void SortArray(int[,] numbers)
{
    int temp = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
            for (int k = j + 1; k < numbers.GetLength(1);k++)
                {
                    if (numbers[i,j] < numbers[i,k])
                    {
                        temp = numbers[i,j];
                        numbers[i,j] = numbers[i,k];
                        numbers[i,k] = temp;
                    }                   
                }            
        }
    }
}