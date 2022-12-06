using System.Windows.Forms;

namespace PosSystem
{
    public partial class MainWindow : Form
    {
        private ProductClass _popcorn = new("Popcorn", 20m);
        private ProductClass _soda = new("Läsk", 20m);
        public int PopcornAdd = 1;
        public int SodaAdd = 1;


        public MainWindow()
        {
            InitializeComponent();
        }

        // Add popcorn to checkout list
        private void PopcornButton_Click(object sender, EventArgs e)
        {
            var a = PopcornAdd++ + "x Popcorn";
            Program.AddToCheckout(_popcorn);
            this.CheckoutList.Items.Add(a);
            // Calculates total price and adds the text top the TotalText textbox
            this.TotalText.Text = Program.CheckoutList.Sum(x => x.product.Price).ToString() + "kr";

            if (PopcornAdd > 2)
            {
                this.CheckoutList.Items.RemoveAt(this.CheckoutList.SelectedIndex != -1 ? this.CheckoutList.SelectedIndex : 0);
            }
        }

        // Add soda to checkout list
        private void SodaButton_Click(object sender, EventArgs e)
        {
            var b = SodaAdd++ + "x Läsk";
            Program.AddToCheckout(_soda);
            this.CheckoutList.Items.Add(b);
            // Calculates total price and adds the text top the TotalText textbox
            this.TotalText.Text = Program.CheckoutList.Sum(x => x.product.Price).ToString() + "kr";

            if (SodaAdd > 2)
            {
                this.CheckoutList.Items.RemoveAt(this.CheckoutList.SelectedIndex != -1 ? this.CheckoutList.SelectedIndex : 0);
            }
        }

        // Clear the checkout list
        private void Clear_Click(object sender, EventArgs e)
        {
            Program.ClearCheckout();
            this.CheckoutList.Items.Clear();
            PopcornAdd = 1;
            SodaAdd = 1;
            this.TotalText.Text = "0kr";
        }
    }
}