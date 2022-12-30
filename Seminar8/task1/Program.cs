// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2.     1 2 3 4 5
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
int[,] GetArray(int m, int n) //Создаём метод с названием GetArray с аргументами m - строки. n - столбцы. 
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 11);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)   // Создали метод для вывода массива в консоль
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int[,] maxToMin(int[,] maxMin)
{

    for (int i = 0; i < maxMin.GetLength(0); i++)
    {
        for (int j = 0; j < maxMin.GetLength(1); j++)
        {
            for (int k = 0; k < maxMin.GetLength(1) - 1; k++)
            {
                if (maxMin[i, k] < maxMin[i, k + 1])
                {
                    int max = maxMin[i, k + 1];
                    maxMin[i, k + 1] = maxMin[i, k];
                    maxMin[i, k] = max;
                }
            }
        }
    }
    return maxMin;
}

int[,] array = GetArray(4, 3);
PrintArray(array);
maxToMin(array);
Console.WriteLine();
PrintArray(array);
