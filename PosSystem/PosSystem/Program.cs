using System.Diagnostics;

namespace PosSystem
{
    public static class Program
    {
        public static Dictionary<ProductClass, int> Checkout = new();
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
            Checkout.TryGetValue(product, out int currentCount);
            Checkout[product] = currentCount + 1;
        }

        public static void ClearCheckout()
        {
            Checkout.Clear();
        }
    }
}