using InterviewPractice;
using Xunit;

namespace TestInterviewPractice
{
    public class Test_07_AllAnagrams
    {
        [Fact]
        public void Test0()
        {
            string[] rr1 = { "abcd", "bdac", "cabd" };
            

            var act = _07_AllAnagrams.AllAnagrams(rr1);
            Assert.True(act);
        }

        [Fact]
        public void Test1()
        {
            string[] rr1 = { "abcd", "bdXc", "cabd" };


            var act = _07_AllAnagrams.AllAnagrams(rr1);
            Assert.False(act);
        }
    }
}
