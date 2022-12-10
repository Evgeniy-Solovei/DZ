// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

Console.Write("Введите 5-ти значное число: ");
int number1 = int.Parse(Console.ReadLine()!);
if (number1 > 9999 && number1 < 100000)
{
    int A = number1 % 10; 
    int B = number1 / 10000; 
        if (A == B)
        {
            int C = number1 / 10 % 10; 
            int D = number1 / 1000 % 10;
            if (C == D)
            Console.WriteLine("Yes !!!");
        }
        else Console.WriteLine("No !!!");    
}
else
{
    Console.WriteLine("Вы ввели не верное число. Повторите попытку.");
}

// Console.Write("Введите 5-ти значное число: ");
// int number1 = int.Parse(Console.ReadLine()!);

// if (number1 > 9999 && number1 < 100000)
// {
//     int A = number1 % 10;
//     int B = number1 / 10000;
//     int C = number1 / 10 % 10;
//     int D = number1 / 1000 % 10;
//     if (A == B && C == D)
//         Console.WriteLine("Yes !!!");
//     else Console.WriteLine("No !!!");
// }
// else
// {
//     Console.WriteLine("Вы ввели не верное число. Повторите попытку.");
// }