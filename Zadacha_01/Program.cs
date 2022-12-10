void Zadacha54()
{
    //Задача 54. Задайте двумерный массив. Напишите программу,
    //которая упорядочит по убыванию элементы каждой строки двумерного массива.

    int rows = 3;
    int columns = 4;
    int[,] numbers = new int[rows, columns];
    FillArray(numbers);
    PrintArray(numbers);
    RegulateArray(numbers);
    Console.WriteLine("Перевернутый массив по строкам  ");
    PrintArray(numbers);




    void FillArray(int[,] numbers, int minValue = 0, int maxValue = 9)
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
    }

    void PrintArray(int[,] numbers)
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
    void RegulateArray(int[,] numbers)
    {
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                for (int m = 0; m < columns - 1; m++)
                    if (numbers[i, m] < numbers[i, m + 1])
                    {
                        int temp = numbers[i, m + 1];
                        numbers[i, m + 1] = numbers[i, m];
                        numbers[i, m] = temp;
                    }
            }

        }
        int InputNumbers(string input)
        {
            Console.Write(input);
            int output = Convert.ToInt32(Console.ReadLine());
            return output;
        }
    }
}
Zadacha54();