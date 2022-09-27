
//Перевод строки
int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}

//Создаем рандомный 2D массив
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


// Выводим массив который создали
void PrintResult2DArrayColor(int[,] arr)
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

//находим элемент
int FindElem(int x, int y, int[,] arr)
{
   if (x < arr.GetLength(0) && y < arr.GetLength(1))
   {
      return arr[x, y];
   }
   else
   {
      return -1;
   }
}
// выводим результат поиска
void Print(int line)
{
   if (line > 0)
   {
      Console.WriteLine("Найденное число :" + line);
   }
   else
   {
      Console.WriteLine("Нет числа");
   }

}
//Тело программы
int row = ReadData("Введи кол строк"); //строки
int column = ReadData("введи кол столбцов"); //числа
int[,] arr2d = Fill2DArray(row, column, 1, 100); //создание массива
PrintResult2DArrayColor(arr2d); // печать массива

int x = ReadData("введи позицию по x"); //координаты числа
int y = ReadData("введи позицию по У");
int result = FindElem(x, y, arr2d); // поиск
Print(result); // решение поиска
