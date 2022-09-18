// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


int[,] CreateMatrix(int M, int N)
{
    int[,] matrix = new int[M, N];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(0, 10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void PrintArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

double[] FindColumnAverages(int[,] matrix)
{
    double[] averages = new double[matrix.GetLength(1)];
    double sum = 0;
    double average = 0;
    int averages_index = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i, j];
            if (i == matrix.GetLength(0) - 1)
            {
                average = sum / matrix.GetLength(0);
                sum = 0;
                averages[averages_index] = average;
                averages_index++;
            }
        }
    }
    return averages;

}

Console.Write("Please, enter rows quantity: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter columns quantity: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);

PrintArray(FindColumnAverages(matrix));
