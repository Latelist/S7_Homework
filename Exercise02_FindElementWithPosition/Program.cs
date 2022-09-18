// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и 
// возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

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

string FindElementWithIndex(int[,] matrix, int position)
{
    string find_element = "There is no such element.";
    int index = 0; 
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                index++;
                if (index == position)
                {
                    find_element = $"{matrix[i, j]}";
                }
            }
        }
    }

    return find_element;
}

Console.Write("Please, enter rows quantity: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Please, enter columns quantity: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = CreateMatrix(m, n);
PrintMatrix(matrix);

Console.Write("Enter element position: ");
int r = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindElementWithIndex(matrix, r));


