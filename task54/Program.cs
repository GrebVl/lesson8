/*
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

В итоге получается вот такой массив:

1 2 4 7
2 3 5 9
2 4 4 8
*/

int row=4;
int column=4;

int[,] arr =GetArr(row, column);
PrintArr(arr);
Console.WriteLine();

int[,] myArr = SortArr(arr);
PrintArr(myArr);

int[,] GetArr(int line, int col)
{
    int[,] NewArr=new int[line, col];
    Random rnd=new Random();
     for (int i = 0; i < NewArr.GetLength(0); i++)
    {
        for (int j = 0; j < NewArr.GetLength(1); j++)
        {
          NewArr[i,j]=rnd.Next(0,100);
        }
    }
    return NewArr;
}

int[,] SortArr(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
           for(int k=0;k<array.GetLength(1)-1-j;k++)
            {
                if (array[i,k] > array[i,k+1])
                {
                    int swap = array[i, k];
                    array[i, k] = array[i, k+1];
                    array[i, k+1] = swap;
                }
            }
        }
    }
    return array;
}

void PrintArr(int[,] arr)
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
