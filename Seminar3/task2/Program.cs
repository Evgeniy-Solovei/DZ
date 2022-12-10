// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в
//  3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write(" Введите кординат первой точки X: ");
double ax = double.Parse(Console.ReadLine()!);
Console.Write(" Введите кординат первой точки Y: ");
double ay = double.Parse(Console.ReadLine()!);
Console.Write(" Введите кординат первой точки Z: ");
double az = double.Parse(Console.ReadLine()!);
Console.Write(" Введите кординат второй точки X: ");
double bx = double.Parse(Console.ReadLine()!);
Console.Write(" Введите кординат второй точки Y: ");
double by = double.Parse(Console.ReadLine()!);
Console.Write(" Введите кординат второй точки Z: ");
double bz = double.Parse(Console.ReadLine()!);
double dist = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));
Console.Write($"Расстояние между точками А({ax};{ay};{az}) и B({bx};{by};{bz}) -->{Math.Round(dist, 2)}");