/*
You've built an in-flight entertainment system with on-demand movie streaming.
Users on longer flights like to start a second movie right when their first one ends, but they complain that the plane usually lands before they can see the ending. So you're building a feature for choosing two movies whose total runtimes will equal the exact flight length.

Write a function that takes an integer flight_length (in minutes) and a list of integers movie_lengths (in minutes) and returns a boolean indicating whether there are two numbers in movie_lengths whose sum equals flight_length.

When building your function:

Assume your users will watch exactly two movies
Don't make your users watch the same movie twice
Optimize for runtime over memory
Gotchas
We can do this in O(n)O(n) time, where nn is the length of movie_lengths.

Bonus
What if we wanted the movie lengths to sum to something close to the flight length (say, within 20 minutes)?
What if we wanted to fill the flight length as nicely as possible with any number of movies (not just 2)?
What if we knew that movie_lengths was sorted? Could we save some space and/or time?
*/
using System;
using System.Collections.Generic;

namespace Solution {
  class MovieLengths : Solution {

    public static bool Run(int flightLen, int[] movieLens) {
      var timeLeft = new HashSet<int>();

      foreach (var movieLen in movieLens) {
        if (timeLeft.Contains(movieLen)) return true;
        timeLeft.Add(flightLen - movieLen);
      }

      return false;

    }

    public void Test() {
      var movieList = new [] {1,};
      MovieLengths.Run(10, movieList);
      Console.WriteLine("Expected True, found " + Run(10, new [] {1, 2, 3, 4, 5, 6}));
      Console.WriteLine("Expected False, found " + Run(14, new [] {1, 2, 3, 4, 5, 6, 7}));
      Console.WriteLine("Expected False, found " + Run(10, new [] {1, 2, 4, 5, 7, 7}));
    }
  }
}