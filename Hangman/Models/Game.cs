using System;
using System.Collections.Generic;

namespace Hangman.Models
{
  public class Game
  {
    public static string[] Words = new string[] { "baseball", "zebra", "elephant", "tennis", "scuba", "government" };
    public static string Word { get; set; }
    public static List<char> Incorrect { get; set; }
    public static List<char> Guesses { get; set; }
    public static List<char> HiddenWord { get; set; }

    public Game()
    {
      Incorrect = new List<char>();
      Guesses = new List<char>();
      HiddenWord = new List<char>();
      Random rand = new Random();
      Word = Words[rand.Next(0, Words.Length)];
      for (int i = 0; i < Word.Length; i++)
      {
        HiddenWord.Add('_');
      }
    }

    public static void Guess(char guess)
    {
      if (Word.Contains(guess))
      {
        for (int i = 0; i < Word.Length; i++)
        {
          if (Word[i] == guess)
          {
            HiddenWord[i] = guess;
          }
        }
      }
      else
      {
        Incorrect.Add(guess);
      }
    }

  }
}