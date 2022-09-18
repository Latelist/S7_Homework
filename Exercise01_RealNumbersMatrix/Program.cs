// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9



double[,] CreateRealMatrix(int M, int N)
{
    double[,] real_matrix = new double[M, N];
    Random rand = new Random();
    for (int i = 0; i < real_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < real_matrix.GetLength(1); j++)
        {
            real_matrix[i, j] = rand.NextDouble() * 10;
        }
    }
    return real_matrix;
}

void PrintRealMatrix(double[,] real_matrix)
{
    for (int i = 0; i < real_matrix.GetLength(0); i++)
    {
        for (int j = 0; j < real_matrix.GetLength(1); j++)
        {
            Console.Write($"{Math.Round(real_matrix[i, j], 1)}  ");
        }
        Console.WriteLine();
    }
}

Console.Write("Please, enter rows quantity: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter columns quantity: ");
int n = Convert.ToInt32(Console.ReadLine());

PrintRealMatrix(CreateRealMatrix(m, n));