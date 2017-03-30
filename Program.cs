using System;

namespace Solution
{
    class Program
    {
        public static string MyFunction(string arg)
        {
            // Write the body of your function here
            return $"Running with {arg}";
        }



        public static void Main(string[] args)
        {
            // Run your function through some test cases here.
            // Remember: debugging is half the battle!
            //string testInput = "test input";
            // Console.WriteLine(MyFunction(testInput));

            // Solution solution = new RecursivePermutation();
            // solution.Test();

            // solution = new FindDuplicate();
            // solution.Test();

            // new MatchParens().Test();
            // new PermutationPalindrome().Test();

            // new Rand7().Test();
            // new Rand5().Test();

            new MovieLengths().Test();

        }
    }
}
