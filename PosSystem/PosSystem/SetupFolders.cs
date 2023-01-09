using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosSystem
{
    public class SetupFolders
    {
        string baseFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem";
        string receiptFolder = $@"{Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)}\PosSystem\PosReceipts";

        public SetupFolders()
        {
            Directory.CreateDirectory(baseFolder);
            Directory.CreateDirectory(receiptFolder);

            if (!File.Exists($@"{baseFolder}\products.csv"))
            {
                List<string> products = new List<string>()
                {
                    "Popcorn Liten,25,",
                    "Popcorn Mellan,35,",
                    "Popcorn Stor,50,",
                    "Läsk Liten,20,",
                    "Läsk Mellan,25,",
                    "Läsk Stor,35,",
                };

                File.WriteAllLines($@"{baseFolder}\products.csv", products);
            }
        }
    }
}
