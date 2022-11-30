namespace PosSystem
{
    public partial class MainWindow : Form
    {
        private ProductClass _popcorn = new("Popcorn", 69m);
        private ProductClass _soda = new("Läsk", 69m);


        public MainWindow()
        {
            InitializeComponent();
        }

        private void PopcornButton_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(_popcorn);
            this.CheckoutList.Items.Add("Popcorn");
        }

        private void SodaButton_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(_soda);
            this.CheckoutList.Items.Add("Läsk");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Program.ClearCheckout();
            this.CheckoutList.Items.Clear();
        }
        
    }
}