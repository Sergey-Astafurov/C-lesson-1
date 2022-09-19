// Задайте одномерный массив, заполненный случайными числами. Найдите сумму
// элементов, стоящих на нечётных позициях.

//Создаем рандомный массив из трехзначных чисел
double[] FillArray()
{
   double[] arr = new double[10];
   Random sintezator = new Random();
   for (int i = 0; i < arr.Length; i++)
   {
      arr[i] = Math.Round(sintezator.NextDouble() * 100, 2);

   }
   return arr;
}

//Стандартное решение с семинара
double MaxMin(double[] arr)
{
   double result = 0;
   double max = int.MinValue;
   double min = int.MaxValue;
   for (int i = 0; i < arr.Length; i++)
   {
      if(arr[i] > max){
         max = arr[i];
      }
      if(arr[i] < min){
         min = arr[i];
      }
   }
   return result = max - min;
}
//Находим четные числа


// Выводим массив который создали
void PrintResultArray(double[] arr)
{
   Console.Write("[ " + arr[0] + ", ");
   for (int i = 1; i < arr.Length - 1; i++)
   {
      Console.Write(arr[i] + ", ");
   }
   Console.Write(arr[arr.Length - 1] + " ]");
}




//Тело программы
double[] arrys = FillArray();
PrintResultArray(arrys); // Вывод массива

double result = MaxMin(arrys); // Вычисления макс мин
Console.WriteLine();
Console.WriteLine( " Результат вычитания : " + result);









