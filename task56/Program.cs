/*
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер 
строки с наименьшей суммой элементов:
 1 строка
*/

int[,] array = GetArray(4, 4);
PrintArrD2(array);
Console.WriteLine();
int[] myArr = SumArr(array);
MinArr(myArr);

int[,] GetArray(int row, int col)
{
    int[,] arr = new int[row, col];
    Random rnd = new Random();

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = rnd.Next(-10, 10);
        }
    }
    return arr;
}

int[] SumArr(int[,] arr)
{
    int[] array = new int[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            sum += arr[i, j];
        }
        array[i] = sum;
        Console.WriteLine("Сумма строки " + (i + 1) + " = " + sum);

    }
    return array;
}

void PrintArrD2(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

void MinArr(int[] Arr)
{
    int min = Arr[0];
    int indMin = 0;
    for (int i = 1; i < Arr.Length; i++)
    {
        if (min > Arr[i])
        {
            min = Arr[i];
            indMin = i;
        }
        else if (min == Arr[i])
        {
            int count = i;
            Console.WriteLine("Строкой с минимальной суммой элиментов является: " + (count + 1) + " строка " + " sum= " + min);
        }
    }
    Console.WriteLine("Строкой с минимальной суммой элиментов является: " + (indMin + 1) + " строка " + " sum= " + min);
}