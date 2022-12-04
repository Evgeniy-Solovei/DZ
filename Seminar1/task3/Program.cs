//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, 
//является ли число чётным (делится ли оно на два без остатка).
//
//4 -> да
//-3 -> нет
//7 -> нет

Console.Write("Введите число: ");
int number1 = int.Parse(Console.ReadLine()!);
double x = number1 % 2;
if (x > 0)
{
    Console.WriteLine("NO");
}
else
{
    Console.WriteLine("YES");
}