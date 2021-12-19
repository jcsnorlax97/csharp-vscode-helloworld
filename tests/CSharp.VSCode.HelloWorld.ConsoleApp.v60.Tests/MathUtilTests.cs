using Xunit;
using CSharp.VSCode.HelloWorld.ConsoleApp.v60;

namespace CSharp.VSCode.HelloWorld.ConsoleApp.v60.Tests
{
    public class MathUtilTests
    {
        [Fact]
        public void Test1()
        {
            // --- ARRANGE ---
            int num1 = 1;
            int num2 = 2;
            int expectedResult = 1 + 2;

            // --- ACT ---
            int result = MathUtil.Sum(num1, num2);

            // --- ASSERT ---
            Assert.True(expectedResult == result);
        }
    }
}