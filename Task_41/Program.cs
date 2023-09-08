// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] Array = new int[M];
void CountNumbersGreaterZero (int M)
{
for (int i = 0; i < M; i++)
{
Console.Write($"Введите массив под номером {i+1}: ");
Array[i] = Convert.ToInt32(Console.ReadLine());
}
}
int Total (int[] Array)
{
int i=0, sum = 0;
while (i < Array.Length)
{
if(Array[i]>0)
sum++; i++;
}
return sum;
}
CountNumbersGreaterZero(M);
Console.Write($"Из {M} чисел {Total(Array)} больше нуля");

