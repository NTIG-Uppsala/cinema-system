using System;
using System.Diagnostics;
using System.Globalization;
using System.Reflection;

namespace PosSystem
{
    public static class Program
    {
        public static Dictionary<ProductClass, int> Checkout = new();
        public static int ReceiptId = 1;
        public static int SeatPosition = 1;

        public static readonly ProductClass SmallPopcorn = new("Popcorn Liten", 25m);
        public static readonly ProductClass SmallSoda = new("Läsk Liten", 20m);
        public static readonly ProductClass MediumPopcorn = new("Popcorn Mellan", 35m);
        public static readonly ProductClass MediumSoda = new("Läsk Mellan", 25m);
        public static readonly ProductClass LargePopcorn = new("Popcorn Stor", 50m);
        public static readonly ProductClass LargeSoda = new("Läsk Stor", 35m);

        public static readonly TicketProduct Shrek1 = new("Biljett - Shrek 1", 170m, 25);
        public static readonly TicketProduct Shrek2 = new("Biljett - Shrek 2", 170m, 25);
        public static readonly TicketProduct Shrek3 = new("Biljett - Shrek 3", 170m, 25);

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
            string receiptFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosReceipts";
            Directory.CreateDirectory(receiptFolder);
            var currentDateTime = DateTime.Now;

            string sellerName = "Bengt Svensson";
            string localeIdentifier = "14";

            decimal vat25 = 0m;
            decimal vat12 = 0m;
            decimal vat6 = 0m;
            decimal vat0 = 0m;
            
            foreach (KeyValuePair<ProductClass, int> product in Checkout)
            {
                switch (product.Key.Vat)
                {
                    case 25:
                        vat25 += product.Key.Price * product.Value / 1.25m;
                        break;
                    case 12:
                        vat12 += product.Key.Price * product.Value / 1.12m;
                        break;
                    case 6:
                        vat6 += product.Key.Price * product.Value / 1.06m;
                        break;
                    default:
                        vat0 += product.Key.Price * product.Value;
                        break;
                }
            }

            decimal netPrice = vat25 + vat12 + vat6 + vat0;
            decimal totalVat = (vat25 * 0.25m) + (vat12 * 0.12m) + (vat6 * 0.06m);
            decimal totalSum = netPrice + totalVat;

                List<string> receipt = new List<string>()
            {
                "Bengans Biograf",
                "Fjällgatan 32H",
                "981 39 Jönköping\n",
                "Tel: (+46)63-055 55 55",
                "Mail: info.bengans@gmail.com",
                "Org. Nr: 234567-8901\n",
                $"Säljare: {sellerName}",
                $"{currentDateTime.ToString("s").Replace("T", " ")}",
                $"Lokal Nr: {localeIdentifier}",
                $"Kvitto Nr: {ReceiptId}",
                "-----------------------------------------------------\n",
            };

            foreach (KeyValuePair<ProductClass, int> product in Checkout)
            {
                receipt.Add($"{product.Key.Name}");
                receipt.Add($"\t\t\t{product.Value} st á\t{(product.Key.Price).ToString("0.00")} SEK");
                receipt.Add($"\t\t\t\t\t{(product.Value * product.Key.Price).ToString("0.00")} SEK\n");
            }

            List<string> receitPart2 = new List<string>()
            {
                "-----------------------------------------------------\n",
                "Momsunderlag:",
                $"Moms 25%\t{vat25.ToString("0.00")} SEK",
                $"Moms 12%\t{vat12.ToString("0.00")} SEK",
                $"Moms 6%\t\t{vat6.ToString("0.00")} SEK",
                $"Momsfritt\t{vat0.ToString("0.00")} SEK\n",
                $"Nettopris:\t{netPrice.ToString("0.00")} SEK",
                $"Total moms:\t{totalVat.ToString("0.00")} SEK\n",
                $"SUMMA:\t\t{totalSum.ToString("0.00")} SEK\n",
                "-----------------------------------------------------\n",
                "Kortbetalningsinformation finns på annat kvitto.\n",
                "Öppet köp gäller endast biljett, fram till 24 timmar",
                "innan visning",
            };
            receipt.AddRange(receitPart2);

            foreach (KeyValuePair<ProductClass, int> product in Checkout)
            {
                if(product.Key is TicketProduct)
                {
                    for (int i = 0; i < product.Value; i++)
                    {
                        receipt.Add("\n-----------------------------------------------------\n");
                        receipt.Add($"{product.Key.Name.Replace("Biljett - ", "")}");
                        receipt.Add($"Datum: {currentDateTime.AddHours(1).ToString("yyyy-MM-dd HH:00")}");
                        receipt.Add($"Plats: {SeatPosition}");
                        SeatPosition++;
                    }
                }
            }

            File.WriteAllLines($@"{receiptFolder}\output{ReceiptId}.txt", receipt);
            ReceiptId++;
        }
    }
}