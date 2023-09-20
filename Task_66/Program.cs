// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. Выполнить с помощью рекурсии
// Console.WriteLine("Введите два числа");

int SumNaturalNumbers(int M, int N)
{
    if (M == 0) return (N * (N + 1)) / 2;            
    else if (N == 0) return (M * (M + 1)) / 2;       
    else if (M == N) return M;                  
    else if (M < N) return N + SumNaturalNumbers(M, N - 1); 
    else return N + SumNaturalNumbers(M, N + 1);            
}

Console.Write("Введите натуральнное число М = ");
int M = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральнное число N = ");
int N = Convert.ToInt32(Console.ReadLine());
if (M < 0 || N < 0) Console.Write("Введите натуральные числа");
else Console.WriteLine($"Cумму натуральных элементов в промежутке от M до N = {SumNaturalNumbers(M, N)}");


