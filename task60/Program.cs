/*
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
 Напишите программу, которая будет построчно выводить массив,
  добавляя индексы каждого элемента.

массив размером 2 x 2 x 2

12(0,0,0) 22(0,0,1)

45(1,0,0) 53(1,0,1)


*/
GetArray(2, 2, 2);

void GetArray(int x, int y, int z)
{
    int[,,] arr = new int[x, y, z];
    int n = 0;
    Random rnd =new Random();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {

            for (int c = 0; c < arr.GetLength(2); c++)
            {
                arr[i, j, c] = rnd.Next(9, 90) + n;
                Console.Write(arr[i, j, c]);
                Console.Write("(" + i + "," + j + "," + c + ") ");
                n++;
            }

        }
        Console.WriteLine();
    }
}