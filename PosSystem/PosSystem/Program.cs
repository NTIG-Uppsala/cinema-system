using System.Diagnostics;
using System.Reflection;

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

        public static void WriteReceipt()
        {
            string[] Receipt =
            {
                "Bengans Biograf",
                "Fjällgatan 32H",
                "981 39 Jönköping",
                Environment.NewLine,
                "Tel: (+46)63-055 55 55",
                "Mail: info.bengans@gmail.com",
                "Org. Nr: 234567-8901",
                Environment.NewLine,
                $"Säljare: {SELLER_NAME}",
                $"{YYYY-MM-DD} {HH:MM}",
                $"Lokal Nr: {LOCALE_ID}",
                $"Kvitto Nr: {RECEIPT_ID}",
                Environment.NewLine,
                "-----------------------------------------------------",
                Environment.NewLine
            };

            foreach (KeyValuePair<ProductClass, int> product in Checkout)
            {
                Receipt.Append($"{product.Key.Name}");
                Receipt.Append($"\t\t\t{product.Value} st á\t{(product.Key.Price).ToString("0.00")} SEK");
                Receipt.Append($"\t\t\t\t\t{(product.Value * product.Key.Price).ToString("0.00")} SEK");
                Receipt.Append(Environment.NewLine);
            }

            string[] ReceitPart2 =
            {
                "-----------------------------------------------------",
                Environment.NewLine,
                "Momsunderlag:",
                $"Moms 25%\t{MOMS_25} SEK",
                $"Moms 12%\t{MOMS_12} SEK",
                $"Moms 6%\t\t{MOMS_6} SEK",
                $"Momsfritt\t{MOMS_0} SEK",
                Environment.NewLine,
                $"Nettopris:\t{NOT_MOMS} SEK",
                $"Total moms:\t{TOTAL_MOMS} SEK",
                Environment.NewLine,
                $"SUMMA:\t\t{TOTAL_PRICE} SEK",
                Environment.NewLine,
                "---------------------------------------------------- -",
                Environment.NewLine,
                "Kortbetalningsinformation finns på annat kvitto.",
                Environment.NewLine,
                "Öppet köp gäller endast biljett, fram till 24 timmar",
                "innan visning",
            };
        }
    }
}