using DeterminesWhetherString;
using Xunit;

namespace TestDetermines
{
    public class DetermineTest
    {
        [Fact]
        public void TestSolutionEQUAL()
        {
            var exp = "EQUAL";
            var act = Solution.solution("nice", "nice");

            Assert.Equal(exp, act);
        }          
        [Fact]
        public void TestSolution0()
        {
            var exp = "INSERT e";
            var act = Solution.solution("nice", "niece");

            Assert.Equal(exp, act);
        }        
        [Fact]
        public void TestSolution1()
        {
            var exp = "REPLACE s n";
            var act = Solution.solution("test", "tent");

            Assert.Equal(exp, act);
        }        
        [Fact]
        public void TestSolution2()
        {
            var exp = "SWAP o r";
            var act = Solution.solution("form", "from");

            Assert.Equal(exp, act);
        }        
        [Fact]
        public void TestSolution3()
        {
            var exp = "IMPOSSIBLE";
            var act = Solution.solution("o", "odd");

            Assert.Equal(exp, act);
        }
    }
}
//given S = "nice" and T = "niece", the function should return "INSERT e";

//given S = "test" and T = 'tent', the function  should return "REPLACE s n";

//given S = "form" and T = 'from', the function should return "SWAP o r";

//given S = "o" and T = "odd", the function should return "IMPOSSIBLE".