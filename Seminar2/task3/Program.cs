// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

// 6 -> да
// 7 -> да
// 1 -> нет

Console.WriteLine("Введите цифру от 1 до 7, обозначающую день недели: ");
int number1 = int.Parse(Console.ReadLine()!);
if (number1 < 6 && number1 > 0)
{
    Console.WriteLine("No");
}
else if (number1 > 5 && number1 < 8)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("Ошибка, вы ввели число меньше 1 или больше 7");
}