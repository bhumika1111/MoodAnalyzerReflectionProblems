using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerReflection
{
    /// <summary>
    /// UC1- Given A Message Ability To Analyse And Respond Happy Or Sad Mood.
    /// </summary>
      public class MoodAnalyzer
        {
            public string message;
            public MoodAnalyzer(string message)
            {
                this.message = message;
            }
            //Analysing the mood by passing happy Or sad.
            public string AnalyseMood(string message)
            {
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
       }
    
}
