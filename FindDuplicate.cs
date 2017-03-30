/*
Find a duplicate, Space Edition™.
---------------------------------
We have a list of integers, where:

The integers are in the range 1..n1..n
The list has a length of n+1n+1
It follows that our list has at least one integer which appears at least twice. But it may have several duplicates, and each duplicate may appear more than twice.

Write a function which finds an integer that appears more than once in our list. (If there are multiple duplicates, you only need to find one of them.)

We're going to run this function on our new, super-hip Macbook Pro With Retina Display™. Thing is, the damn thing came with the RAM soldered right to the motherboard, so we can't upgrade our RAM. So we need to optimize for space!

https://www.interviewcake.com/question/python/find-duplicate-optimize-for-space?utm_source=weekly_email&utm_campaign=weekly_email&utm_medium=email
*/

using System.Collections.Generic;
using System;

namespace Solution {
  class FindDuplicate : Solution {

    public int Run(List<int> nums) {
      nums.Sort();
      int? lastNum = null;
      foreach (var num in nums) {
        if (lastNum == null) {
          lastNum = num;
          continue;
        }
        if (num == lastNum) return num;
        lastNum = num;
      }
      throw new ArgumentException("No duplicates in list");
    }

    public void Test() {
      Console.WriteLine(new FindDuplicate().Run(new List<int> {1,2,3,4,3}));


    }

  }
}