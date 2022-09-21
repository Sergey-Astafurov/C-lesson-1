
// Из строки в число
int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}

// метод подсчета чисел больше нуля
int CountNum(int M)
{
   int result = 0;
   for (int i = 0; i < M; i++)
   {
      int num = ReadData("Введи число");
      if (num > 0){
         result++;
      }
   }
   return result;
}




// Вывод результата
void PrintResult(string line)
{
   Console.WriteLine(line);
}

//Тело программы
int m = ReadData("Введи количество чисел");
int count  = CountNum(m); // вычисления
PrintResult("ответ: " + count);


