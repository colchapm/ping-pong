using System;

class PingPong
{
  static void Main()
  {
    Console.WriteLine("Please enter a number greater than zero.");
    string stringInputNumber = Console.ReadLine();
    int intInputNumber = int.Parse(stringInputNumber);

    for (int index = 1; index <= intInputNumber; index++)
    {
      if (index % 3 == 0 && index % 5 == 0)
      {
        Console.WriteLine("ping-pong");
      } 
      else if (index % 3 == 0)
      {
        Console.WriteLine("ping");
      }
      else if (index % 5 == 0)
      {
        Console.WriteLine("pong");
      }
      else
      {
        Console.WriteLine(index);
      }
    }
  }
}