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
            _mainWindow.PopcornButton.PerformClick();
            Assert.IsTrue(Program.CheckoutList.Count > 0);
        }

        [Test]
        public void ClearProduct()
        {
            _mainWindow.PopcornButton.PerformClick();
            _mainWindow.Clear.PerformClick();
            Assert.IsTrue(Program.CheckoutList.Count == 0);
            Assert.IsTrue(_mainWindow.TotalText.Text == "0kr");
        }

        [Test]
        public void ReadTotal()
        {
            _mainWindow.PopcornButton.PerformClick();
            _mainWindow.SodaButton.PerformClick();
            Assert.IsTrue(_mainWindow.TotalText.Text == "40kr");
        }
    }
}