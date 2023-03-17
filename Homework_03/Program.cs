using static Library;
int m = GetNumber("Введите кличество строк m: ");
int n = GetNumber("Введите кличество строк m: ");
int [,] array = new int[m, n];
FillArray(array);
PrintArray(array);
string result = GetAverage(array);
Console.WriteLine(result);