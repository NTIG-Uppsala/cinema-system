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
            Assert.IsTrue(_mainWindow.TotalText.Text == "Totalt: 45kr");
        }

        [Test]
        public void ReadOutputFile()
        {
            string ReceiptFolder = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PosReceipts";
            
            _mainWindow.PopcornButtonSmall.PerformClick();
            _mainWindow.SodaButtonSmall.PerformClick();
            _mainWindow.Pay.PerformClick();
            Assert.IsTrue(File.Exists($"{ReceiptFolder}\\output1.txt"));
            StringAssert.Contains("Popcorn Liten", File.ReadAllText($"{ReceiptFolder}\\output1.txt"));
            StringAssert.Contains("Läsk Liten", File.ReadAllText($"{ReceiptFolder}\\output1.txt"));
        }
    }
}