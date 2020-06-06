using NUnit.Framework;
using MoodAnalysers;

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
            string result = MoodA.AnalyserMood();
            Assert.AreEqual("Happy", result);
        }

        /// <summary>
        ///  Added: Code Of Given Mood when Sad should Return Sad
        /// </summary>
        [Test]
        public void givenMood_whenSad_shouldReturnSad()
        {
            moodAnalyser MoodA = new moodAnalyser("Sad");
            string result = MoodA.AnalyserMood();
            Assert.AreEqual("Sad", result);
        }

        /// <summary>
        /// Added: Code Of Given Mood when Pass Null Pointer should Return Happy
        /// </summary>
        [Test]
        public void givenMood_whenPassNullParameter_shouldReturnProperMessage()
        {
            string result = null;
            try
            {
                moodAnalyser MoodA = new moodAnalyser(null);
                result = MoodA.AnalyserMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.ENTERED_NULL, e.type);
            }
        }

        [Test]
        public void givenMood_whenPassEmptyStringParameter_shouldReturnProperMesssage()
        {
            string result = null;
            try
            {
                moodAnalyser MoodA = new moodAnalyser(" ");
                result = MoodA.AnalyserMood();
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.ENTERED_EMPTY, e.type);
            }
        }

        /// <summary>
        ///Added: Code Of Given Mood And Create Object Using Reflaction Pass Parametrized Constructor
        /// </summary>
        [Test]
        public void givenMood_whenAnalysisMood_CreateObjectusingReflactionPassParametrizedConstructor()
        {
            object reflactObj = MoodAnalyserReflaction.CreateObjectUsingReflection("MoodAnalysers.moodAnalyser","I am in Happy Mood");
            moodAnalyser moodObj = new moodAnalyser();
            bool actual = moodObj.Equals(reflactObj);
            Assert.AreEqual(false, actual);
        }

        /// <summary>
        /// Create Object Using Reflaction Not Pass Parametrized Constructor
        /// </summary>
        [Test]
        public void givenMood_whenAnalysisMood_CreateObjectusingReflactionNotPassProperParametrizedConstructor()
        {
            object reflactObj = MoodAnalyserReflaction.CreateObjectUsingReflection("MoodAnalysers.moodAnalyser",123);
            Assert.AreEqual(MoodAnalyserException.ExceptionType.No_Class_Method, reflactObj);
        }

        [Test]
        public void givenMood_whenAnalysisMood_SetFieldValueShouldReturnHappy()
        {
            string result = MoodAnalyserReflaction.InvokeMethodUsingReflection("AnalyserMood", "I am in Any Mood");
            Assert.AreEqual("Happy", result);
        }


        [Test]
        public void GivenMoodMessageToInvokeUsingReflectionMethod_WhenNotProper_ShouldThrowException()
        {
            try
            {
                string result = MoodAnalyserReflaction.InvokeMethodUsingReflection("007AnalyseMood", "I am in Any Mood");
            }
            catch (MoodAnalyserException e)
            {
                Assert.AreEqual(MoodAnalyserException.ExceptionType.No_Class_Method, e.type);
            }
        }

    }
}