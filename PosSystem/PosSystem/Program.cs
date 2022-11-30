using System.Diagnostics;

namespace PosSystem
{
    public static class Program
    {
        public static List<(ProductClass product, int amount)> CheckoutList = new();
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new MainWindow());
        }

        public static void AddToCheckout(ProductClass product)
        {
            CheckoutList.Add((product, 1));
        }

        public static void ClearCheckout()
        {
            CheckoutList.Clear();
        }
    }
}