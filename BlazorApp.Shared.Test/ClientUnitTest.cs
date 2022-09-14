namespace BlazorApp.Shared.Test
{
    [TestClass]
    public class ClientUnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var expected = 1;
            var actual = 0;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodPass()
        {
            var expected = 1;
            var actual = 1;

            Assert.AreEqual(expected, actual);
        }

    }
}