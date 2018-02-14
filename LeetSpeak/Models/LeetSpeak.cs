using System.Collections.Generic;

namespace LeetSpeakApp.Models
{
  public class LeetSpeak
  {
    private string _translation;
    public string translatedSentence = "";
    public string GetTranslation()
    {
      return _translation;
    }

    public void SetTranslation(string translatedSentence)
    {
      _translation = translatedSentence;
    }

    public static string LeetTranslate(string inputSentence)
    {
      string translatedSentence = inputSentence.Replace("e", "3").Replace("E", "3").Replace("A", "4").Replace("a", "4").Replace("t", "7").Replace("T", "7").Replace("s", "z").Replace("o", "0").Replace("O", "0");
      return translatedSentence;
    }
  }
}
