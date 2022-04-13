using InterviewPractice;
using Xunit;

namespace TestInterviewPractice
{
    public class Test_06_ArraySubset
    {
        [Fact]
        public void Test0()
        {
            int[] rr1 = { 2, 1, 3 };
            int[] rr2 = { 1, 2, 3 };
            
            var act = _06_ArraySubset.ArraySubset(rr1, rr2);
            Assert.True(act);
        }

        [Fact]
        public void Test1()
        {
            int[] rr1 = { 2, 1, 1, 3 };
            int[] rr2 = { 1, 2, 3 };

            var act = _06_ArraySubset.ArraySubset(rr1, rr2);
            Assert.True(act);
        }
        [Fact]
        public void Test2()
        {
            int[] rr1 = { 1, 1, 1, 3 };
            int[] rr2 = { 1, 3, 3 };

            var act = _06_ArraySubset.ArraySubset(rr1, rr2);
            Assert.False(act);
        }
        [Fact]
        public void Test3()
        {
            int[] rr1 = { 1, 2 };
            int[] rr2 = { 1, 2, 3 };

            var act = _06_ArraySubset.ArraySubset(rr1, rr2);
            Assert.False(act);
        }
    }
}
