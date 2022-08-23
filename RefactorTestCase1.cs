using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    /// <summary>
    /// Here We Refractor The Code For Both The Moods.
    /// </summary>
    [TestClass]
    public class RefactorTestCase1
    {
        //Refactor-TC1.1-Here we check the Given condition " I am in sad mood should return sad".
        [TestMethod]
        public void GivenIAmInSadMoodShouldReturnSad()
        {
            //Arrange
            string message = "I am in Sad mood ";
            string expected = "Sad";
            MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

            //Act 
            string mood = moodAnalyze.AnalyseMood(message);


            //Assert
            Assert.AreEqual(expected, mood);

        }       

    }
}
