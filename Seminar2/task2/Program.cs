// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задумка была перевернуть число делением на 10 с остатком и добавлять остаток в максимальный индекс массива,
// затем уменьшать максимаьный индекс на 1 и добалять следующий остаток в массив. Затем вызвать индекс 2 (решив
// условие задачи,но у меня не вышло )
// Console.WriteLine("Введите число");
// int number1 = int.Parse(Console.ReadLine()!);
// int[]=new Array();
// int max_index;
// if (number1 > -99 || number1 > 99)
// {
//     max_index = number1 % 10;
//     max_index--;
//     Console.WriteLine("{numbers} [index 2]");
// }
// else
// {
//     Console.WriteLine($"В числе {number1} нет третьей цифры");
// }

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!);
int number2; // это будет перевернутое число number1
int number3; // переменная показывающая 3 цифру
if (number1 < -99 || number1 > 99)
{
    number2 = number1 % 10;
        number3=number2%10;
        number3=number2%10;
        number3=number2%10;
        Console.WriteLine(number3);
}
else
{
    Console.WriteLine($"В числе {number1} нет третьей цифры");
}

