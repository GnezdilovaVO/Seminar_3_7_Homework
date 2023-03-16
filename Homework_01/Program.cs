using static Library;
int m = GetNumber("Задайте число m: ");
int n = GetNumber("Задайте число n: ");
double[,] array = new double[m, n];
FillArray(array);
PrintArray(array);