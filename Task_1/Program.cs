void FillRandomTwoDimArray(int[,] array, int RandomFrom, int RandomTo, int RowCount, int ColumnCount)
{   
    RowCount = array.GetLength(0);
    ColumnCount = array.GetLength(1);
    Random arr = new Random();
    for(int i = 0; i < RowCount; i++)
    {
        for(int j = 0; j < ColumnCount; j++)
        {
            array[i,j] = arr.Next(RandomFrom, RandomTo);
        }
    }
}
void PrintTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
void GetRowsMaxToMin(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1); k++)
            {
                if (array[i, j] <= array[i, k]) continue;
                int temp = array[i, j];
                array[i, j] = array[i, k];
                array[i, k] = temp;
            }
        }
    }
}
int Rows = new Random().Next(1,10);
int Columns = new Random().Next(1,10);
int[,] matrix = new int[Rows, Columns];
FillRandomTwoDimArray(matrix, 1, 99, Rows, Columns);
Console.WriteLine("Исходный массив: ");
PrintTwoDimArray(matrix);
GetRowsMaxToMin(matrix);
Console.WriteLine("Полученный массив: ");
PrintTwoDimArray(matrix);