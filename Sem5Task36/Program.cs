// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.

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
      if (i % 2 != 0)
      {
         res = res + arr[i];


      }

   }
   return res;
}

// Выводим массив который создали
void PrintResultArray(int[] arr)
{
   Console.Write("[ " + arr[0] + ", ");
   for (int i = 1; i < arr.Length - 1; i++)
   {
      Console.Write(arr[i] + ", ");
   }
   Console.Write(arr[arr.Length - 1] + " ]");
}



//Тело программы
int[] arrys = FillArray(10, 100, 1000); // 12 чисел, от 100 до 999
PrintResultArray(arrys); // Вывод массива
int resultFind = FidnElem(arrys); // Подсчет результата
Console.WriteLine();
Console.WriteLine("Сумма элементов стоящих на нечетных позициях : " + resultFind); // вывод результата
