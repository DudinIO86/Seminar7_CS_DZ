// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int SetNumber(string Number=" ")
{
    System.Console.WriteLine($"Введите размер {Number}");
    int num=int.Parse(Console.ReadLine());
    return num;
}

int[,] Matrix(int m, int n)
{
    int[,] matrix=new int[m,n];

    Random rand=new Random();

    for(int i=0;i<m;i++)
    {
        for(int j=0;j<n;j++)
        {
            int min=-10;
            int max=10;
            matrix[i,j]=rand.Next(min,max);
        }
    }
    return matrix;
}

void Print(int[,] matrix)
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

double AverageColumn(int[,] matrix,int n)
{
    double mat=0;
    for(int i=0;i<matrix.GetLength(0);i++)
    {
        mat=mat+matrix[i,n]; 
    }
    return Math.Round(mat/matrix.GetLength(0),1);
}

void Average(int[,] matrix)
{
    for(int t=0;t<matrix.GetLength(1);t++)
    {
        System.Console.Write($"{AverageColumn(matrix,t)} ");
    }
}

int m=SetNumber("m");
int n=SetNumber("n");

int[,] matrix=Matrix(m,n);

System.Console.WriteLine("Массив:");
Print(matrix);

System.Console.WriteLine("Среднее число столбцов: ");
Average(matrix);