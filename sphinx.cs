using System;

class Sphinx
{
  static void Main()
  {
    string riddle = "I have a mouth but do not speek, I have a bed but do not sleep, I run everywhere but go nowhere, what am I?";
    string answer = "river";
    Console.WriteLine(riddle);
    string userInput = Console.ReadLine();
    if (answer == userInput)
    {
      Console.WriteLine("Yay!");
    }
    else
    {
      Console.WriteLine("Bye bye!");
    }
  }
}