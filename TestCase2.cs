using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    /// <summary>
    /// Here We Refractor The Code For Both The Moods.
    /// </summary>
    [TestClass]
    public class TestCase2
    {
        //TC1.2-Here we check the Given condition " I am in sad mood should return sad".
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



        // TC1.2-Here we check the Given condition " I am in Any mood should return Happy".
        [TestMethod]
        public void GivenIAmInAnyMoodShouldReturnHappy()
        {
            //Arrange
            string message = "I am in any mood ";
            string expected = "Happy";
            MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

            //Act 
            string mood = moodAnalyze.AnalyseMood(message);


            //Assert
            Assert.AreEqual(expected, mood);

        }

       
        

    }
}
