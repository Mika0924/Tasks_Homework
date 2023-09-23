// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите n: ");
int n = Convert.ToInt32(Console.ReadLine());

A(m,n);

int Ackermann(int m,int n) //Формула аккермана больше 4м не работает 
{
    if(m==0) return n+1;
    else if(m>0 && n==0) return Ackermann(m-1, 1);
    else return Ackermann(m - 1,Ackermann(m,n-1));
}

void A(int m,int n) 
{
    Console.WriteLine($"m = {m}, n = {n} -> A(m,n) = {Ackermann(m,n)}");
}


