using System;
using System.Collections.Generic;
using System.Linq;

namespace Sphinx.Riddles
{
  class Riddle
  {
    private Dictionary<string, string> _riddles;

    public Riddle()
    {
      _riddles = new Dictionary<string, string>();
      _riddles.Add("I have a mouth but do not speek, I have a bed but do not sleep, I run everywhere but go nowhere, what am I?", "river");
      _riddles.Add("I can run but not walk. Wherever I go, thought follows behind. What am I?", "nose");
      _riddles.Add("I have holes in my top and bottom, my left and right, and my middle. But I still hold water. What am I?", "sponge");
      _riddles.Add("David’s parents have three sons: Snap, Crackle, and what’s the name of the third son?", "david");
      _riddles.Add("Give me food, and I will live; give me water, and I will die. What am I?", "fire");
      _riddles.Add("It stalks the countryside with ears that can’t hear. What is it?", "corn");
      _riddles.Add("I am an odd number. Take away a letter and I become even. What number am I?", "seven");
      _riddles.Add("What begins with an “e” and only contains one letter?", "envelope");
      _riddles.Add("What word is pronounced the same if you take away four of its five letters?", "queue");
      _riddles.Add("The man who invented it doesn't want it. The man who bough it doesn't need it. The man who needs it dosen't know it. What is it?", "coffin");
    }

    public static void BeSpooky()
    {
      Console.WriteLine("OoOooOooOoo");
    }
    public Dictionary<string, string> GetRiddles()
    {
      return _riddles;
    }

    public void SetRiddle(string riddle, string answer)
    {
      _riddles.Add(riddle, answer);
    }

    public void AskRiddle()
    {
      Random rand = new Random();

      if (_riddles.Count > 0)
      {
        int riddleIndex = rand.Next(_riddles.Count());
        Console.WriteLine(_riddles.Keys.ElementAt(riddleIndex));
        string userInput = Console.ReadLine();
        string riddle = _riddles.Values.ElementAt(riddleIndex);
        if (riddle == userInput.ToLower())
        {
          _riddles.Remove(_riddles.Keys.ElementAt(riddleIndex));
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
  }
}