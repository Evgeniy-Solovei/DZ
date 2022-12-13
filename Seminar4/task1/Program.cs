// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)

// 2, 4 -> 16

Console.WriteLine("Введите число А: ");
int num1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число В: ");
int num2 = int.Parse(Console.ReadLine()!);
int count = 0;
int result =1;
while (count < num2)
{
    result=result*num1;
    count++;
}
Console.WriteLine($"{num1} в степени {num2} = {result}");
