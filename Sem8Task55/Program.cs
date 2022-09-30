
// из строки  в число
int ReadData(string line)
{
   // Выводим сообщение
   Console.Write(line);
   // Считываем число
   int number = int.Parse(Console.ReadLine() ?? "0");
   // Возвращаем значение
   return number;
}
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
            Console.WriteLine(array2D[i,j]);
         }
      }
   }

   return array2D;
}
bool TestRotate(int[,] arr)
{
   if (arr.GetLength(0) == arr.GetLength(1))
   {
      return true;
   }
   else
   {
      return false;
   }
}
// int[,] RotArr(int[,] arr)
// {
//    int buff = 0;
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//       for (int j = i + 1; j < arr.GetLength(1); j++)
//       {
//          buff = arr[i, j];
//          Console.WriteLine("buff" + buff);
//          arr[i, j] = arr[j, i];
//          Console.WriteLine("arr" +  arr[i,j]);

//          arr[j, i] = buff;
//          Console.WriteLine( "new buff"+buff);

//       }
//    }
//    return arr;
// }



// двумерный массив
void Print2DArray(int[,] arr)
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
// вывод результата
// void PrintResult(string line)
// {
//    Console.WriteLine(line);
// }


// Данные для генерации массива
int numMin = 0;
int numMax = 10;

int inputRows = ReadData("Введите количество строк: ");
int inputCols = ReadData("Введите количество столбцов: ");
int[,] array2D = Fill2DArray(inputRows, inputCols, numMin, numMax);
Print2DArray(array2D);
Console.WriteLine();

// bool test = TestRotate(array2D);
// int[,] rotate = RotArr(array2D);

// Print2DArray(array2D);
