using Palindromes.Models;
using System.Collections.Generic;
using Palindromes.UserInterfaceModels;
using System.Security.Cryptography.X509Certificates;

namespace PalindromeProgram;
class Program
{
    static void Main()
    {
        Console.WriteLine(WelcomeBanner.Welcome);
        Console.WriteLine("Enter a word, and this program will check if it is a Palindrome. Type 'exit' to quit:");

        while (true)
        {
            Console.Write("Word: ");
            string input = Console.ReadLine();

            if (input.ToLower() == "exit")
            {
                Console.WriteLine(GoodbyeBanner.Goodbye);
                break;
            }

            PalindromeChecker checker = new PalindromeChecker();
            checker.UserWord = input;

            bool isPalindrome = checker.IsItPalindrome();

            DisplayResult(isPalindrome, input);
        }
    }

    static void DisplayResult(bool isPalindrome, string input)
    {
        ConsoleColor originalColor = Console.ForegroundColor;

        Console.ForegroundColor = isPalindrome ? ConsoleColor.Green : ConsoleColor.Red;

        // Console.WriteLine(isPalindrome
        //     ? $"'{input}' is a palindrome!"
        //     : $"'{input}' is not a palindrome. Better luck next time \n
        //    {SuccessBanner.Success}");

        if (isPalindrome)
        {
          Console.ForegroundColor = ConsoleColor.Green;
          Console.WriteLine(SuccessBanner.Success);
          Console.WriteLine($"'{input}' is a palindrome!");
        }
        else
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.WriteLine(FailBanner.Fail);
          Console.WriteLine($"'{input}' is not a palindrome. Better luck next time.");
        }

        Console.ForegroundColor = originalColor;
    }
}

// using System;
// using System.Threading;

// class Program
// {
//   static void Main()
//   {
//     Console.WriteLine("                         +++++++++++++++++");
//     Console.WriteLine("                         Enter a Number:");
//     Console.WriteLine("                         +++++++++++++++++");

//     if (int.TryParse(Console.ReadLine(), out int userInput))
//     {
//       ConsoleColor[] colors = {
//         ConsoleColor.DarkRed,
//         ConsoleColor.Red,
//         ConsoleColor.DarkMagenta,
//         ConsoleColor.Magenta,
//         ConsoleColor.DarkYellow,
//         ConsoleColor.Yellow,
//         ConsoleColor.DarkGreen,
//         ConsoleColor.Green,
//         ConsoleColor.DarkBlue,
//         ConsoleColor.Blue,
//         ConsoleColor.Cyan,
//           };

//       for (int i = 1; i <= userInput; i++)
//       {
//         Thread.Sleep(100);
//         ApplyColor(colors[i % colors.Length]);

//         if (i % 3 == 0 && i % 5 == 0)
//         {
//           Console.WriteLine("Ping Pong");
//         }
//         else if (i % 5 == 0)
//         {
//           Console.WriteLine("Pong");
//         }
//         else if (i % 3 == 0)
//         {
//           Console.WriteLine("Ping");
//         }
//         else
//         {
//           Console.WriteLine(i);
//         }
//       }
//     }
//     else
//     {
//       Console.WriteLine( "Enter a Number: ");
//     }
//   }
//   static void ApplyColor(ConsoleColor colors)
//   {
//     Console.ForegroundColor = colors;
//   }

// }