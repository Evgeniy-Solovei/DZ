// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
int[] InputArr(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"Введите элемент массива под индексом {i}: "); 
        number[i] = int.Parse(Console.ReadLine()!);
    }
    return number;
}
int[] PrintArray(int[] number)
{
    Console.Write("Array - [");
    for (int i = 0; i < number.Length; i++)
    {
        Console.Write($"{number[i]}," );
    }
    Console.Write("\b]");
    return number;
}

InputArr(array);
PrintArray(array);


