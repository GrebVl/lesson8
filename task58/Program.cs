/*
Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.

Например, заданы 2 массива:

1 4 7 2              1 5 8 5
5 9 2 3   и          4 9 4 2
8 4 2 4              7 2 2 6
5 2 6 7              2 3 4 7

Их произведение будет равно следующему массиву:

1   20   56   10
20  81    8    6
56   8    4   24
10   6   24   49
*/

void GetWorkArr(int[,] arr, int[,] arr2)
{
    int[,] NewArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            NewArr[i, j] = arr[i, j] * arr2[i, j];
            Console.Write(NewArr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int[,] GetkArr(int line, int col)
{
    int[,] Arr = new int[line, col];
    Random rnd = new Random();
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Arr[i, j] = rnd.Next(-10, 10);
        }
    }
    return Arr;
}

void PrintArr(int[,] Arr)
{
    for (int i = 0; i < Arr.GetLength(0); i++)
    {
        for (int j = 0; j < Arr.GetLength(1); j++)
        {
            Console.Write(Arr[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

int row = 4;
int column = 4;

int[,] UsArr1 = GetkArr(row, column);
PrintArr(UsArr1);

Console.WriteLine("and");

int[,] UsArr2 = GetkArr(row, column);
PrintArr(UsArr2);

Console.WriteLine("Произведение");

GetWorkArr(UsArr1, UsArr2);

