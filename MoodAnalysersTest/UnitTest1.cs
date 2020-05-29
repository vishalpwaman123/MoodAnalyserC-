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

        [Test]
        public void givenMood_whenHappy_shouldReturnHappy()
        {
            moodAnalyser MoodA = new moodAnalyser("Happy");
            string result = MoodA.varificatioTest();
            Assert.AreEqual("Happy", result);
        }

    }
}