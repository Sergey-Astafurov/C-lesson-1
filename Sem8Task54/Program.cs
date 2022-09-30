// Метод генерации и заполнения массива
int[,] Fill2DArray(int rows, int cols, int numMin, int numMax)
{
   // Создаём массив
   int[,] array2D = new int[rows, cols];
   if (numMin < numMax)
   {
      // Заполняем массив
      for (int i = 0; i < rows; i++)
      {
         for (int j = 0; j < cols; j++)
         {
            array2D[i, j] = new Random().Next(numMin, numMax + 1);
         }
      }
   }

   return array2D;
}
int[,] UpdateArr(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {

      for (int k = 0; k < array.GetLength(1)-1; k++)
      {
        if (array[i, k] < array[i, k + 1])
        {
          int temp = array[i, k + 1];
          array[i, k + 1] = array[i, k];
          array[i, k] = temp;
        }
      }
    }
  }
   return array;
}

// двумерный массив
void Print2DArray(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
         Console.Write($"{arr[i, j]}  ");
      }
      Console.WriteLine();
   }
}



int[,] array2D = Fill2DArray(5, 5, 1, 10);
Console.WriteLine("Двумерный массив обычный");
Print2DArray(array2D);
Console.WriteLine();
int[,] upArr = UpdateArr(array2D);
Console.WriteLine("Двумерный массив отсортированный");
Print2DArray(array2D);
