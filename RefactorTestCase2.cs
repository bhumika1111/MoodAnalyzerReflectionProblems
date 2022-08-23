using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    /// <summary>
    /// Here We Refractor The Code For Happy Mood.
    /// </summary>
    [TestClass]
    public class RefactorTestCase2
    {
        //Refactor-TC1.2-Here we check the Given condition " I am in Happy mood should return Happy".
        [TestMethod]
        public void GivenIAmInHappyMoodShouldReturnHappy()
        {
            //Arrange
            string message = "I am in Happy mood ";
            string expected = "Happy";
            MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

            //Act 
            string mood = moodAnalyze.AnalyseMood(message);


            //Assert
            Assert.AreEqual(expected, mood);

        }       

    }
}
