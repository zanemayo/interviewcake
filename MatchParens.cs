/*
I like parentheticals (a lot).
"Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing."

Write a function that, given a sentence like the one above, along with the position of an opening parenthesis, finds the corresponding closing parenthesis.

Example: if the example string above is input with the number 10 (position of the first parenthesis), the output should be 79 (position of the last parenthesis).
*/

using System;

namespace Solution {
  class MatchParens: Solution {
    public int Run(string sentence, int openingParenPos) {
      var depth = 0;
      for (var i = openingParenPos; i < sentence.Length; i++) {
        if (sentence[i] == '(') depth++;
        if (sentence[i] == ')') depth--;
        if (depth == 0) return i;
      }
      throw new ArgumentException("Sentence malformed");
    }

    public void Test() {
      var closingParenPos = new MatchParens().Run("Sometimes (when I nest them (my parentheticals) too much (like this (and this))) they get confusing.", 10);
      Console.WriteLine(closingParenPos + " should equal " + 79);
    }
  }
}