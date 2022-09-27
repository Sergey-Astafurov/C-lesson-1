int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}


//Создаем рандомный 2D массив из трехзначных чисел
int[,] Fill2DArray(int[,] matr)
{

   for (int i = 0; i < matr.GetLength(0); i++)
   {
      for (int j = 0; j < matr.GetLength(1); j++)
      {
         matr[i, j] =i +j ;
      }

   }

   return matr;
}

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

int n = ReadData("Введи кол строк");
int m = ReadData("введи кол столбцов");

int [,] matrix = new int[m,n];
Fill2DArray(matrix);
PrintResult2DArrayColor(matrix);