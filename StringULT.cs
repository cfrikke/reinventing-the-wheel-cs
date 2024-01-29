using System;
{}

namespace MyUtilityPackage {
  public static class StringUtils {
    // Method to convert a string to uppercase
    public static string ToUpper(string s) {
      return s.ToUpper();
    }

    // Method to convert a string to lowercase
    public static string ToLower(string s) {
      return s.ToLower();
    }

    // Method to get the length of a string
    public static int Length(string s) {
      return s.Length;
    }

    // Method to reverse a string
    public static string Reverse(string s) {
      char[] charArray = s.ToCharArray();
      Array.Reverse(charArray);
      return new string(charArray);
    }

    // Method to count vowels in a string
    public static int CountVowels(string s) {
      int count = 0;
      foreach(char c in s) {
        if ("AEIOUaeiou".Contains(c)) {
          count++;
        }
      }
      return count;
    }
  }