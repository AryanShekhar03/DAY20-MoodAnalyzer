using Microsoft.VisualStudio.TestTools.UnitTesting;
using Mood_Analyzer_Program;
namespace Mood_Analyzer_Test

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void NullMood()
        {
            string msg = " ";
            string expected = "HAPPY";

            MoodAnalyzer mood = new MoodAnalyzer(msg);

            string actual = mood.AnalyseMood();

            Assert.AreEqual(expected, actual);
        }
        // [TestMethod]
        //public void MsgHaapyMood()
        //{
        //    string msg = "I am in Any mood";
        //    string expected = "HAPPY";

        //    MoodAnalyzer mood = new MoodAnalyzer();

        //    string actual = mood.AnalyseMood(msg);

        //    Assert.AreEqual(expected, actual);
        //}
    }
}