using InterviewPractice;
using Xunit;

namespace TestInterviewPractice
{
    public class Test_03_Dupes
    {
        [Fact]
        public void Test1()
        {
            string exp = "abcd";
            string str = "abcd";
           
            var act = _03_Dupes.RemoveDupes(str);
            Assert.Equal(exp, act);

        }

        [Fact]
        public void Test2()
        {
            string exp = "abcdf";
            string str = "abcdabcdfffff";

            var act = _03_Dupes.RemoveDupes2(str);
            Assert.Equal(exp, act);

        }
    }
}
