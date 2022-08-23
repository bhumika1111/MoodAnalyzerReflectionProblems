using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    [TestClass]
    public class TestCase2
    {
        //TC1.2 - Given condition " I am in Happy mood should return Happy".
        [TestMethod]
          
            public void Given_Condition_I_Am_In_Happy_Mood_Should_Return_Happy()
            {
                //Arrange
                string message = "I am in Happy mood ";
                MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

                //Act 
                string result = moodAnalyze.AnalyseMood(message);

                //Assert
                Assert.AreEqual("Happy", result);
            }
        
    }
}
