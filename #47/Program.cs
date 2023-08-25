void WriteArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++) Console.Write(matr[i,j]+" ");
        Console.WriteLine();
    }
}
void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++) 
    {
        for (int j = 0; j < matr.GetLength(1); j++) matr[i,j] = new Random().Next(-10.0,10.0);
    }
    WriteArray(matr);
}

int m = 3;
int n = 4;
int[,] matrix = new int[m, n];

FillArray(matrix);