
//Перевод строки
int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}

//Создаем рандомный 2D массив
double[,] Fill2DArray(int countRow, int countColumn)
{
   Random sintezator = new Random();
   double[,] arr2D = new double[countRow, countColumn];
   for (int i = 0; i < countRow; i++)
   {
      for (int j = 0; j < countColumn; j++)
      {
         arr2D[i, j] = Math.Round((sintezator.NextDouble() * 10), 2);
      }

   }
   return arr2D;
}

// Выводим массив который создали
void PrintResult2DArrayColor(double[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.Write($"{arr[i, j]}\t");
      }
      Console.WriteLine();
   }
}

//Тело программы
int row = ReadData("Введи кол строк"); //строки
int column = ReadData("введи кол столбцов"); //числа

double[,] arr2d = Fill2DArray(row, column); //создание массива
PrintResult2DArrayColor(arr2d); // печать массива
