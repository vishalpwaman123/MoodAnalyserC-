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


        [Test]
        public void givenMood_whenPassNullParameter_shouldReturnHappy()
        {
            moodAnalyser MoodA = new moodAnalyser(null);
            string result = MoodA.varificatioTest();
            Assert.AreEqual("Happy", result);

        }

    }
}