// Задача 52. Задайте двумерный массив из целых чисел.
//  Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


/*
double[,] Array = new double[,] { {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}};

for(int i = 0; i < Array.GetLength(0); i++)
{
    double sum = 0;
    for(int j = 0; j < Array.GetLength(1); j++)
    {
       sum += Array[i,j];
    }
    Console.WriteLine($"{sum / Array.GetLength(0)}\t");
}
*/


Console.Clear();

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(0, 16);
            Console.Write($"{matrix[i,j]} \t");
        }
        Console.WriteLine();
    }
}

// int[] ReadPosition()
// {
//     Console.Write("What element do you want: ");
//     int[] Position = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
//     return Position;
// }

void FindElement(int[,] matrix)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        Console.Write($"{sum / matrix.GetLength(0)} \t");
    }
}

Console.Write("Enter the size of your matrix: ");
int[] Size = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
int[,] Matrix = new int[Size[0], Size[1]];
InputMatrix(Matrix);
Console.WriteLine();
FindElement(Matrix);








