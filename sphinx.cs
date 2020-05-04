using System;
using System.Collections.Generic;
using System.Linq;

class Sphinx
{
  static Dictionary<string, string> riddles = new Dictionary<string, string> { };
  static void AskRiddle()
  {
    Random rand = new Random();

    if (riddles.Count > 0)
    {
      int riddleIndex = rand.Next(riddles.Count());
      Console.WriteLine(riddles.Keys.ElementAt(riddleIndex));
      string userInput = Console.ReadLine();
      string riddle = riddles.Values.ElementAt(riddleIndex);
      if (riddle == userInput.ToLower())
      {
        riddles.Remove(riddles.Keys.ElementAt(riddleIndex));
        Console.WriteLine("Yay!");
        AskRiddle();
      }
      else
      {
        Console.WriteLine("Nope the answer was " + riddle + "!");
        Console.WriteLine("Bye bye!");
      }
    }
    else
    {
      Console.WriteLine("You've solved my sphinx puzzle!");
    }
  }
  static void Main()
  {
    riddles.Add("I have a mouth but do not speek, I have a bed but do not sleep, I run everywhere but go nowhere, what am I?", "river");
    riddles.Add("I can run but not walk. Wherever I go, thought follows behind. What am I?", "nose");
    riddles.Add("I have holes in my top and bottom, my left and right, and my middle. But I still hold water. What am I?", "sponge");
    riddles.Add("David’s parents have three sons: Snap, Crackle, and what’s the name of the third son?", "david");
    riddles.Add("Give me food, and I will live; give me water, and I will die. What am I?", "fire");
    riddles.Add("It stalks the countryside with ears that can’t hear. What is it?", "corn");
    riddles.Add("I am an odd number. Take away a letter and I become even. What number am I?", "seven");
    riddles.Add("What begins with an “e” and only contains one letter?", "envelope");
    riddles.Add("What word is pronounced the same if you take away four of its five letters?", "queue");
    riddles.Add("The man who invented it doesn't want it. The man who bough it doesn't need it. The man who needs it dosen't know it. What is it?", "coffin");
    AskRiddle();
  }
}