namespace PosTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var CheckoutList = new List<string>();
            CheckoutList.Add("Läsk");
            Assert.IsTrue(CheckoutList.Count > 0);
        }
    }
}