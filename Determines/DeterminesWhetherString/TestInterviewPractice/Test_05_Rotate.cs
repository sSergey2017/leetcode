using InterviewPractice;
using Xunit;

namespace TestInterviewPractice
{
    public class Test_05_Rotate
    {
        [Fact]
        public void Test0()
        {
            var act = _05_Rotate.Rotate("javascript", "scriptjava");
            Assert.True(act);
        }

        [Fact]
        public void Test1()
        {
            var act = _05_Rotate.Rotate("javascript", "iptjavascr");
            Assert.True(act);
        }

        [Fact]
        public void Test2()
        {
            var act = _05_Rotate.Rotate("javascript", "java");
            Assert.False(act);
        }
    }
}