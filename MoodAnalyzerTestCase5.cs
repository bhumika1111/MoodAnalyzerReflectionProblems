using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflection;

namespace MoodAnalyzerReflectionTest
{
    [TestClass]
    public class MoodAnalyzerTestCase5
    {
        /// <summary>
        /// Test Case 5.1-MoodAnalyse Class Name Should Return MoodAnalyser Object.
        /// </summary>


        [TestMethod]
        public void MoodAnalyse_Class_Name_ShouldReturn_MoodAnalyser_Object()
        {
                 //Arrange
               object expected = new MoodAnalyzer("HAPPY");
              
                     //Act
               object Obj = MoodAnalyzerFactory.CreateMoodAnalyseUsingParameterizedConstructor("MoodAnalyzerReflection.MoodAnalyzer","MoodAnalyzer","HAPPY");

                    //Assert
                expected.Equals(Obj);
                
               




        }



    }
}
