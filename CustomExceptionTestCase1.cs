using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomException;

namespace CustomExceptionTestCase
{
    [TestClass]
    public class CustomExceptionTestCase1
    {
            /// <summary>
            /// TC 3.1: Given Null Mood Should Throw MoodAnalysisException.
            /// Given-When-Then
            /// </summary>
            [TestMethod]
            public void Given_Null_Mood_Should_Throw_MoodAnalysisException()
            {
                try
                {
                    string message = null;
                   MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
                    string mood = moodAnalyzer.AnalyzeMood(message);

                }
                catch (MoodAnalyzerCustomException e)
                {
                    Assert.AreEqual("Mood Should Not Be Null", e.Message);
                }
            }
        
    }
}
