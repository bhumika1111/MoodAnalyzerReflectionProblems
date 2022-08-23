using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    [TestClass]
    public class TestCase1
    {
        //Here we check the Given condition " I am in sad mood should return sad".
        [TestMethod]
          
         
            public void Given_Condition_I_Am_In_Sad_Mood_Should_Return_Sad()
            {
                //Arrange
                string message = "I am in Sad mood ";
                MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

                //Act 
                string result = moodAnalyze.AnalyseMood(message);

                //Assert
                Assert.AreEqual("Sad", result);
            }
        
    }
}
