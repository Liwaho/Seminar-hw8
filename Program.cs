
/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

Console.WriteLine("Матрицы 3 на 3.");
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


/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

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