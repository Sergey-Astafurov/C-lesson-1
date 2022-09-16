int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}
int[] genArray(int num)
{
   Random rnd = new Random();
   int[] arr = new int[num];
   for (int i = 0; i < arr.Length; i++)
   {
      arr[i] = rnd.Next(0, 2);

   }
   return arr;
}



void PrintResult(int[] arr)
{
   for (int i = 0; i < arr.Length; i++)
   {
      Console.Write(arr[i]);
   }
}

PrintResult(genArray(ReadData("Введи число")));
