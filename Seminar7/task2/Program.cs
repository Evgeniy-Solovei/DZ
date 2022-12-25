// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:           1 4 7 2
//                                   5 9 2 3
//                                   8 4 2 4       17 -> такого числа в массиве нет
int[,] GetArray(int m, int n) //Создаём метод с названием GetArray с аргументами m - строки. n - столбцы. 
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(-20, 20);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
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
void numberArray(int [,] array, int rows, int columns)
{
    int m = 4;
    int n = 5;
    if (rows > m || columns > n)
    {
        Console.WriteLine("Такого числа в массиве нет. ");
    }
    else
    {
        Console.WriteLine($"{array [rows,columns]}");
    }
}
int[,] array = GetArray(4, 5);
PrintArray(array);
Console.WriteLine("Введите строку искомого числа в массива m:");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите столбец искомого числа массива n:");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine();
numberArray(array, rows, columns);
