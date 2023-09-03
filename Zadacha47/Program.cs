// // Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

int SetNumber(string Number=" ")
{
    System.Console.WriteLine($"Введите размер {Number}");
    int num=int.Parse(Console.ReadLine());
    return num;
}

double[,] Matrix(int m, int n)
{
    double[,] matrix=new double[m,n];

    Random rand=new Random();

    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            int min=-100;
            int max=100;
            matrix[i,j]=Math.Round(rand.Next(min,max)*0.1,1);
        }
    }
    return matrix;
}

void Print(double[,] matrix)
{
     for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
        {
            System.Console.Write($"{matrix[i,j]} ");
        }
        System.Console.WriteLine();
    }
}

int m=SetNumber("m");
int n=SetNumber("n");

double[,] matrix=Matrix(m,n);

Print(matrix);