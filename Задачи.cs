/*
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит 
по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/
/*
int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)  
{                                                                                
    int[,] newArray = new int[rows,columns];                                     
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1); 
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

int[,] SortMaxMin (int[,] array)
{
    for (int i = 0; i<array.GetLength(0); i++)
    {
        for (int j = 0; j<array.GetLength(1); j++)
        {
            for (int k = 0; k<array.GetLength(1)-1; k++)
            {
                if (array [i,k]<array [i,k+1])
                {
                int temp = array [i,k];
                array [i,k] = array [i,k+1];
                array [i,k+1] = temp;
                }
            }
        }
    }
    return array;
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
Console.WriteLine();
int[,] sortArray = SortMaxMin(myArray);
Show2DArray(sortArray);
*/
/*
Задача 56: Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой строке 
и выдаёт номер строки с наименьшей суммой элементов: 1 строка */

/*
int[,] Create2DRandomArray ( int rows, int columns, int minValue, int maxValue)  
{                                                                                
    int[,] newArray = new int[rows,columns];                                     
    for(int i = 0; i < rows; i++)
    {
        for(int j = 0; j < columns; j++)
        {
            newArray[i,j] = new Random().Next(minValue, maxValue+1); 
        }
    }
    return newArray;
}

void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void ShowMinSumRows (int[,] array)
{
    int minSum = 1000000000;
    int minInd = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = (sum + array[i, j]);
            
        }
        Console.WriteLine($"Cумма строки {i + 1} = {sum}");
        if (sum<minSum) 
        {
            minSum = sum;
            minInd = i;
        }
    }
    
    Console.WriteLine($"Наименьшая сумма элементов строки = {minSum}");
    Console.WriteLine($"Номер строки с наименьшей суммой элементов = {minInd+1}");
}

Console.Write("Введите количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение ");
int max = Convert.ToInt32(Console.ReadLine());

int[,] myArray = Create2DRandomArray(m,n,min,max);
Show2DArray(myArray);
Console.WriteLine();

ShowMinSumRows(myArray);
*/
/*
Задача 58: Задайте две матрицы. Напишите программу, 
которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

/*Произведение матриц - матрица, каждый элемент которой 
есть сумма попарных произведений элементов строки первого множителя 
на элементы столбца второго:

1. 1эл1стр * 1 эл1ст + 2эл1стр * 2эл1ст  (2*3+4*3) = 6+12 = 18
2. 1эл2стр * 1эл1ст + 2эл2стр * 2эл1ст   (3*3+2*3) = 9+6 = 15
3. 1эл1стр * 1 эл2ст + 2эл1стр * 2эл2ст  (2*4+4*3) = 8 + 12 = 20
4. 1эл2стр * 1 эл2ст + 2эл2стр * 2эл2ст  (3*4+2*3) = 12 + 6 = 18

*/
/*
void Show2DArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void MultiplyMatrix(int[,] firstMartrix, int[,] secondMartrix, int[,] resultMatrix)
{
  for (int i = 0; i < resultMatrix.GetLength(0); i++)
  {
    for (int j = 0; j < resultMatrix.GetLength(1); j++)
    {
      int sum = 0;
      for (int k = 0; k < firstMartrix.GetLength(1); k++)
      {
        sum = sum + firstMartrix[i,k] * secondMartrix[k,j];
      }
      resultMatrix[i,j] = sum;
    }
  }
}

int[,] firstMartrix = new int[3, 2] {{2,4},{3,2},{3,2}};
Console.WriteLine($"Первая матрица:");
Show2DArray(firstMartrix);
Console.WriteLine();
int[,] secondMartrix = new int[2, 3] {{3,4,2},{3,3,2}};
Console.WriteLine($"Вторая матрица:");
Show2DArray(secondMartrix);
Console.WriteLine();

int[,] resultMatrix = new int[3,3];

MultiplyMatrix(firstMartrix, secondMartrix, resultMatrix);
Console.WriteLine($"Произведение первой и второй матриц:");
Show2DArray(resultMatrix);
*/
