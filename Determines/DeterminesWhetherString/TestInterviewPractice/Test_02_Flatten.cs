using InterviewPractice;
using Xunit;

namespace TestInterviewPractice
{
    public class Test_02_Flatten
    {
        [Fact]
        public void Test1()
        {
            int[] exp = { 0, 1, 2, 3, 4, 5 };
            int[,] rr = new int[,] { { 0, 1, 2 }, { 3, 4, 5 } };
            var act = _02_Flatten.Flatten(rr);
            Assert.Equal(exp, act);

        }

        [Fact]
        public void Test2()
        {
            int[] exp = { 0, 1, 2, 3, 4, 5, 3, 1, 1, 3, 4, 5 };
            int[,] rr = new int[,] { { 0, 1, 2 }, { 3, 4, 5 }, { 3, 1, 1 }, { 3, 4, 5 } };
            var act = _02_Flatten.Flatten(rr);
            Assert.Equal(exp, act);

        }

        [Fact]
        public void Test3()
        {
            int[][] numbers = {
            new int[] { 1, 2 },
            new int[] { 1, 2, 3 },
        new int[] { 1, 2, 3, 4, 5 }
};
            int[] exp = { 1, 2, 1, 2, 3, 1, 2, 3, 4, 5 };
            var act = _02_Flatten.Flatten1(numbers);
            Assert.Equal(exp, act);

        }
    }
}
