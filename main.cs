using System;

class Program {
  public static void Main (string[] args) {

    string answer;

    do
    {
    Console.WriteLine ("Enter a number");

    int num1 = Convert.ToInt32(Console.ReadLine());

    for (int i = 2; i < num1; i++)

    if (num1 % i == 0)
    {
      Console.WriteLine("This is a non-prime number!");
      break;
    }
    
    else
    {
      Console.WriteLine("This is a prime number!");
      break;
    }
    Console.WriteLine("Do you want to continue? (y/n)");
      answer = Console.ReadLine();
    } while (answer == "y");

  }
}