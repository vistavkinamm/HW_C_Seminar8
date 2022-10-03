// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine();
Console.WriteLine("Вниман ие произведение x*y*z должно быть меньше или равно 90");
Console.WriteLine("Иначе уникальных двухзначных чисел не хватит для заполнения массива");
Console.WriteLine();
Console.WriteLine("Введите количество строк (x): ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов (y): ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите разность массивов по оси (z): ");
int zElements = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

if (rows*columns*zElements>90)
{
    Console.WriteLine("Недостаточно уникальных двухзначных значных чисел для заполнения массива");
}
else
{
    int count = 0;
    int [] arrayRandom = new int [90];
    for (int i=0; i<arrayRandom.Length - 1; i++)
    {
        arrayRandom[i]=10+i;
    }
    for (int i=0; i<arrayRandom.Length; i++)
    {
        int j=new Random().Next(arrayRandom.Length);
        int temp=arrayRandom[j];
        arrayRandom[j]=arrayRandom[i];
        arrayRandom[i]=temp;
    }
    int [,,] array=new int[rows,columns,zElements];
    for (int i=0; i<array.GetLength(0); i++)
    {
        for (int j=0; j<array.GetLength(1); i++)
        {
            for (int k=0; k<array.GetLength(2); k++)
            {
                array[i, j, k]=arrayRandom[count];
                Console.Write($"{array[i,j,k]}({i},{j},{k})");
                count+=1;
            }
            Console.WriteLine();
        }
    }
}

