// Задача 45: Напишите программу, которая будет создавать копию заданного массива с 
// помощью поэлементного копирования.

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] number = new int[size];
    for(int i = 0; i<size; i++)
    {
        number[i]=new Random().Next(minValue,maxValue+1);
    }
    return number;
}

int[] PrintArray(int[] number)
{
    Console.Write("Array - ");
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{number[i]} " );
    }
    return number;
}

int[] ReversArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for(int i =0; i<inArray.Length;i++)
    {
        result[i]=inArray[inArray.Length-1-i];
    }
    return result;
}

int[] zoom =GetArray(10, 0, 100);
PrintArray(zoom);
Console.WriteLine();
ReversArray(zoom);
PrintArray(zoom);
