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
//Разворот массива
int[] SwapNewArray(int[] arr)
{
   int[] outArr = new int[arr.Length];
   for (int i = 0; i < arr.Length; i++)
   {
      outArr[i] = arr[arr.Length - 1 - i];
   }
   return outArr;
}

int[] SwapArray(int[] arr)
{
   int buffEl = 0;
   for (int i = 0; i < arr.Length / 2; i++)
   {

      buffEl = arr[arr.Length - 1 - i];
      arr[arr.Length - 1 - i] = arr[i];
      arr[i] = buffEl;
   }

   return arr;
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
int[] arrys = FillArray(10, 10, 30); // 12 чисел, от 100 до 999
PrintResultArray(arrys); // Вывод массива
int[] reverse = SwapNewArray(arrys);
PrintResultArray(reverse);
int[] reverseTwo = SwapArray(arrys);
PrintResultArray(reverseTwo);
Console.WriteLine();
// вывод результата
