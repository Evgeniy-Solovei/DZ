// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29



int Akkerman(int M, int N)
{
    if (M == 0)
    {
        return N + 1;
    }
    else if (N == 0 && M> 0)
    {
        return Akkerman(M - 1, 1);
    }
    else
    {
        return (Akkerman(M - 1, Akkerman(M, N - 1)));
    }
}


Console.WriteLine("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine(Akkerman(M, N));

// int NaturalNM(int M, int N)
// {
//     if (M == 0)
//     {
//         return N + 1;
//     }
//     if (M == 1)
//     {
//         return N + 2;
//     }
//     if (M == 2)
//     {
//         return 2 * N + 3;
//     }
//     else
//     {
//         if (M == 3)
//         {
//             return 2 ^ (N + 3) - 3;
//             //    return(NaturalNM(2^N+3-3,M));
//         }
//     }
//     return (NaturalNM(2 ^ (N + 3) - 3, M));
//     Console.WriteLine(NaturalNM(N, M));
// }