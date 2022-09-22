namespace CourseApp.Tests
{
    using Xunit;

    public class TownTest
    {
        [Fact]
        public void TestYz()
        {
            var yz = new Town("Yuzga", 6780, 9876);
            Assert.Equal("Yuzga", yz.Name);
            Assert.Equal(6780, yz.Population);
            Assert.Equal(9876, yz.DateOfBuilding);
        }

        [Fact]
        public void TestIv()
        {
            var iv = new Town("Ivanovo", 5678, 567);
            Assert.Equal("Ivanovo", iv.Name);
            Assert.Equal(5678, iv.Population);
            Assert.Equal(567, iv.DateOfBuilding);
        }
    }
}
