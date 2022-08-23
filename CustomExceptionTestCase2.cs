using Microsoft.VisualStudio.TestTools.UnitTesting;
using CustomException;

namespace CustomExceptionTestCase
{
    [TestClass]
    public class CustomExceptionTestCase2
    {
            /// <summary>
            /// TC 3.2: Given Empty Mood Should Throw MoodAnalysisException Indicating Empty Mood.
            /// Given-When-Then
            /// </summary>
            [TestMethod]
            public void Given_Empty_Mood_Should_Throw_MoodAnalysisException_Indicating_Empty_Mood()
            {
                try
                {
                    string message = null;
                   MoodAnalyzer moodAnalyzer = new MoodAnalyzer();
                    string mood = moodAnalyzer.AnalyzeMood(message);

                }
                catch (MoodAnalyzerCustomException e)
                {
                    Assert.AreEqual("Mood Should Not Be Empty", e.Message);
                }
            }
        
    }
}
