using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalysers
{
    public class moodAnalyser
    {

        string Message;

        public moodAnalyser()
        {
        }

        public moodAnalyser(string Message)
        {
            this.Message = Message;
        }

      

        public string AnalyserMood()
        {
            try
            {
                if (Message.Length == 0)
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_EMPTY, "Please Enter Proper Mood");
                if (Message.Contains("Sad"))
                    return "Sad";
                return "Happy";
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.ENTERED_NULL, "Please Enter Proper");
            }
        }
    }
}
