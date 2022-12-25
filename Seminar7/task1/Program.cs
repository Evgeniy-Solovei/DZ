// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

double[,] GetArray(int m, int n) //Создаём метод с названием GetArray с аргументами m - строки. n - столбцы. 
{
    double[,] result = new double[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
               result[i, j] = Math.Round(new Random().NextDouble()+new Random().Next(-10, 10),2); // math.round(number,2)где number - вещественное число у которого мы ходим оставить (2), знака после запятой 
        }
    }
    return result;
}

double [,] PrintArray(double [,] inArray) 
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write(inArray[i, j] + "  ");
        }
        Console.WriteLine();
        Console.WriteLine();
    }
    return inArray;
}


Console.WriteLine("Введите колличество строк массива m:");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите колличество столбцов массива n:");
int columns = int.Parse(Console.ReadLine()!);
double [,] array = GetArray(rows,columns);
PrintArray(array);
