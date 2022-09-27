int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}


//Создаем рандомный 2D массив из трехзначных чисел
int[,] Fill2DArray(int countRow, int countColumn, int down, int top)
{
   Random sintezator = new Random();
   int[,] arr2D = new int[countRow, countColumn];

   for (int i = 0; i < countRow; i++)
   {
      for (int j = 0; j < countColumn; j++)
      {
         arr2D[i, j] = sintezator.Next(down, top + 1);
      }

   }

   return arr2D;
}

// // Выводим массив который создали
// void PrintResult2DArray(int[,] arr)
// {
//    for (int i = 0; i < arr.GetLength(0); i++)
//    {
//       for (int j = 0; j < arr.GetLength(1); j++)
//       {
//          Console.Write($"{arr[ i, j ]}\t" );
//       }
//       Console.WriteLine();
//    }
// }
// Выводим массив который создали
void PrintResult2DArrayColor(int[,] arr)
{
   for (int i = 0; i < arr.GetLength(0); i++)
   {
      for (int j = 0; j < arr.GetLength(1); j++)
      {
         Console.ForegroundColor = ConsoleColor.Blue;
         Console.Write($"{arr[ i, j ]}\t" );
      }
      Console.WriteLine();
   }
}

int row = ReadData("Введи кол строк");
int column = ReadData("введи кол столбцов");

int[,] arr2d = Fill2DArray(row,column,1,100);
PrintResult2DArrayColor(arr2d);
