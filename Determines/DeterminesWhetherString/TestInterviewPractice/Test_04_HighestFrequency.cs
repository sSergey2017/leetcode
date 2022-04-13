using InterviewPractice;
using Xunit;

namespace TestInterviewPractice
{
    public class Test_04_HighestFrequency
    {
        [Fact]
        public void Test1()
        {
            string[] str = { "a", "b", "c", "c", "d", "e" };
            string exp = "c";

            var act = _04_HighestFrequency.HighestFrequency(str);
            Assert.Equal(exp, act);
        }

        [Fact]
        public void Test2()
        {
            string[] str = { "abc", "def", "abc", "def", "abc" };
            string exp = "abc";

            var act = _04_HighestFrequency.HighestFrequency(str);
            Assert.Equal(exp, act);
        }

        [Fact]
        public void Test3()
        {
            string[] str = { "abc", "def" };
            string exp = "abc";

            var act = _04_HighestFrequency.HighestFrequency(str);
            Assert.Equal(exp, act);
        }

        [Fact]
        public void Test4()
        {
            string[] str = { "abc", "abc", "def", "def", "def", "ghi", "ghi", "ghi", "ghi" };
            string exp = "ghi";

            var act = _04_HighestFrequency.HighestFrequency(str);
            Assert.Equal(exp, act);
        }
    }
}

//console.log(highestFrequency(["a", "b", "c", "c", "d", "e"])) // -> c
//console.log(highestFrequency(["abc", "def", "abc", "def", "abc"])) // -> abc
//console.log(highestFrequency(["abc", "def"])) // -> abc
//console.log(highestFrequency(["abc", "abc", "def", "def",// "def", "ghi", "ghi", "ghi", "ghi"])) // -> ghi