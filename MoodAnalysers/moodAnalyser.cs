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
            try
            {
                if (Message.Contains( "Happy"))
                {
                    return "Happy";
                }
                else
                {
                    return "Sad"; 
                }
            }catch(NullReferenceException e)
            {
                return "Happy";
            }
        }

    }
}
