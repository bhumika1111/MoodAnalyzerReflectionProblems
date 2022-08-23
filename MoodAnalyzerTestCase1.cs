using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyzerReflectionProb;

namespace MoodAnalyzerReflectionTest
{
    [TestClass]
    public class MoodAnalyzerTestCase1
    {

            /// <summary>
            /// Test Case 4.1 Given MoodAnalyse Class Name Should Return MoodAnalyser Object.
            /// </summary>
            [TestMethod]
            public void GivenMoodAnalyseClassName_ShouldReturnMoodAnalyserObject()
            {
                string message = null;
                object expected = new MoodAnalyzer(message);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyzerReflectionProb.MoodAnalyzer", "MoodAnalyzer");
                expected.Equals(obj);

            }
        }
}
