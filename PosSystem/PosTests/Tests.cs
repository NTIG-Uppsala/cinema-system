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
        public void AddProduct()
        {
            Program.AddToCheckout(new ProductClass("Läsk", 69m));
            Assert.IsTrue(Program.CheckoutList.Count > 0);
        }

        [Test]
        public void ClearProduct()
        {
            Program.AddToCheckout(new ProductClass("Läsk", 69m));
            Assert.IsTrue(Program.CheckoutList.Count > 0);
        }
    }
}