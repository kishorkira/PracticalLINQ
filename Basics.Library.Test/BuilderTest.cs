using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basics.Library.Test
{
    [TestClass]
    public class BuilderTest
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
        public void GenerateIntSequence()
        {
            //Arrange
            var builder = new Builder();

            //Act
            var ints = builder.GenerateIntSequence();

            //Analyze
            foreach (var i in ints)
            {
                TestContext.WriteLine(i.ToString());
            }
            //Assert
            Assert.IsNotNull(ints);
        }
        [TestMethod]
        public void GenerateStringSequence()
        {
            //Arrange
            var builder = new Builder();

            //Act
            var result = builder.GenerateStringSequence();

            //Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item);
            }
            //Assert
            Assert.IsNotNull(result);
        }
    }
}
