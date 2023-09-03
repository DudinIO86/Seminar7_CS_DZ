// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int SetNumber(string Number=" ")
{
    System.Console.WriteLine($"Введите индекс {Number}");
    int num=int.Parse(Console.ReadLine());
    return num;
}

double[,] Matrix()
{
    double[,] matrix=new double[5,5];

    Random rand=new Random();

    for(int i=0;i<matrix.GetLength(0);i++)
    {
        for(int j=0;j<matrix.GetLength(1);j++)
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

void NumberPoz(double[,] matrix,int m, int n)
{
    if(m<matrix.GetLength(0) && n<matrix.GetLength(1))
    {
        System.Console.WriteLine(matrix[m-1,n-1]);
    }
    else
    {
        System.Console.WriteLine("такого числа в массиве нет");
    }
}

int m=SetNumber("m");
int n=SetNumber("n");

double[,] matrix=Matrix();
System.Console.WriteLine("Массив:");
Print(matrix);
System.Console.Write("Число в массиве: ");
NumberPoz(matrix,m,n);