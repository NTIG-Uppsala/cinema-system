using System;
using System.Diagnostics;
using System.Reflection;

namespace PosSystem
{
    public static class Program
    {
        public static Dictionary<ProductClass, int> Checkout = new();
        public static int ReceiptId = 1;
        public static int seatPosition = 1;

        public static readonly ProductClass _smallPopcorn = new("Popcorn Liten", 25m);
        public static readonly ProductClass _smallSoda = new("Läsk Liten", 20m);
        public static readonly ProductClass _mediumPopcorn = new("Popcorn Mellan", 35m);
        public static readonly ProductClass _mediumSoda = new("Läsk Mellan", 25m);
        public static readonly ProductClass _largePopcorn = new("Popcorn Stor", 50m);
        public static readonly ProductClass _largeSoda = new("Läsk Stor", 35m);

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
            string ReceiptFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosReceipts";
            Directory.CreateDirectory(ReceiptFolder);
            var currentDateTime = DateTime.Now;

            string SellerName = "Bengt Svensson";
            string LocaleIdentifier = "14";

            decimal Vat25 = 0m;
            decimal Vat12 = 0m;
            decimal Vat6 = 0m;
            decimal Vat0 = 0m;
            
            foreach (KeyValuePair<ProductClass, int> product in Checkout)
            {
                switch (product.Key.Vat)
                {
                    case 25:
                        Vat25 += product.Key.Price * product.Value / 1.25m;
                        break;
                    case 12:
                        Vat12 += product.Key.Price * product.Value / 1.12m;
                        break;
                    case 6:
                        Vat6 += product.Key.Price * product.Value / 1.06m;
                        break;
                    default:
                        Vat0 += product.Key.Price * product.Value;
                        break;
                }
            }

            decimal NetPrice = Vat25 + Vat12 + Vat6 + Vat0;
            decimal TotalVat = (Vat25 * 0.25m) + (Vat12 * 0.12m) + (Vat6 * 0.06m);
            decimal TotalSum = NetPrice + TotalVat;

                List<string> Receipt = new List<string>()
            {
                "Bengans Biograf",
                "Fjällgatan 32H",
                "981 39 Jönköping\n",
                "Tel: (+46)63-055 55 55",
                "Mail: info.bengans@gmail.com",
                "Org. Nr: 234567-8901\n",
                $"Säljare: {SellerName}",
                $"{currentDateTime.ToString("s").Replace("T", " ")}",
                $"Lokal Nr: {LocaleIdentifier}",
                $"Kvitto Nr: {ReceiptId}",
                "-----------------------------------------------------\n",
            };

            foreach (KeyValuePair<ProductClass, int> product in Checkout)
            {
                Receipt.Add($"{product.Key.Name}");
                Receipt.Add($"\t\t\t{product.Value} st á\t{(product.Key.Price).ToString("0.00")} SEK");
                Receipt.Add($"\t\t\t\t\t{(product.Value * product.Key.Price).ToString("0.00")} SEK\n");
            }

            List<string> ReceitPart2 = new List<string>()
            {
                "-----------------------------------------------------\n",
                "Momsunderlag:",
                $"Moms 25%\t{Vat25.ToString("0.00")} SEK",
                $"Moms 12%\t{Vat12.ToString("0.00")} SEK",
                $"Moms 6%\t\t{Vat6.ToString("0.00")} SEK",
                $"Momsfritt\t{Vat0.ToString("0.00")} SEK\n",
                $"Nettopris:\t{NetPrice.ToString("0.00")} SEK",
                $"Total moms:\t{TotalVat.ToString("0.00")} SEK\n",
                $"SUMMA:\t\t{TotalSum.ToString("0.00")} SEK\n",
                "-----------------------------------------------------\n",
                "Kortbetalningsinformation finns på annat kvitto.\n",
                "Öppet köp gäller endast biljett, fram till 24 timmar",
                "innan visning",
            };
            Receipt.AddRange(ReceitPart2);

            foreach (KeyValuePair<ProductClass, int> product in Checkout)
            {
                if(product.Key is TicketProduct)
                {
                    Receipt.Add("\n-----------------------------------------------------\n");
                    Receipt.Add($"{product.Key.Name.Replace("Biljett - ","")}");
                    Receipt.Add($"Datum: {DateOnly.FromDateTime(currentDateTime).ToString("s")}");
                    Receipt.Add($"Plats: {seatPosition}");
                    seatPosition++;
                }
            }

            File.WriteAllLinesAsync($@"{ReceiptFolder}\output{ReceiptId}.txt", Receipt);
            ReceiptId++;
        }
    }
}