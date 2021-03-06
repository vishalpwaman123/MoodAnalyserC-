﻿using System;
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
            }catch(MissingMethodException e)
            {
                return MoodAnalyserException.ExceptionType.No_Class_Method;
            }
             
        }

        public static string InvokeMethodUsingReflection(string methodName, string message)
        {
            try
            {
                MethodBase method = typeof(moodAnalyser).GetMethod(methodName);
                object objectInstance = Activator.CreateInstance(typeof(moodAnalyser), message);
                string mood = (string)method.Invoke(objectInstance, null);
                return mood;
            }
            catch (NullReferenceException e)
            {
                throw new MoodAnalyserException(MoodAnalyserException.ExceptionType.No_Class_Method, "Method Not Found");
            }

        }
    }
}
