using static Library;
int m = GetNumber("Задайте строки матрицы m: ");
int n = GetNumber("Задайте столбцы матрицы n: ");
int[,] array = new int[m, n];
FillArray(array); 
PrintArray(array);
string result = GetPosition("Укажите номер позиции: ");
GetResult(array, result);
