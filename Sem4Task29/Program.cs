// Из строки в число

int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}
// Метод для генерации массива и обозначения его границ
int[] genArray(int arrayLenght, int start, int stop)
{
   Random rnd = new Random();
   int[] arr = new int[arrayLenght];
   for (int i = 0; i < arr.Length; i++)
   {
      arr[i] = rnd.Next(start, stop);
      Console.WriteLine(arr[i]);
   }
   return arr;
}
// Метод вызова результата
void PrintResult(int[] arr)
{
   for (int i = 0; i < arr.Length - 1; i++)
   {
      Console.Write(arr[i] + ", ");
   }
   Console.WriteLine(arr[arr.Length - 1]);
}

// сокращенная запись программы
PrintResult(genArray(ReadData("Введи число"), 10,100));
