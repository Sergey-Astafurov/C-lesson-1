// Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.


//Создаем рандомный массив из трехзначных чисел
int[] FillArray(int num, int down, int top)
{
   Random sintezator = new Random();
   int[] arr = new int[num];
   if (down < top)
   {
      for (int i = 0; i < arr.Length; i++)
      {
         arr[i] = sintezator.Next(down, top + 1);
      }
   }
   return arr;
}

//Находим четные числа
int FidnElem(int[] arr)
{
   int res = 0;
   for (int i = 0; i < arr.Length; i++)
   {
      if (arr[i] % 2 == 0)
      {
         res = res + 1;
      }
   }
   return res;
}

// Выводим массив который создали
void PrintResultArray(int[] arr)
{
   Console.Write("[" + arr[0] + ", ");
   for (int i = 1; i < arr.Length - 1; i++)
   {
      Console.Write( +  arr[i] + ", ");
   }
   Console.Write(arr[arr.Length - 1] + "]");
}



//Тело программы
int[] arrys = FillArray(12, 100, 999); // 12 чисел, от 100 до 999
PrintResultArray(arrys); // Вывод массива
int resultFind = FidnElem(arrys); // Подсчет результата
Console.WriteLine();
Console.WriteLine("количество четных чисел : " + resultFind); // вывод результата
