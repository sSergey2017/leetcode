using CopyThree;
using Newtonsoft.Json;
using Xunit;
using Xunit.Abstractions;

namespace CopyTreeTests
{
    public class RecursiveMapperTests
    {
        private readonly ITestOutputHelper _testOutputHelper;

        TreeA treeNodeA = new TreeA
        {
            Paiload = "rootData",
            LeftBranch = new TreeA
            {
                Paiload = "Data1",
                LeftBranch = new TreeA
                {
                    Paiload = "Data2",
                    RightBranch = new TreeA { Paiload = "Data3" }
                },
                RightBranch = new TreeA
                {
                    Paiload = "Data4",
                    RightBranch = new TreeA { Paiload = "Data5" }
                }
            },
            RightBranch = new TreeA
            {
                Paiload = "Data6",
                LeftBranch = new TreeA
                {
                    Paiload = "Data7",
                    RightBranch = new TreeA { Paiload = "Data8" }
                },
                RightBranch = new TreeA
                {
                    Paiload = "Data9",
                    RightBranch = new TreeA { Paiload = "Data10" }
                }
            }

        };

        public RecursiveMapperTests(ITestOutputHelper testOutputHelper)
        {
            _testOutputHelper = testOutputHelper;
        }

        [Fact]
        public void Test1()
        {
            //var treeNodeA = new TreeA
            //{
            //    Paiload ="rootData",
            //    LeftBranch = new TreeA {
            //        Paiload = "Data1",
            //        LeftBranch = new TreeA {
            //            Paiload ="Data2",
            //            RightBranch = new TreeA { Paiload = "Data3" }},
            //        RightBranch = new TreeA
            //        {
            //            Paiload = "Data4",
            //            RightBranch = new TreeA { Paiload = "Data5" }}},
            //    RightBranch = new TreeA {
            //        Paiload="Data6",
            //        LeftBranch=new TreeA {
            //            Paiload = "Data7",
            //            RightBranch = new TreeA { Paiload = "Data8" }},
            //        RightBranch = new TreeA
            //        {
            //            Paiload = "Data9",
            //            RightBranch = new TreeA { Paiload = "Data10" }}}

            //};
            var treeNodeB = CopyThree.AutoMapper.Map(treeNodeA);
            var treeA = JsonConvert.SerializeObject(treeNodeA, Formatting.Indented);
            var treeB = JsonConvert.SerializeObject(treeNodeB, Formatting.Indented);

            _testOutputHelper.WriteLine(treeA);
            _testOutputHelper.WriteLine(treeB);

            Assert.Equal(treeA, treeB);

        }

        [Fact]
        public void Test2()
        {
            
            var treeNodeB = CopyThree.RecursiveMapper.Map(treeNodeA);
            var treeA = JsonConvert.SerializeObject(treeNodeA, Formatting.Indented);
            var treeB = JsonConvert.SerializeObject(treeNodeB, Formatting.Indented);

            _testOutputHelper.WriteLine(treeA);
            _testOutputHelper.WriteLine(treeB);

            Assert.Equal(treeA, treeB);
        }

        [Fact]
        public void Test3()
        {

            var treeNodeB = CopyThree.QueueMapper.Map(treeNodeA);
            var treeA = JsonConvert.SerializeObject(treeNodeA, Formatting.Indented);
            var treeB = JsonConvert.SerializeObject(treeNodeB, Formatting.Indented);

            _testOutputHelper.WriteLine(treeA);
            _testOutputHelper.WriteLine(treeB);

            Assert.Equal(treeA, treeB);
        }
    }
}
