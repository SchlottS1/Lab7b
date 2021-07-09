using System;





class MainClass {

  public static int IntegerPower(int num1, int num2)
{

  int result = 0;

  if (num2 == 1) 
  {
    result = num1;

  } else if (num2 == 0)
  {
    result = 1;

  } else 
  {
    result = num1 * num1;
  
  for(int i = 0; i < num2 - 2; i++)
  {
    int temp = result * num1;
    result = temp;
  }
}
  return result;
}

  public static void Main (string[] args) {
    Console.WriteLine ("Please enter the base number");

    int baseNbr = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please enter the exponent");

    int exponent = Convert.ToInt32(Console.ReadLine());

    int answer = IntegerPower(baseNbr, exponent);

    Console.WriteLine("The solution is " + answer);
  }
}