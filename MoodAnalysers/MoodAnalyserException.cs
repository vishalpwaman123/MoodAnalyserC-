using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalysers
{
    
    public class MoodAnalyserException : Exception
    {
        public enum ExceptionType 
        {
            ENTERED_NULL, ENTERED_EMPTY
        }
        public ExceptionType type;
        public MoodAnalyserException(ExceptionType type, String message) : base(message)
        {
            this.type = type;
        }
    }
}
