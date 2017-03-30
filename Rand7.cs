using System;

namespace Solution
{
  class Rand7 : Solution
  {
    static Random r = new Random();
    int Rand5()
    {
      return r.Next(5) + 1;
    }

    public int Run(Func<int> rand5)
    {
      int numRolls = 20;
      long num = 0;
      for (int i = 0; i < numRolls; i++) {
        num += (rand5() - 1) * (long)Math.Pow(5, i);
      }
      return (int)((num % 7) + 1);
    }

    public void Test()
    {
      var solution = new Rand7();

      var runs = 1000000;
      var dist = new int[8];
      for (int i = 0; i < runs; i++)
      {
        dist[solution.Run(Rand5)]++;
      }
      for (int i = 1; i < 8; i++)
      {
        Console.WriteLine(i + ": " + (dist[i] / (runs + 0.0)));
      }
    }
  }
}