using PosSystem;

namespace PosTests
{
    public class Tests
    {
        private MainWindow _mainWindow;

        [SetUp]
        public void Setup()
        {
            _mainWindow = new MainWindow();
            _mainWindow.Show();
        }

        [Test]
        public void AddProduct()
        {
            _mainWindow.PopcornButtonSmall.PerformClick();
            Assert.IsTrue(Program.Checkout.Count > 0);
        }

        [Test]
        public void ClearProduct()
        {
            _mainWindow.PopcornButtonSmall.PerformClick();
            _mainWindow.Clear.PerformClick();
            Assert.IsTrue(Program.Checkout.Count == 0);
            Assert.IsTrue(_mainWindow.TotalText.Text == "Totalt: 0kr");
        }

        [Test]
        public void ReadTotal()
        {
            _mainWindow.PopcornButtonSmall.PerformClick();
            _mainWindow.SodaButtonSmall.PerformClick();
            Assert.IsTrue(_mainWindow.TotalText.Text == "Totalt: 40kr");
        }
    }
}