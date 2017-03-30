using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Solution
{
  // Write a recursive function for generating all permutations of an input string. Return them as a set.
  class RecursivePermutation : Solution
  {
    public void Run()
    {
      Console.WriteLine("running");
    }

    public HashSet<string> CalculatePermutations(string input) {
      var results = new HashSet<string>();
      CalculateInner(results, input);
      return results;
    }

    public void CalculateInner(HashSet<string> results, string input, string current = "") {
      if (input.Length == 0) {
        results.Add(current);
        return;
      }
      for (var i = 0; i < input.Length; i++) {
        CalculateInner(results, input.Remove(i, 1), current + input[i]);
      }
    }

    private bool SetContains<T>(HashSet<T> set, IEnumerable<T> items) {
      foreach (var item in items) {
       if (!set.Contains(item)) return false;
      }
      return true;
    }


    public void Test()
    {
      var solution = new RecursivePermutation();
      foreach (var s in CalculatePermutations("abc")) Console.WriteLine(s);
      Debug.Assert(SetContains(solution.CalculatePermutations("abc"), new string[]{"abc", "acb", "bac", "bca", "cab", "cba"}));
      Debug.Assert(solution.CalculatePermutations("abc").Count == 6);
    }

  }
}