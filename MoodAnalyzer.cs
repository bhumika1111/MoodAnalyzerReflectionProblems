﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerReflectionProb
{
   public class MoodAnalyzer
    {
        public MoodAnalyzer() { }
        public string message;

        /// <summary>
        /// Parameterized constructor.
        /// </summary>
        /// <param name="message"></param>
        public MoodAnalyzer(string message)
        {
            this.message = message;
        }

        public string AnalyzeMood()
        {
            try
            {
                if (this.message.Equals(string.Empty))
                {
                    throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.EMPTY_MESSAGE, "Mood Should Not Be Empty");
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
                throw new MoodAnalyzerCustomException(MoodAnalyzerCustomException.ExceptionType.NULL_MESSAGE, "Mood Should Not Be Null");
            }

        }
    }
}
