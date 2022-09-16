int ReadData(string line)
{
   Console.WriteLine(line);
   int number = int.Parse(Console.ReadLine() ?? "0");
   return number;
}



void PrintResult(string line)
{
   Console.WriteLine(line);
}

int VariantSumSimple(int numA)
{
   int sumOfNumbers = 0;

   for (int i = 0; i < numA; i++)
   {
      sumOfNumbers+=i;

   }
   return sumOfNumbers;
}


int VariantSumgauss(int numA){
   int sumOfNumbers = 0;
   sumOfNumbers = ((1 + numA) * numA) / 2;
   return sumOfNumbers;
}



int numberA = ReadData("vvedi");
int res = VariantSumgauss(numberA);
// int res = VariantSumSimple(numberA);
PrintResult("Summa chisel ot 1 do A" + res);
