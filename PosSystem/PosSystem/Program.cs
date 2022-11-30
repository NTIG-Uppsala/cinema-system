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
            Application.Run(new Form1());

            ProductClass test = new ("Läsk", 10m);
            CheckoutList.Add((test, 1));
            Debug.WriteLine($"{CheckoutList[0].amount}");
        }

        public static void AddToCheckout(ProductClass product)
        {
            foreach ((ProductClass, int) item in CheckoutList)
            {
                Debug.WriteLine($"{item.Item1.Name}, {item.Item2}");
            }
        }

    }
}