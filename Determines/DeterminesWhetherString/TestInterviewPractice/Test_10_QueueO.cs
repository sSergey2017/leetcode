using Xunit;
using InterviewPractice;


namespace TestInterviewPractice
{
    public class Test_10_QueueO
    {
        [Fact]
        public void Test1()
        {
            _10_QueueO q = new _10_QueueO();
            q.Enqueue("1");
            q.Enqueue("2");
            q.Enqueue("3");
            q.Enqueue("4");
            var exp = 4;
            var act = q.Count;
            Assert.Equal(exp, act);
        }

        [Fact]
        public void Test2()
        {
            _10_QueueO q = new _10_QueueO();
            q.Enqueue("1");
            q.Enqueue("2");
            q.Enqueue("3");
            q.Enqueue("4");
            var exp = "1";
            Assert.Equal(4, q.Size());
            var act = q.Dequeue();
            Assert.Equal(exp, act);
            Assert.Equal(3, q.Size());
        }
    }
}
