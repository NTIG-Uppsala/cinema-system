using PosSystem;

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
            Program.AddToCheckout(new ProductClass("Popcorn", 69m));
            Assert.IsTrue(Program.CheckoutList.Count > 0);
        }
    }
}