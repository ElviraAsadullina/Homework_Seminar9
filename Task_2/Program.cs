void FillRandomTwoDimArray(int[,] array, int RandomFrom, int RandomTo, int RowCount, int ColumnCount)
{   
    RowCount = array.GetLength(0);
    ColumnCount = array.GetLength(1);
    Random arr = new Random();
    string a = string.Empty;
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
             if(array[i,j] / 10 < 1)
            {
                Console.Write("0" + array[i,j] + "\t");
            }
            else
            {
                Console.Write(array[i,j] + "\t");
            }
        }
        Console.WriteLine();
    }    
}
void ArrayToSpiral(int[,] array, int RowsCount, int ColumnsCount)
{
    int row = 0;
    int column = 0;
    int turnX = 1;
    int turnY = 0;
    int turnCount = 0;
    int visits = RowsCount;
    for (int i = 0; i < array.Length; i++) 
    {
        array[row, column] = i + 1;
        if (--visits == 0) 
        {
            visits = RowsCount * (turnCount %2) + ColumnsCount * ((turnCount + 1) %2) - (turnCount/2 - 1) - 2;
            int temp = turnX;
            turnX = -turnY;
            turnY = temp;
            turnCount++;
        }
    column += turnX;
    row += turnY;
    }
}
Console.WriteLine("Введите количество строк в массиве: ");
int Rows = Convert.ToInt32(Console.ReadLine());
int Columns = Rows;
int[,] helix = new int[Rows, Columns];
FillRandomTwoDimArray(helix, 1, 16, Rows, Columns);
Console.WriteLine("Исходный массив: ");
PrintTwoDimArray(helix);
Console.WriteLine("Массив, упопядоченный спирально по возрастанию: ");
ArrayToSpiral(helix, Rows, Columns);
PrintTwoDimArray(helix);