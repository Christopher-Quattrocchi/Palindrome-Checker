using Palindromes.Models;
using System.Collections.Generic;

namespace PalindromeProgram;
class Program
{
  static void Main()
  {
    Console.WriteLine("Enter a word, and this program will check if it is a Palindrome. Type 'exit' to quit:");

    while (true)
    {
      Console.Write("Word: ");
      string input = Console.ReadLine();

      if (input.ToLower() == "exit")
      {
        break;
      }

      PalindromeChecker checker = new PalindromeChecker();
      checker.UserWord = input;

      bool isPalindrome = checker.IsItPalindrome();

      if (isPalindrome)
      {
        Console.WriteLine($"'{input}' is a palindrome!");
      }
      else
      {
        Console.WriteLine($"'{input}' is not a palindrome. Better luck next time");
      }


    }
  }
}