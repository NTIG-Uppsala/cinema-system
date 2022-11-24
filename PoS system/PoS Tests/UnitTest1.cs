namespace PoS_Tests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Button()
        {
            var popcorn = new Class1.Class1();
            popcorn.performClick();

            string actual = "Popcorn-Medium";
            string expected = "Popcorn-Medium";
            Assert.That(actual, Is.EqualTo(expected));
        }
    }
}