
using exam.Classes;

namespace TestProject
{
    public class UnitTest1
    {
        [Fact]
        public void TestOne()
        {
            int[] ints = { 1, 2, 3 };
            int[] intsresult = { 2, 4, 6 };
            var result = Method.MnojChisel(ints);
            Assert.Equal(intsresult, ints);
        }
    }
}