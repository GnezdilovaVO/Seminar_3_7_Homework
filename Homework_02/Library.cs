public static class Library
{
    public static int GetNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void FillArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(0,100);
            }
        }
    }
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i,j] + "   ");
            }
            Console.WriteLine();
        }
    }
    public static void GetResult(int[,] matrix1, string position)
    {
        string compare = String.Empty;
        int reserve=0;
        for (int i = 0; i < matrix1.GetLength(0); i++)
        {
            for (int j = 0; j < matrix1.GetLength(1); j++)
            {
                compare = compare + i + j;
                if (compare == position)
                {
                    reserve = -1;
                    Console.WriteLine(matrix1[i, j]);
                }
                compare = String.Empty;
            }
        }
        if ( reserve != -1)
        {
            Console.WriteLine("Нет такой позиции");
        }
    }
    public static string GetPosition(string text)
    {
        Console.WriteLine(text);
        return Convert.ToString(Console.ReadLine());
    }


}