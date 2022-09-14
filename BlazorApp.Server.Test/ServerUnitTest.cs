namespace BlazorApp.Server.Test
{
    [TestClass]
    public class ServerUnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            var expected = 1;
            var actual = 0;

            Assert.AreNotEqual(expected, actual);
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