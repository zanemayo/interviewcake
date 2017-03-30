using System;

namespace Solution
{
  class Rand5 : Solution
  {
    int Run(Func<int> rand7)
    {
      while(true) {
        var result = rand7();
        if (result <= 5) return result;
      }
    }

    Random r = new Random();
    int Rand7() => r.Next(7) + 1;
    public void Test()
    {
      var solution = new Rand5();

      var runs = 10000000;
      var dist = new int[8];
      for (int i = 0; i < runs; i++)
      {
        dist[solution.Run(Rand7)]++;
      }
      for (int i = 1; i < 8; i++)
      {
        Console.WriteLine(i + ": " + (dist[i] / (runs + 0.0)));
      }
    }


  }
}