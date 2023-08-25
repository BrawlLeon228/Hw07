void ShowEl(int[,] matr, int m, int n)
{
    if (m <= matr.GetLength(0))
    {   
        if (n <= matr.GetLength(1)){
            Console.WriteLine(matr[m-1, n-1]);
        }
    }
    else 
    {
        Console.WriteLine("Такого элемента в массиве нет");
    }
}

int[,] matrix = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};
ShowEl(matrix, 3, 2);