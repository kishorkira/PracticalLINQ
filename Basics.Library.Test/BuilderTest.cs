using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Basics.Library.Test
{
    [TestClass]
    public class BuilderTest
    {
        public TestContext TestContext { get; set; }
        [TestMethod]
       public void GenerateSequence()
        {
            //Arrange
            var builder = new Builder();

            //Act
            var ints = builder.GenerateSequence();

            //Analyze
            foreach (var i in ints)
            {
                TestContext.WriteLine(i.ToString());
            }
            //Assert
            Assert.IsNotNull(ints);
        }
    }
}
