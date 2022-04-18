using InterviewPractice;
using Xunit;

namespace TestInterviewPractice
{
    public class Test_10_IsBalanced
    {
        _10_IsBalanced brace = new _10_IsBalanced();

        [Fact]
        public void Test0()
        {
            var act = brace.isBalsnced("()");
            Assert.True(act);
        }
        [Fact]
        public void Test01()
        {
            var act = brace.isBalsnced("()))");
            Assert.False(act);
        }

        [Fact]
        public void Test1()
        {
            var act = brace.isBalsnced("()[][{}]");
            Assert.True(act);
        }

        [Fact]
        public void Test2()
        {
            var act = brace.isBalsnced("{]");
            Assert.False(act);
        }

        [Fact]
        public void Test3()
        {
            var act = brace.isBalsnced("}{[]{}");
            Assert.False(act);
        }

        [Fact]
        public void Test4()
        {
            var act = brace.isBalsnced("({lkjglkhjgjjj  m,,,})");
            Assert.True(act);
        }

        [Fact]
        public void Test5()
        {
            var act = brace.isBalsnced("()}");
            Assert.False(act);
        }

        [Fact]
        public void Test6()
        {
            var act = brace.isBalsnced("({)}");
            Assert.False(act);
        }
    }
}
