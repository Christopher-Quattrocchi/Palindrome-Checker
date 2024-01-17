using System;

namespace Palindromes.Models
{
  public class PalindromeChecker
  {
    private string _userWord;
    public string UserWord
    {
      get { return _userWord; }
      set { _userWord = value; }
    }

    public char[] GetWordAsArray()
    {
      if (string.IsNullOrEmpty(_userWord))
        return new char[0];
        
      return _userWord.ToCharArray();


    }
    public bool IsItPalindrome()
    {
      char[] wordArray = GetWordAsArray();
      int Length = wordArray.Length;

      for (int i = 0; i < Length / 2; i++)
      {

        if (char.ToLower(wordArray[i]) != char.ToLower(wordArray[Length - 1 - i]))
        {
          return false;
        }
      }
      return true;
    }
  }
}