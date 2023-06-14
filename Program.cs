// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)


//трехмерный массив по порядку
int[,,] CreateMatrixRndInt(int rows, int columns, int depth)
{
    int[,,] matrix = new int[rows,columns,depth];
    int m=10;
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j=0;j<matrix.GetLength(1); j++)    
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
                matrix[i,j,k] = m;
                m++;
            }
        }
    }
    return matrix;
}

//вывод массива на экран трехмерного
void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)  
    {
        for (int j=0;j<matrix.GetLength(1); j++)    
        {
            for (int k = 0; k < matrix.GetLength(2); k++)
            {
            Console.Write($"{matrix[i,j,k], 3} ({i},{j},{k})");  //5 это чтобы разделять числа
            }
        }
        Console.WriteLine();
    }
}


int[,,] array3d=CreateMatrixRndInt(2,2,2);
PrintMatrix(array3d);