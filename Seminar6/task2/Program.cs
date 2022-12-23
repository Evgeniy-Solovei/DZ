// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите значение b1, k1, b2, k2 через пробел: ");
string [] qwa=Console.ReadLine()!.Split();
double b1 = double.Parse(qwa[0]);
double k1 = double.Parse(qwa[1]);
double b2 = double.Parse(qwa[2]);
double k2 = double.Parse(qwa[3]);
Console.WriteLine(String.Join(" ", GetPoint(b1,k1,b2,k2)));

double [] GetPoint (double inb1, double ink1, double inb2, double ink2)
{
    double[] result = new double [2];
    result[0]=(inb2-inb1)/(ink1-ink2);
    result[1]=ink1*result[0]+inb1;
    return result;
}
GetPoint(b1,k1,b2,k2);

// double [] GetPoint (double [] array)
// {
//     double[] result = new double [2];
//     result[0]=(b2-b1)/(k1-k2);
//     result[1]=k1*result[0]+b1;
//     return result;
// }
// GetPoint(b1,k1,b2,k2);