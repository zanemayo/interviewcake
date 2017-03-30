/*
Write an efficient function that checks whether any permutation ↴ of an input string is a palindrome ↴ .
You can assume the input string only contains lowercase letters.

Examples:

"civic" should return True
"ivicc" should return True
"civil" should return False
"livci" should return False
*/

using System;
using System.Collections.Generic;

namespace Solution
{
  class PermutationPalindrome : Solution
  {

    public bool Run(string word)
    {
      var wordChars = word.ToCharArray();
      Array.Sort(wordChars);
      char? last = null;
      var middleFound = false;
      foreach (var c in wordChars)
      {
        if (last == null)
        {
          last = c;
          continue;
        }

        if (last == c)
        {
          last = null;
          continue;
        }

        if (middleFound) return false;

        middleFound = true;
      }

      if (word.Length % 2 == 0 && (middleFound || last != null))
      {
        return false;
      }
      if (middleFound && last != null)
      {
        return false;
      }
      return true;

    }

    public bool RunO1(string word)
    {
      var charCounts = new Dictionary<char, int>();
      foreach (var c in word)
      {
        if (!charCounts.ContainsKey(c)) charCounts[c] = 0;
        charCounts[c]++;
      }
      bool oddAllowed = word.Length % 2 != 0;
      // Can also remove this part by removing items from the dict/set and checking the set length
      foreach (var count in charCounts)
      {
        if (count.Value % 2 == 0) continue;
        if (!oddAllowed) return false;
        oddAllowed = false;
      }
      return true;
    }

    public void Test()
    {
      Console.WriteLine(RunO1("civic") + " Should be true");
      Console.WriteLine(RunO1("ciic") + " Should be true");
      Console.WriteLine(RunO1("cvcii") + " Should be true");
      Console.WriteLine(RunO1("civil") + " Should be false");
      Console.WriteLine(RunO1("ciil") + " Should be false");
      Console.WriteLine(RunO1("cvlii") + " Should be false");
      Console.WriteLine(RunO1("c") + " Should be true");

    }

  }
}