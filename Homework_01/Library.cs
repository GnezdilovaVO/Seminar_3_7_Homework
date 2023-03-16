public static class Library
{
    public static int GetNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }
    public static void FillArray(double[,] array1)
    {
        double random;
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j =0; j< array1.GetLength(1); j++)
            {
                random = new Random().NextDouble()*9;
                array1[i, j] = Math.Round(random, 1);

            }
        }
    }
    public static void PrintArray(double[,] array2)
    {
        for (int i =0; i < array2.GetLength(0); i++)
        {
            for (int j =0; j < array2.GetLength(1); j++)
            {
                Console.Write(array2[i, j] + "  ");
            }
            Console.WriteLine();
        }
    }
}
