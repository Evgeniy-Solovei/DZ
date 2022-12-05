// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Задумка была перевернуть число делением на 10 с остатком и добавлять остаток в индекс 0 массива,
// затем увеличивать  индекс0 на 1 и добавлять следующий остаток в массив. Затем вызвать индекс 2 массива (решив
// условие задачи,но у меня не вышло.)
// Console.WriteLine("Введите число");
// int number1 = int.Parse(Console.ReadLine()!);
// int[]=new Array();
// int max_index;
// if (number1 > -99 || number1 > 99)
// {
//     max_index = number1 % 10;
//     max_index++;
//     Console.WriteLine("{numbers} [index 2]");
// }
// else
// {
//     Console.WriteLine($"В числе {number1} нет третьей цифры");
// }

// Console.WriteLine("Введите число");
// int number1 = int.Parse(Console.ReadLine()!);
// int number2 = 0;
// int number3 = 0; // это будет перевернутое число number1
// int number4 = 0; // 3 цифра number1
// while (number1 > 0) 
// {
//     number2 = number1 % 10; // по какой формуле перевернуть число искал в гугле, сам не додумался. Я думал что надо %, добавлять в переменную, затем число без прошлого остатка опять % и добавлять в перемееную.Как в переменную просто складывать число одно за другим без каких либо математических действий я не нашёл.
//     number1 = number1 / 10;
//     number3 = number3 * 10 + number2;
// }
// {
//     number3 = number3 / 100;
//     number4 = number3 % 10;

// }
// if (number1 < -100 || number1 < 99)
// {
//     Console.WriteLine(number4);
// }
// else
// {
//     Console.WriteLine($"В числе {number1} нет третьей цифры");
// }

Console.WriteLine("Введите число");
int number1 = int.Parse(Console.ReadLine()!); // можно было использовать переменную long из за возможности ввести больше числа
while (number1 > 1000)
{
    number1 = number1 / 10;
}
if (number1 < 1000)
{
    number1 = number1 % 10;
    Console.WriteLine(number1);
}
else
{
    Console.WriteLine($"В числе {number1} нет третьей цифры");
}
