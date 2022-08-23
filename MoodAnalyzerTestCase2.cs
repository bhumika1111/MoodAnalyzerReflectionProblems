using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    [TestClass]
    public class MoodAnalyzerTestCase2
    {
        /// <summary>
        /// Test Case 4.2  Given improper Class name should throw Class not found exception.
        /// </summary>


        [TestMethod]
        public void Given_Improper_Class_Name_Should_Throw_MoodAnalysisException_Indicating_No_Such_Class()
        {

            
                try
                {
                    //Arrange
                    string className = "DemoMoodAnalyzers"; //Wrong Class Name passed to pass test
                string constructorName = "MoodAnalyzer";     
                    //Act
                    object resultObj = MoodAnalyzerFactory.CreateMoodAnalyse(className,constructorName);
                }
                catch (MoodAnalyzerCustomException e)
                {
                    //Assert
                    Assert.AreEqual("Constructor is Not Found", e.Message);
                }
            




        }



    }
}
