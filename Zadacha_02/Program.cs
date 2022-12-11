void Zadacha56()
{
    //Задача 56. Задайте прямоугольный двумерный массив. 
    //Напишите программу, которая будет находить строку с наименьшей суммой элементов.

    int rows = 4;
    int columns = 5;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    
}

void FillArray(int[,] numbers, int minValue = 5, int maxValue = 15)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            numbers[i, j] = rand.Next(minValue, maxValue);
            
        }
    }
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (numbers[i, j] <= minValue)
            {
                minValue = numbers[i, j];
                Console.WriteLine($"Наименьшее число {minValue} находится в строке {j + 1}");
            }
        }
    }
}

void PrintArray(int[,] numbers)
{
    {
        int rows = numbers.GetLength(0);
        int columns = numbers.GetLength(1);
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{numbers[i, j]}\t");
            }
            Console.WriteLine();
        }
    }
}

Zadacha56();