// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int rows = new Random().Next(4,5);
int columns = new Random().Next(4,5);
int rows1 = new Random().Next(4,5);
int columns1 = new Random().Next(4,5);

int[,] matrix = new int[rows, columns];
int[,] matrix1 = new int[rows1, columns1];
  
Console.WriteLine("Первая матрица: ");  
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        matrix[i,j] = new Random().Next(1, 5); 
        Console.Write(matrix[i,j] + " ");          
    }
    Console.WriteLine();
}
Console.WriteLine();
Console.WriteLine("Вторая матрица: ");
for (int i = 0; i < rows1; i++)
{
    for (int j = 0; j < columns1; j++)
    {
        matrix1[i,j] = new Random().Next(1, 5);
        Console.Write(matrix1[i,j] + " ");          
    }
    Console.WriteLine();
}
Console.WriteLine();

if(rows == columns1 || rows1 == columns)
{
    Console.WriteLine("Произведение матриц:");

    int[,] result = new int[rows, columns1];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns1; j++)
        {
            for (int q = 0; q < columns; q++)
            result[i, j] += matrix[i, q] * matrix1[q, j];
        }
    } 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns1; j++)
        { 
        Console.Write(result[i, j] + " ");
        }
        Console.WriteLine();
    }
}
else
{
    Console.Write("Ошибка");
}
