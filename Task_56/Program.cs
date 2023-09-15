// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
int row = InputNumbers("Введите строку: ");
int column = InputNumbers("Введите столбец: ");
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[row, column];
CreateArray(array);
WriteArray(array);

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void WriteArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}

int MinLine = 0;
int Sum = LineElements(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempLine = LineElements(array, i);
    if (Sum > tempLine)
    {
        Sum = tempLine;
        MinLine = i;
    }
}

Console.WriteLine($"{MinLine + 1} строкa с наименьшей суммой ({Sum})");

int (int[,] array, int i)
{
    int Sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        Sum += array[i, j];
    }
    return Sum;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}



