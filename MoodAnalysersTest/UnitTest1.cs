using NUnit.Framework;
using MoodAnalysers;
using System;

namespace MoodAnalysersTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        /// <summary>
        /// Added: Code Of Given Mood when Happy should Return Happy
        /// </summary>
        [Test]
        public void givenMood_whenHappy_shouldReturnHappy()
        {
            moodAnalyser MoodA = new moodAnalyser("Happy");
            string result = MoodA.varificatioTest();
            Assert.AreEqual("Happy", result);
        }

        /// <summary>
        ///  Added: Code Of Given Mood when Sad should Return Sad
        /// </summary>
        [Test]
        public void givenMood_whenSad_shouldReturnSad()
        {
            moodAnalyser MoodA = new moodAnalyser("Sad");
            string result = MoodA.varificatioTest();
            Assert.AreEqual("Sad", result);
        }

        /// <summary>
        /// Added: Code Of Given Mood when Pass Null Pointer should Return Happy
        /// </summary>
        [Test]
        public void givenMood_whenPassNullParameter_shouldReturnHappy()
        {
            
            string result = null;
            try
            {
                moodAnalyser MoodA = new moodAnalyser(null);
                result = MoodA.varificatioTest();    
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.ENTERED_NULL, e.type);
            }
        }

    }
}