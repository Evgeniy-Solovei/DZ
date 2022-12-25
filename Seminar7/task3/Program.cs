// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

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
double ValueColumn(int[,] number) //Aргумент двухмерный массив. 
{
    double sum = 0; // переменная суммы значений в столбце
    double result = 0;
    for (int j = 0; j < number.GetLength(1); j++)
    {
        for (int i = 0; i < number.GetLength(0); i++)
        {
            sum = sum + number [i,j]; // суммируем значения индексов в столбце
            //count++;
        }
        result=sum/number.GetLength(0);
        Console.Write(result+" "); // выводим среднее значение столбца
        sum=0;
    }
    return result; //не знаю вообще что тут возвращать и зачем
}
int[,] array = GetArray(4, 3);
PrintArray(array); 
Console.WriteLine();
Console.WriteLine();
ValueColumn(array);
Console.WriteLine();
Console.WriteLine();
