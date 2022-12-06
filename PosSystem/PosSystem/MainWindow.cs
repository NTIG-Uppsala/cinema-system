using System.Windows.Forms;

namespace PosSystem
{
    public partial class MainWindow : Form
    {
        private ProductClass _popcorn = new("Popcorn", 20m);
        private ProductClass _soda = new("Läsk", 20m);
        public int PopcornSmallAdd = 1;
        public int PopcornMediumAdd = 1;
        public int PopcornLargeAdd = 1;
        public int SodaSmallAdd = 1;
        public int SodaMediumAdd = 1;
        public int SodaLargeAdd = 1;


        public MainWindow()
        {
            InitializeComponent();
        }

        // Adds soda to the checkout list
        private void SodaButtonSmall_Click(object sender, EventArgs e)
        {
            var b = SodaSmallAdd++ + "x Läsk Liten";
            Program.AddToCheckout(_soda);
            this.CheckoutList.Items.Add(b);
            // Calculates total price and adds the text top the TotalText textbox
            this.TotalText.Text = "Total: " + Program.CheckoutList.Sum(x => x.product.Price).ToString() + "kr";

            if (SodaSmallAdd > 2)
            {
                this.CheckoutList.Items.RemoveAt(this.CheckoutList.SelectedIndex != -1 ? this.CheckoutList.SelectedIndex : 0);
            }
        }

        private void SodaButtonMedium_Click(object sender, EventArgs e)
        {
            var b = SodaMediumAdd++ + "x Läsk Mellan";
            Program.AddToCheckout(_soda);
            this.CheckoutList.Items.Add(b);
            this.TotalText.Text = "Total: " + Program.CheckoutList.Sum(x => x.product.Price).ToString() + "kr";

            if (SodaMediumAdd > 2)
            {
                this.CheckoutList.Items.RemoveAt(this.CheckoutList.SelectedIndex != -1 ? this.CheckoutList.SelectedIndex : 0);
            }
        }

        private void SodaButtonLarge_Click(object sender, EventArgs e)
        {
            var b = SodaLargeAdd++ + "x Läsk Stor";
            Program.AddToCheckout(_soda);
            this.CheckoutList.Items.Add(b);
            this.TotalText.Text = "Total: " + Program.CheckoutList.Sum(x => x.product.Price).ToString() + "kr";

            if (SodaLargeAdd > 2)
            {
                this.CheckoutList.Items.RemoveAt(this.CheckoutList.SelectedIndex != -1 ? this.CheckoutList.SelectedIndex : 0);
            }
        }

        // Adds popcorn to the checkout list
        private void PopcornButtonSmall_Click(object sender, EventArgs e)
        {
            var a = PopcornSmallAdd++ + "x Popcorn Liten";
            Program.AddToCheckout(_popcorn);
            this.CheckoutList.Items.Add(a);
            this.TotalText.Text = "Total: " + Program.CheckoutList.Sum(x => x.product.Price).ToString() + "kr";

            if (PopcornSmallAdd > 2)
            {
                this.CheckoutList.Items.RemoveAt(this.CheckoutList.SelectedIndex != -1 ? this.CheckoutList.SelectedIndex : 0);
            }
        }

        private void PopcornButtonMedium_Click(object sender, EventArgs e)
        {
            var a = PopcornMediumAdd++ + "x Popcorn Mellan";
            Program.AddToCheckout(_popcorn);
            this.CheckoutList.Items.Add(a);
            this.TotalText.Text = "Total: " + Program.CheckoutList.Sum(x => x.product.Price).ToString() + "kr";

            if (PopcornMediumAdd > 2)
            {
                this.CheckoutList.Items.RemoveAt(this.CheckoutList.SelectedIndex != -1 ? this.CheckoutList.SelectedIndex : 0);
            }
        }

        private void PopcornButtonLarge_Click(object sender, EventArgs e)
        {
            var a = PopcornLargeAdd++ + "x Popcorn Stor";
            Program.AddToCheckout(_popcorn);
            this.CheckoutList.Items.Add(a);
            this.TotalText.Text = "Total: " + Program.CheckoutList.Sum(x => x.product.Price).ToString() + "kr";

            if (PopcornLargeAdd > 2)
            {
                this.CheckoutList.Items.RemoveAt(this.CheckoutList.SelectedIndex != -1 ? this.CheckoutList.SelectedIndex : 0);
            }
        }

        // Clear the checkout list
        private void Clear_Click(object sender, EventArgs e)
        {
            Program.ClearCheckout();
            this.CheckoutList.Items.Clear();
            PopcornSmallAdd = 1;
            PopcornMediumAdd = 1;
            PopcornLargeAdd = 1;
            SodaSmallAdd = 1;
            SodaMediumAdd = 1;
            SodaLargeAdd = 1;
            this.TotalText.Text = "Total: 0kr";
        }
    }
}