// Напишите программу замена элементов массива:
// положительные элементы замените на
// соответствующие отрицательные, и наоборот.
// Пример:
// [-4, -8, 8, 2] -> [4, 8, -8, -2]

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
         arr[i] = sintezator.Next(down, top+1);

      }

   }
   return arr;
}


int[] InverseArray(int[] arr)
{
   for (int i = 0; i < arr.Length; i++){
      arr[i] = arr[i] * (-1);
   }

   return arr;
}


void PrintResultArray(int[] arr)
{
   for (int i = 0; i < arr.Length - 1; i++)
   {
      Console.Write(arr[i] + ", ");
   }
   Console.WriteLine(arr[arr.Length - 1]);
}

int[] arrys = FillArray(10,-9,9);
PrintResultArray(arrys);
int[] inversArr = InverseArray(arrys);
PrintResultArray(inversArr);