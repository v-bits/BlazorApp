namespace BlazorApp.Server.Test
{
    [TestClass]
    public class ServerUnitTest
    {
        [TestMethod]
        public void TestMethodPass()
        {
            var expected = 1;
            var actual = 1;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestMethodFail()
        {
            var expected = 1;
            var actual = 0;

            Assert.AreEqual(expected, actual);
        }
    }
}