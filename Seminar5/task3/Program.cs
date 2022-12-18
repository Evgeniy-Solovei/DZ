// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

Console.WriteLine("Введите количество элементов массива");
int n = int.Parse(Console.ReadLine()!);
double[] array = new double[n];

double[] CreateArr(double[] number)
{
    for (int i = 0; i < number.Length; i++)
    {
        number[i] = new Random().NextDouble()*100;
    }
    return number;
}
double[] PrintArray(double[] numb)
{
    for (int i = 0; i < numb.Length; i++)
    {
        Console.Write($"{numb[i]} ");
    }
    return numb;
}
double[] diffMinMax(double[] num)
{
    double min= num[0];
    double max= num[0];
    for(int i = 1; i < num.Length; i++)
    {
        if (max<num[i])
        {
            max=num[i];
        }
        if (min>num[i])
        {
            min=num[i];
        } 
    }
    double diff=max-min;
    Console.WriteLine($"Разность между максимальным и минимальным элементом = {diff} ");
    return num;
}

CreateArr(array);
Console.WriteLine();
PrintArray(array);
Console.WriteLine();
Console.WriteLine();
diffMinMax(array);