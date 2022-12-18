// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];

int[] CreateArr(int[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().Next(100, 1000);
    }
    return number;
}
int[] PrintArray(int[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        Console.Write($"{numb[i]}," );
    }
    return numb;
}
int [] EvenNumArr(int[] num)
{
    int count1=0;
    for (int i=0;i<num.Length;i++)
    if (num[i]%2==0)
    {
        count1=count1+1;
    }
    Console.WriteLine(count1);
    return num;

    // int i =0;
    // int count =0;
    // if (i<num.Length-1)
    // {
    //     if (num[i]%2<0)
    //     {
    //         count=count+1;
    //         i++;
    //     }
    // }
    // else
    // {
    //     i++;
    // }
    // Console.WriteLine(count);
    // return num;

}    
    

CreateArr(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
EvenNumArr(array);

// int[] array = new int[8];
// int[] InputArr(int[] number)
// {
//     for (int i = 0; i < number.Length; i++)
//     {
//         Console.Write($"Введите элемент массива под индексом {i}: "); 
//         number[i] = int.Parse(Console.ReadLine()!);
//     }
//     return number;
// }
// int[] PrintArray(int[] number)
// {
//     Console.Write("Array - [");
//     for (int i = 0; i < number.Length; i++)
//     {
//         Console.Write($"{number[i]}," );
//     }
//     Console.Write("\b1]");
//     return number;
// }



