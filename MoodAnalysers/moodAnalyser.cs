using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalysers
{
    public class moodAnalyser
    {

        string Message;
        public moodAnalyser(string Message)
        {
            this.Message = Message;
        }

        public string varificatioTest()
        {
            if (this.Message == "Happy")
            {
                return "Happy";
            }
            return "Sad";
        }

    }
}
