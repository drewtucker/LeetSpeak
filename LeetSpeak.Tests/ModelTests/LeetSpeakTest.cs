using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using LeetSpeak.Models;
using LeetSpeak;

namespace LeetSpeak.Tests
{
  [TestClass]
  public class LeetSpeakTest
  {
    [TestMethod]
    public void GetSentence_ReplaceEWith3_String()
    {
      string TestSentence =  "This is L33tSp3ak!";
      string ConvertedSentence = Eto3(inputSentence);
      Assert.AreEqual(TestSentence, ConvertedSentence);
    }
  }
}
