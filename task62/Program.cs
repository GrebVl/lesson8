/*
Заполните спирально массив 4 на 4.

Например, на выходе получается вот такой массив:

1    2   3  4
12  13  14  5
11  16  15  6
10   9   8  7
*/

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i, j] + "( " + i + "," + j + ") " + "\t");
        }
        Console.WriteLine();
    }
}

int[,] GetArr(int line, int col)
{
    int[,] NewArr = new int[line, col];
    int count = 1;

    for (int i = 0; i < NewArr.GetLength(0); i++)
    {
        for (int j = 0; j < NewArr.GetLength(1); j++)
        {
            if (i == 0)
            {
                NewArr[i, j] = count;
                count++;
            }

            else if (j == NewArr.GetLength(1) - 1)
            {
                NewArr[i, j] = count;
                count++;
            }

        }
       
        for (int k = NewArr.GetLength(1) - 2; k >= 0; k--)
            if (i == NewArr.GetLength(0) - 1)
            {
                NewArr[i, k] = count;
                count++;
            }
    }

int penultLineColumn = NewArr.GetLength(0)-2;
int firstLine = 1;
for (int i = NewArr.GetLength(0) - penultLineColumn; i >= firstLine; i--)
{
    NewArr[i, 0] = count;
    count++;
}

for (int i = firstLine; i < penultLineColumn; i++)
{
    for (int j = 1; j < NewArr.GetLength(1) - 1; j++)
    {
        NewArr[i, j] = count;
        count++;
    }
}

for (int i = NewArr.GetLength(0) - 2; i < NewArr.GetLongLength(0) - 1; i++)
{
    for (int j = NewArr.GetLength(1) - 2; j > 0; j--)
    {
        NewArr[i, j] = count;
        count++;
    }
}
    return NewArr;
}

int[,] arr ={
    {1,    2,   3,  4},
    {12,  13,  14,  5},
    {11,  16,  15,  6},
    {10,   9,   8,  7}
};


PrintArr(arr);
Console.WriteLine();
int[,] UsArr = GetArr(4, 4);
PrintArr(UsArr);
