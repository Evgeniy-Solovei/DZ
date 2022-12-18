// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

int[] CreateArr(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(0, 1000);
    }
    return number;
}
int[] PrintArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        Console.Write($"{numb[i]} ");
    }
    return numb;
}
int[] SumOddNumArr(int[] num)
{
    int sum = 0;
    for (int i = 1; i < num.Length; i = i + 2)
    {
        sum = sum + num[i];
    }
    Console.WriteLine($"Сумма нечётых элементов = {sum}");
    return num;
}

CreateArr(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
SumOddNumArr(array);