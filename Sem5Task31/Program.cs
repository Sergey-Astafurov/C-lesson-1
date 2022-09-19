int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}
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


int[] NegativePositivSum(int[] arr)
{
   int[] sums = new int[2];
   for (int i = 0; i < arr.Length; i++){
      if(arr[i]>0){
         sums[0]+=arr[i];

      }
      else{
         sums[1] += arr[i];
      }
   }
   return sums;
}

int arraylengt = ReadData("Введи длинну");
int down = ReadData("Введи нижнию границу");
int top = ReadData("Введи верхнию границу");
int[] inputArray = FillArray(arraylengt,down,top);

PrintResultArray(inputArray);
int[] sumArray = NegativePositivSum(inputArray);
PrintResult("Сумма > 0: " + sumArray[0] + " Сумма < 0: " + sumArray[1]);


