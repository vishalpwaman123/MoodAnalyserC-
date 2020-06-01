using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MoodAnalysers
{
    public class MoodAnalyserReflaction
    {
        public static object CreateObjectUsingReflection(string className, params object[] construct)
        {
            Type type = Type.GetType(className);
            if (type==null)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Class_Exception, " ");
            }
            try
            {
                var objInstance = Activator.CreateInstance(type,construct);
                if(objInstance==null)
                {
                    throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Class_Method, " ");
                }
                return objInstance;
            }catch(MissingMethodException)
            {
                return MoodAnalyserException.ExceptionType.No_Class_Method;
            }
             
        }

        public static string InvokeMethodUsingReflaction(string MethodName , string FieldName)
        {
            Type moodAnalyserType = Type.GetType("MoodAnalysers.moodAnalyser");
            string[] stringArray = {"Happy"};
            var objInstance = Activator.CreateInstance(moodAnalyserType, stringArray);
            try
            {
                if (FieldName!=null)
                {
                    FieldInfo fieldInfo = moodAnalyserType.GetField(FieldName);
                    if(fieldInfo!=null)
                    {
                        throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Field_Exception," ");
                    }
                    else
                    {
                        return "Happy";
                    }
                    
                }else
                {
                    return MoodAnalyserException.ExceptionType.No_Field_Exception.ToString();
                }
            }catch(MoodAnalyserException)
            {
                return MoodAnalyserException.ExceptionType.No_Field_Exception.ToString();
            }
            return "Happy";
        }
    }
}
