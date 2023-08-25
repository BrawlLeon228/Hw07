void PrintArray(double[] arr){
    string str = "";
    for (int i = 0; i < arr.Length; i++)
    {
        str+=$"{arr[i]}; ";
    }
    Console.WriteLine(str);
}

void Average(int[,] matr)
{
    double[] array = new double[matr.GetLength(1)];
    double res = 0.0;

    for (int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 0; j < matr.GetLength(0); j++)
        {
            res+=matr[j, i];
        }
        array[i] = res/matr.GetLength(0);
        res = 0.0;
    }

    PrintArray(array);

}

int[,] matrix = new int[,]
{
    {1, 4, 7, 2},
    {5, 9, 2, 3},
    {8, 4, 2, 4},
};

Average(matrix);