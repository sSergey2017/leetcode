using InterviewPractice;
using Xunit;

namespace TestInterviewPractice
{
    public class Test_08_Rotate
    {
        [Fact]
        public void Test2()
        {
            
            int[,] rr = new int[,] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            int[,] exp = new int[,] { { 7, 4, 1 }, { 8, 5, 2 }, { 9, 6, 3 } };
            var act = _08_Rotate.Rotate(rr);
            Assert.Equal(exp, act);

        }
    }
}
