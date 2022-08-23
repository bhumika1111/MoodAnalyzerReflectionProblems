using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;
using System;

namespace MoodAnalyzerReflectionTest
{
    /// <summary>
    /// Here,Handle Exception If User Provides Null Mood Should Return Happy".
    /// </summary>
    [TestClass]
    public class HandleExceptionTestCase1
    {
        //TC2.1-Handle Exception If User Provides Null Mood Should Return Happy".
        [TestMethod]
        public void Handle_Exception_If_User_Provides_Invalid_Mood()
        {
            try
            {
                //Arrange
                string message = "Null";

                //referance
                MoodAnalyzer moodAnalyze = new MoodAnalyzer(message);

                //Act 
                string result = moodAnalyze.AnalyseMood(message);



            }

            catch (NullReferenceException e)
            {
                //Assert

                Assert.AreEqual("Happy", e.Message);



            }

        }
    }
}
