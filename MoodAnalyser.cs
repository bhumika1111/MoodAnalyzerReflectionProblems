using System;
using System.Collections.Generic;
using System.Text;

namespace CustomException
{
    /// <summary>
    /// UC3 -Inform User If Enter Invalid Mood.
    /// </summary>
    public class MoodAnalyzer
    {
       string message;

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="message"></param>

        public string AnalyzeMood(string message)
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (this.message.Contains("Sad"))
                {
                    return "SAD";
                }
                else
                {
                    return "HAPPY";
                }
            }

            catch (NullReferenceException)
            {
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
