/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

/*Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
Console.WriteLine("До изменения:");
Random(array);
Print(array);
Console.WriteLine("");
Console.WriteLine("После изменения:");
Descending(array);
Print(array);

void Random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 99);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int index = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}

void Descending(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1)-1; j++)
        {
            for (int d = 0; d < array.GetLength(1)-1; d++)
            {
                if (array[i, d] < array[i, d+1])
                {
                    int desc = 0;
                    desc = array[i, d];
                    array[i,d] = array[i, d+1];
                    array[i, d+1] = desc;
                }
            }
        }
    }
}*/

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

/*Console.WriteLine("Количество строк: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Количество столбцов: ");
int n = int.Parse(Console.ReadLine());
int[,] array = new int[m, n];
int min = Int32.MaxValue;
int line = 0;
Random(array);
Print(array);
Console.WriteLine();

   for (int i = 0; i < array.GetLength(0); i++)
{
    int a = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        a = (a + array[i, j]);
    }
    if (a < min)
    {
        min = a;
        line++;
    }
    Console.WriteLine("Сумма по " + i + " строке : " + a + "; "); 
}

Console.WriteLine("Строка " + line + " с наименьшей суммой элементов.");

void Random(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 99);
        }
    }
}

void Print(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine("");
    }
}*/

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

/*Console.WriteLine("Матрицы 3 на 3.");
Console.WriteLine("");
int[,] array1 = new int[3, 3];
Console.WriteLine("Первая:");
Random(array1);
Print(array1);
Console.WriteLine("");
Console.WriteLine("Вторая:");
int[,] array2 = new int[3, 3];
Random(array2);
Print(array2);
Console.WriteLine("");
Console.WriteLine("Произведение:");
int[,] array3 = new int[3, 3];

for (int i = 0; i < array3.GetLength(0); i++)
    {
        for (int j = 0; j < array3.GetLength(1); j++)
        {
            for (int a = 0; a < array3.GetLength(1); a++)
            {
                array3[i, j] = array3[i,j]+(array1[i,a]*array2[a,j]);
            }
        }
    }
Print(array3);

void Random(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 9);
        }
    }
}

void Print(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + " ");
        }
        Console.WriteLine("");
    }
}
*/

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Console.WriteLine("Размер массива: ");
int size = int.Parse(Console.ReadLine());
int[,,] array = new int[size, size, size];
Console.WriteLine("Массив:");
Random(array);
Print(array);

void Random(int[,,] array)
{
    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            for (int z = 0; z < size; z++)
                {
                    array[i, j, z] = new Random().Next(10, 99);
                }
        }
    }
}

void Print(int[,,] array)
{
    for (int i = 0; i < size; i++)
    {
        int index = 0;
        for (int j = 0; j < size; j++)
        {
            for (int z = 0; z < size; z++)
                {
                    Console.Write($" {array[i, j, z]}({i}, {j}, {z})");
                }
        }
        Console.WriteLine("");
    }
}

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

/*Если решено:
1-2 задачи - удовлетворительно
3-4 - хорошо
5 - отлично

Рекомендовано решить(задача с семинара): Отсортировать нечетные столбцы массива по возрастанию. Вывести массив изначальный и массив с отсортированными нечетными столбцами*/