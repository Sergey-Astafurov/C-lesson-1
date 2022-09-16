
// Из строки в число
int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}

// Создаем метод с циклом
long PowNum(int A, int B)
{
   long result = 1; //Начинаем с единицы чтобы получить правильный ответ а не 0!
   for (int i = 1; i <= B; i++)
   {
      result = result * A; // простой цикл через For  где мы кладем произведение в одну переменную
   }
   return result;
}

int SumNum(int A, int B){
   int result = 0;
   result = A + B;
   return result;
}

int MinusNum(int A, int B){
   int result = 0;
   result = A - B;
   return result;
}
int DelNum(int A, int B){
   int result = 0;
   result = A / B;
   return result;
}
int MultNum(int A, int B){
   int result = 0;
   result = A * B;
   return result;
}



void PrintResult(string line)
{
   Console.WriteLine(line);
}


int numA = ReadData("Введи число A");
int numB = ReadData("Введи число B");

long ColculatePow = PowNum(numA, numB);
PrintResult("возведение в степень: " + ColculatePow);

int CalSumNum = SumNum(numA, numB);
PrintResult("сложение: " + CalSumNum);

int CalMinusNum = MinusNum(numA, numB);
PrintResult("вычитание: " + CalMinusNum);

int CalDelNum = DelNum(numA, numB);
PrintResult("деление: " + CalDelNum);

int CalMultNum = MultNum(numA, numB);
PrintResult("умножение: " + CalMultNum);



