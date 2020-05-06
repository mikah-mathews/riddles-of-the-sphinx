using Sphinx.Riddles;

namespace Sphinx
{
  public class Program
  {
    public static void Main()
    {
      Riddle riddle = new Riddle();
      Riddle.BeSpooky();
      riddle.SetRiddle("Why?", "because");
      riddle.AskRiddle();
    }
  }
}