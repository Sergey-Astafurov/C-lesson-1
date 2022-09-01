// №2 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

string? inputLineA = Console.ReadLine(); //Ввод первого числа
string? inputLineB = Console.ReadLine(); //Ввод второго числа
int max = 0;
if (inputLineA != null && inputLineB != null) //Проверка чтобы поле было заполнено
{
   int inputNumberA = int.Parse(inputLineA); //перевод строки в число
   int inputNumberB = int.Parse(inputLineB); //перевод строки в число

   if (inputNumberA == inputNumberB){ //проверка равны ли числа
      Console.WriteLine("они равны");
   }else if (inputNumberA > inputNumberB){ // если первое больше второго,то оно и будет максимальным
      max = inputNumberA;
      Console.WriteLine("max = " +  max);

   }else{ //иначе второе
      max = inputNumberB;
      Console.WriteLine("max = " +  max);

   }


}