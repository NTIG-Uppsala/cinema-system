using System.Diagnostics;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateButtons();
        }

        public static Products products = new();

        // Create buttons

        public void CreateButtons()
        {

            for (int i = 0; i < products.productList.Count; i++)
            {
                var product = products.productList[i];
                Debug.WriteLine(product.Name);
                Debug.WriteLine(product.Price);
                Debug.WriteLine(product.Vat);

                var button = new ProductButton(product);
                button.Text = product.Name;
                button.Size = new Size(100, 100);
                button.Font = new Font("Trebuchet MS", 12);
                button.Click += updateCheckout;

                SnackLayout.Controls.Add(button);
            }
        }

        private void updateCheckout(object sender, EventArgs e)
        {

            var button = sender as ProductButton; 
            
            if (button == null)
            {
                throw new NullReferenceException("sender is not ProductButton");
            }
            
            Program.AddToCheckout(button.product);
            UpdateCheckoutList();
            UpdateTotal();
        }

        //
        // Adds movie to the checkout list
        //
        private void MovieButton1_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(Program.Shrek1);
            // Updates list and total
            UpdateCheckoutList();
            UpdateTotal();
        }

        private void MovieButton2_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(Program.Shrek2);
            // Updates list and total
            UpdateCheckoutList();
            UpdateTotal();
        }

        private void MovieButton3_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(Program.Shrek3);
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

        private void Pay_Click(object sender, EventArgs e)
        {
            Program.WriteReceipt();
            Program.ClearCheckout();
            this.CheckoutList.Items.Clear();
            this.TotalText.Text = "Totalt: 0kr";
        }
    }
}