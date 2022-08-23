using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    [TestClass]
    public class MoodAnalyzerTestCase5
    {
        /// <summary>
        /// Test Case 5.3-Given Constructor Name When Improper Should Throw MoodAnalysesException.
        /// </summary>


        [TestMethod]
        public void Given_Constructor_Name_When_Improper_Should_Throw_MoodAnalysesException()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyzers"; 
                string constructorName = "SampleMoodAnalyzer";//Wrong Class Name passed to pass test
                //Act
                object resultObj = MoodAnalyzerFactory.CreateMoodAnalyseUsingParameterizedConstructor(className, constructorName,"HAPPY");
            }
            catch (MoodAnalyzerCustomException e)
            {
                //Assert
                Assert.AreEqual("Constructor is Not Found", e.Message);
            }






        }



    }
}
