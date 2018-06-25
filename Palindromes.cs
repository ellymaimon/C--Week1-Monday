using System;
using System.Collections.Generic;

class Word
{
    private string _userWord;

    public Word(string wordInput)
    {
      _userWord = wordInput;
    }

    public string GetWord()
    {
        return _userWord;
    }

    public char[] MakeArray()
    {
        return this.GetWord().ToCharArray();
    }

    public string ReverseArray()
    {
        char[] reversed = this.MakeArray();
        Array.Reverse(reversed);
        string reversedString = new string(reversed);
        return reversedString;
    }

    public void isPalindrome()
    {
        if (this.GetWord() == this.ReverseArray())
        {
            Console.WriteLine("Your word is a palindrome");
        }
        else
        {
            Console.WriteLine("Your word is NOT a palindrome");
        }
    }

}

class Program
{
    public static void Main()
    {
        Console.WriteLine("Enter a word:");
        string inputWord = Console.ReadLine();
        Word ourWord = new Word(inputWord);
        // Console.WriteLine("Your array is " + ourWord.MakeArray()[0]);
        // Console.WriteLine(ourWord.ReverseArray());
        ourWord.isPalindrome();




    }
}
