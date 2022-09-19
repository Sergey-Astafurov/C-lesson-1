// Задайте массив. Напишите программу, которая
// определяет, присутствует ли заданное число в
// массиве.
// 1 FillArray();
// 2 PrintResultArray();
// 3 PrintData();
// 4 InverseArray();

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
bool FidnElem(int[] arr, int elem)
{
   bool res = false;
   for (int i = 0; i < arr.Length; i++)
   {
      if (arr[i] == elem)
      {
         res = true;
         Console.Write("Число найдено");
         break;
      }



   }
   return res;
}

   void PrintResultArray(int[] arr)
   {
      for (int i = 0; i < arr.Length - 1; i++)
      {
         Console.Write(arr[i] + ", ");
      }
      Console.WriteLine(arr[arr.Length - 1]);
   }

   void PrintResult(string line)
   {
      Console.WriteLine(line);
   }


   int[] arrys = FillArray(10, 0, 30);
   PrintResultArray(arrys);
   bool trIsFl = FidnElem(arrys, 9);
