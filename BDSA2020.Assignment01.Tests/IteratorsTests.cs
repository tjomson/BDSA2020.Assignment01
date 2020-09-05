using Xunit;

namespace BDSA2020.Assignment01.Tests
{
    public class IteratorsTests
    {
        [Theory]
        [InlineData(true)]
        public void AssertTrue(bool shouldPass)
        {
            Assert.True(shouldPass);
        }

    }
}
