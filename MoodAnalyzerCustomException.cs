using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerReflection
{
    public class MoodAnalyzerCustomException : Exception
    {
        /// <summary>
        /// Enum For Exception Type
        /// </summary>
        public enum ExceptionType
        {
            NULL_MESSAGE,
            EMPTY_MESSAGE,
            NO_SUCH_FIELD,
            NO_SUCH_METHOD,
            NO_SUCH_CLASS,
            OBJECT_CREATION_ISSUE
        }
        //Creating 'type' variable of type Exceptiontype
        private readonly ExceptionType type;
        /// <summary>
        /// Parameterized constructor sets the Exception Type and message.
        /// </summary>
        /// <param name="Type"></param>
        /// <param name="message"></param>
        public MoodAnalyzerCustomException(ExceptionType Type, String message) : base(message)
        {
            this.type = Type;
        }
    }
}
