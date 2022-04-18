using InterviewPractice;
using Xunit;

namespace TestInterviewPractice
{
    public class Test_09_Search
    {
        [Fact]
        public void Test0()
        {

            int[] rr1 = { 1, 3, 6, 14, 17 };
            int exp = 1;
            var act = _09_Search.SearchId(rr1, 3);
            Assert.Equal(exp, act);
        }

        [Fact]
        public void Test1()
        {

            int[] rr1 = { 1, 3, 6, 14, 17 };
            int exp = 3;
            var act = _09_Search.SearchId(rr1, 14);
            Assert.Equal(exp, act);
        }

        [Fact]
        public void Test2()
        {

            int[] rr1 = { 1, 3, 6, 13, 17 };
            int exp = -1;
            var act = _09_Search.SearchId(rr1, 12);
            Assert.Equal(exp, act);

        }
    }
}
