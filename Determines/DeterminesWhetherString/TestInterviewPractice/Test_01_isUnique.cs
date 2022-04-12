using InterviewPractice;
using Xunit;

namespace TestInterviewPractice
{
    public class Test_01_isUnique
    {
        [Fact]
        public void Test1()
        {
            var act = _01_isUnique.IsUnique("abcdef");
            Assert.True(act);
        }

        [Fact]
        public void Test2()
        {
            var act = _01_isUnique.IsUnique("aaaabcdef");
            Assert.False(act);
        }
    }
}


