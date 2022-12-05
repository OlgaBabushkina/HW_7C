/* Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

int rows = ReadInt("Введите количество строк в массиве: ");
int columns = ReadInt("Введите количество столбцов в массиве: ");
double[,] array = new double[rows, columns];
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = Math.Round(new Random().NextDouble() * 20 - 10, 1);
        Console.Write(array[i, j] + "   ");
    }
    Console.WriteLine();
}

/* Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет. 
Во вводе первая цифра - номер строки, вторая - столбца. Цифры не больше 9.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет */

int rows = new Random().Next(0, 10);
int columns = new Random().Next(0, 10);
int[,] array = new int[rows, columns];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("Введите позицию искомого элемента в двухмерном массиве: ");
int index = Convert.ToInt16(Console.ReadLine());
if (index / 10 < array.GetLength(0) && index % 10 < array.GetLength(1))
{
    Console.Write(array[index / 10, index % 10]);
}
else Console.Write("такого числа в массиве нет");

/* Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */

int rows = new Random().Next(0, 10);
int columns = new Random().Next(0, 10);
int[,] array = new int[rows, columns];
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = new Random().Next(0, 10);
        Console.Write(array[i, j] + "   ");
    }

    Console.WriteLine();
}
Console.WriteLine();
double average = 0;

for (int i = 0; i < array.GetLength(1); i++)
{
    for (int j = 0; j < array.GetLength(0); j++)
    {
        average = average + array[j, i];
    }
    average = average / rows;
    Console.Write(Math.Round(average, 1) + " ");
    average = 0;
}

