using System;
using System.Collections.Generic;

namespace LeetSpeak.Models
{
  public class LeetSpeakGenerator
  {

    public char[] inputSentence = "This is LeetSpeak!".ToCharArray();
    public List<char> inputList = new List<char>{};
    public string returnSentence = "";

    public string Eto3(char[] sentence)
    {
      foreach(char letter in sentence)
      {
        if(letter.ToString() == "e" || letter.ToString() == "E")
        {
          string newLetter = "3";
          return newLetter;
        }
        else
        {
          return letter;
        }
      }
    }
  }
}
