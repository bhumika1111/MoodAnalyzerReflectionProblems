using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    [TestClass]
    public class MoodAnalyzerTestCase5
    {
        /// <summary>
        /// Test Case 5.2-Given Class Name When Improper Should Throw MoodAnalysesException.
        /// </summary>


        [TestMethod]
        public void Given_Class_Name_When_Improper_Should_Throw_MoodAnalysesException()
        {
            try
            {
                //Arrange
                string className = "DemoMoodAnalyzers"; //Wrong Class Name passed to pass test
                string constructorName = "MoodAnalyzer";
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
