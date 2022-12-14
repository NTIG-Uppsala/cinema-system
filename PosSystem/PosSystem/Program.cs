using System;
using System.Diagnostics;
using System.Reflection;

namespace PosSystem
{
    public static class Program
    {
        public static Dictionary<ProductClass, int> Checkout = new();
        public static int ReceiptId = 1;

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
            string ReceiptFolder = $"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\\PosReceipts";
            Directory.CreateDirectory(ReceiptFolder);

            string SellerName = "Bengt Svensson";
            string LocaleIdentifier = "14";
            
            List<string> Receipt = new List<string>()
            {
                "Bengans Biograf",
                "Fjällgatan 32H",
                "981 39 Jönköping\n",
                "Tel: (+46)63-055 55 55",
                "Mail: info.bengans@gmail.com",
                "Org. Nr: 234567-8901\n",
                $"Säljare: {SellerName}",
                $"{DateTime.Now.ToString("s").Replace("T", " ")}",
                $"Lokal Nr: {LocaleIdentifier}",
                $"Kvitto Nr: {ReceiptId}",
                "-----------------------------------------------------\n",
            };

            foreach (KeyValuePair<ProductClass, int> product in Checkout)
            {
                Receipt.Add($"{product.Key.Name}");
                Receipt.Add($"\t\t\t{product.Value} st á\t{(product.Key.Price).ToString("0.00")} SEK");
                Receipt.Add($"\t\t\t\t\t{(product.Value * product.Key.Price).ToString("0.00")} SEK\n");
                Debug.WriteLine(Receipt.Count);
            }

            List<string> ReceitPart2 = new List<string>()
            {
                "-----------------------------------------------------\n",
                "Momsunderlag:",
                "Moms 25%\t{MOMS_25} SEK",
                "Moms 12%\t{MOMS_12} SEK",
                "Moms 6%\t\t{MOMS_6} SEK",
                "Momsfritt\t{MOMS_0} SEK\n",
                "Nettopris:\t{NOT_MOMS} SEK",
                "Total moms:\t{TOTAL_MOMS} SEK\n",
                "SUMMA:\t\t{TOTAL_PRICE} SEK\n",
                "-----------------------------------------------------\n",
                "Kortbetalningsinformation finns på annat kvitto.\n",
                "Öppet köp gäller endast biljett, fram till 24 timmar",
                "innan visning",
            };

            Receipt.AddRange(ReceitPart2);

            File.WriteAllLinesAsync($"{ReceiptFolder}\\output{ReceiptId}.txt", Receipt);
            ReceiptId++;
        }
    }
}