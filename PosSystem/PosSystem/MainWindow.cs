using System.Windows.Forms;

namespace PosSystem
{
    public partial class MainWindow : Form
    {
        private ProductClass _smallPopcorn = new("Popcorn Liten", 20m);
        private ProductClass _smallSoda = new("Läsk Liten", 20m);
        private ProductClass _mediumPopcorn = new("Popcorn Mellan", 20m);
        private ProductClass _mediumSoda = new("Läsk Mellan", 20m);
        private ProductClass _largePopcorn = new("Popcorn Stor", 20m);
        private ProductClass _largeSoda = new("Läsk Stor", 20m);


        public MainWindow()
        {
            InitializeComponent();
        }

        // Adds soda to the checkout list
        private void SodaButtonSmall_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(_smallSoda);
            // Updates list and total
            UpdateCheckoutList();
            UpdateTotal();
        }

        private void SodaButtonMedium_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(_mediumSoda);
            // Updates list and total
            UpdateCheckoutList();
            UpdateTotal();
        }

        private void SodaButtonLarge_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(_largeSoda);
            // Updates list and total
            UpdateCheckoutList();
            UpdateTotal();
        }

        private void PopcornButtonSmall_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(_smallPopcorn);
            // Updates list and total
            UpdateCheckoutList();
            UpdateTotal();
        }

        // Adds popcorn to the checkout list
        private void PopcornButtonMedium_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(_mediumPopcorn);
            // Updates list and total
            UpdateCheckoutList();
            UpdateTotal();
        }

        private void PopcornButtonLarge_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(_largePopcorn);
            // Updates list and total
            UpdateCheckoutList();
            UpdateTotal();
        }

        private void UpdateTotal()
        {
            this.TotalText.Text = $"Totalt: {Program.Checkout.Sum(x => x.Key.Price * x.Value).ToString()}kr";
        }

        private void UpdateCheckoutList()
        {
            this.CheckoutList.Items.Clear();

            foreach (KeyValuePair<ProductClass, int> product in Program.Checkout)
            {
                this.CheckoutList.Items.Add($"{product.Value}x {product.Key.Name}");
            }
        }

        // Clear the checkout list
        private void Clear_Click(object sender, EventArgs e)
        {
            Program.ClearCheckout();
            this.CheckoutList.Items.Clear();
            this.TotalText.Text = "Totalt: 0kr";
        }
    }
}