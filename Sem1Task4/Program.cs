//№4 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

string? inputLineA = Console.ReadLine(); //Ввод первого числа
string? inputLineB = Console.ReadLine(); //Ввод второго числа
string? inputLineC = Console.ReadLine(); //Ввод третьего числа
if (inputLineA != null && inputLineB != null && inputLineC != null) //Проверка чтобы поле было заполнено
{
   int inputNumberA = int.Parse(inputLineA); //перевод строки в число
   int inputNumberB = int.Parse(inputLineB); //перевод строки в число
   int inputNumberC = int.Parse(inputLineC); //перевод строки в число
   int max = inputNumberA; // делаем что макс пока что первое число
   if (inputNumberA == inputNumberB && inputNumberB == inputNumberC)
   { //проверка равны ли числа
      Console.WriteLine("они равны");
   }
   else if (inputNumberB > inputNumberA)
   { // если второе больше первого,то оно и будет максимальным
      max = inputNumberB;

      if (inputNumberC > max) // если 3-е больше максимального то 3 становится максимальным
      {
         max = inputNumberC;
      }

   }

   Console.WriteLine("max = " + max);

}