using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Mood_Analyzer_Program
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void MsgSadMood()
        {
            string msg = "I am in sad mood";
            string expected = "SAD";

            MoodAnalyzer mood = new MoodAnalyzer();

            string actual = mood.AnalyseMood(msg);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void MsgHaapyMood()
        {
            string msg = "I am in Any mood";
            string expected = "HAPPY";

            MoodAnalyzer mood = new MoodAnalyzer();

            string actual = mood.AnalyseMood(msg);

            Assert.AreEqual(expected, actual);
        }
    }
}
