using PosSystem;
using System.Diagnostics;

namespace PosTests
{

    [TestFixture]
    public class Tests
    {
        private string ReceiptFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\PosReceipts";
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
            (_mainWindow.SnackLayout.Controls[0] as ProductButton).PerformClick();
            Assert.IsTrue(Program.Checkout.Count > 0);
        }

        [Test]
        public void ClearProduct()
        {
            (_mainWindow.SnackLayout.Controls[0] as ProductButton).PerformClick();
            _mainWindow.Clear.PerformClick();
            Assert.IsTrue(Program.Checkout.Count == 0);
            Assert.IsTrue(_mainWindow.TotalText.Text == "Totalt: 0kr");
        }

        [Test]
        public void ReadTotal()
        {
            (_mainWindow.SnackLayout.Controls[0] as ProductButton).PerformClick();
            Assert.IsTrue(_mainWindow.TotalText.Text == "Totalt: 25kr");
        }

        [Test]
        public void ReadOutputFile()
        {
            (_mainWindow.SnackLayout.Controls[0] as ProductButton).PerformClick();
            _mainWindow.Pay.PerformClick();
            Assert.IsTrue(File.Exists($@"{ReceiptFolder}\output1.txt"));
            StringAssert.Contains("Popcorn Liten", File.ReadAllText($@"{ReceiptFolder}\output1.txt"));
        }

        [Test]
        public void ReadTicket()
        {
            _mainWindow.TabControl.SelectedTab = _mainWindow.MoviePage;
            (_mainWindow.MovieLayout.Controls[0] as ProductButton).PerformClick();
            _mainWindow.Pay.PerformClick();
            Assert.IsTrue(File.Exists($@"{ReceiptFolder}\output2.txt"));
            StringAssert.Contains("Shrek 1", File.ReadAllText($@"{ReceiptFolder}\output2.txt"));
            StringAssert.Contains("Plats: ", File.ReadAllText($@"{ReceiptFolder}\output2.txt"));
        }
    }
}