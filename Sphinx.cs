
using System;
using System.Collections.Generic;

class SphinxRiddle
{
    public static Dictionary<int, string> riddles = new Dictionary<int, string>(){ {1, "What is the creature that walks on four legs in the morning, two legs at noon and three in the evening?"},{2, "He who makes it, does not need it. He who buys it, has no use for it. He who uses it, can neither see nor feel it. What is it?"},{3, "I'm tall when I'm young and I'm short when I'm old. What am I?"},{4, "What can travel around the world while staying in a corner?"}, {5, "What has hands but can not clap?"}, {6, "You can drop me from the tallest building and I'll be fine, but if you drop me in water I die. What am I?"}, {7 , "What gets wetter and wetter the more it dries?"}, {8, "What has a head and a tail, but no body?"}, {9, "What has an eye but can not see?"}};
    public static Dictionary<int, string> answers = new Dictionary<int, string>(){ {1, "man"},{2, "coffin"},{3, "candle"}, {4, "stamp"}, {5, "clock"}, {6, "paper"}, {7, "towel"}, {8, "coin"}, {9, "needle"}};
    public static Dictionary<int, string> usedRiddles = new Dictionary<int,string>() {};
  static void Main()
  {
    Console.WriteLine("A Sphinx in a green suit looms before you, 'Are you ready to answer my riddle? [y for yes]");
    string readyCheck = Console.ReadLine();
    if (readyCheck.ToLower() == "y") 
    {
      for (int i = 0; i < 3; i++) {
      int selector = chooseRiddle();
      askRiddle(selector, i);
      }
    }   
  }

  static void askRiddle(int selector, int i)
  {
      Console.WriteLine(riddles[selector]);
      Console.WriteLine("What is your answer?");
      string userAnswer = Console.ReadLine();
      if (userAnswer.ToLower() == answers[selector] && i < 3) {
      Console.WriteLine("Well done, on to the next:");
      } else if (userAnswer.ToLower() == answers[selector]) {
        Console.WriteLine("You have answered all my riddles, way go!");
        return;
      } else {
          Console.WriteLine("You amatuer, I shall now devour you!");
          Console.WriteLine("You die a painful death in the jaws of the Sphinx");
          return;
      }
  } 
  static int chooseRiddle() 
  {
    Random rando = new Random();
    int currentRiddle = rando.Next(1,9);
    while (usedRiddles.ContainsKey(currentRiddle)) 
    {
      currentRiddle = rando.Next(1,9);
    }
    usedRiddles.Add(currentRiddle,riddles[currentRiddle]);
    return currentRiddle;
  }  
}