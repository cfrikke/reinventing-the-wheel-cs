using System;

namespace MyUtilityPackage
{
    public static class StringUtils
    {
        // Method to convert a string to uppercase
        public static string ToUpper(string s)
        {
            return s.ToUpper();
        }

        // Method to convert a string to lowercase
        public static string ToLower(string s)
        {
            return s.ToLower();
        }

        // Method to get the length of a string
        public static int Length(string s)
        {
            return s.Length;
        }

        // Method to reverse a string
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }

        // Method to count vowels in a string
        public static int CountVowels(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if ("AEIOUaeiou".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        // Method to count consonants in a string
        public static int CountConsonants(string s)
        {
            int count = 0;
            foreach (char c in s)
            {
                if (char.IsLetter(c) && !"AEIOUaeiou".Contains(c))
                {
                    count++;
                }
            }
            return count;
        }

        // Method to check if a string contains a specific letter
        public static bool HasLetter(string s, char letter)
        {
            foreach (char c in s)
            {
                if (c == letter)
                {
                    return true;
                }
            }
            return false;
        }

        // Additional method 1: Concatenates two strings
        public static string Concatenate(string s1, string s2)
        {
            return s1 + s2;
        }

        // Additional method 2: Checks if a string is palindrome
        public static bool IsPalindrome(string s)
        {
            string reversedString = Reverse(s);
            return s.Equals(reversedString, StringComparison.OrdinalIgnoreCase);
        }

        // Additional method 3: Removes all occurrences of a character from a string
        public static string RemoveCharacter(string s, char character)
        {
            return s.Replace(character.ToString(), "");
        }
    }
}
