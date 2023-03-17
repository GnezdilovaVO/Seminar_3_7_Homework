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
                matrix[i, j] = new Random().Next(0, 10);
            }
        }
    }
    public static void PrintArray(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
    public static string GetAverage(int[,] matrix)
    {
        string result = String.Empty;
        double sum = 0;
        double sumCount = 0;
        int count = matrix.GetLength(0);
        for (int i =0; i < matrix.GetLength(1); i++)
        {
            for (int j =0; j < matrix.GetLength(0); j++)
            {
                sum = sum + matrix[j, i];
            }
            sumCount = Math.Round((sum/count), 2);
            result = result + sumCount + " ";
            sum = 0;
        }
        return result;
    }

}