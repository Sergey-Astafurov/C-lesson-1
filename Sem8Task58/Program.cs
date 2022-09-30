
int ReadData(string line)
{
   // Выводим сообщение
   Console.Write(line);
   // Считываем число
   int number = int.Parse(Console.ReadLine() ?? "0");
   // Возвращаем значение
   return number;
}



int[,] Fill2DArray(int m, int n, int min, int max)
{
   int[,] result = new int[m, n];
   for (int i = 0; i < m; i++)
   {
      for (int j = 0; j < n; j++)
      {
         result[i, j] = new Random().Next(min, max + 1);
      }

   }
   return result;
}

void PrintArray(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
         Console.Write($"{arr[i, j]} ");
      }
      Console.WriteLine();
   }
}

int[,] GetMultiplicationMatrix(int[,] arrayA, int[,] arrayB)
{
   int[,] arrayC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];
   for (int i = 0; i < arrayA.GetLength(0); i++)
   {
      for (int j = 0; j < arrayB.GetLength(1); j++)
      {
         for (int k = 0; k < arrayA.GetLength(1); k++)
         {
            arrayC[i, j] += arrayA[i, k] * arrayB[k, j];
         }
      }
   }
   return arrayC;
}
int rowsA = ReadData("Введите количество строк A: ");
int columnsA = ReadData("Введите количество столбцов A: ");
int rowsB = ReadData("Введите количество строк B: ");
int columnsB = ReadData("Введите количество столбцов B: ");
if (columnsA != rowsB)
{
   Console.WriteLine("Такие матрицы умножать нельзя!");
   return;
}
int[,] A = Fill2DArray(rowsA, columnsA, 0, 10);
int[,] B = Fill2DArray(rowsB, columnsB, 0, 10);
PrintArray(A);
Console.WriteLine();
PrintArray(B);
Console.WriteLine();
PrintArray(GetMultiplicationMatrix(A, B));