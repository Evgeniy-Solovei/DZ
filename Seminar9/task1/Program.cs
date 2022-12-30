// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NaturalN(int N)
{
    if(1==N)
    {
        return 1.ToString();
    }
    return (N+" "+NaturalN(N-1)); 
}

Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(NaturalN(N));
