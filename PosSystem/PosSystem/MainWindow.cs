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
            var i = 2;
            var b = i++ + "x Popcorn";
            // https://stackoverflow.com/questions/36236956/c-sharp-replace-text-in-listbox //
            if (CheckoutList.Items.Cast<string>().Contains("1x Popcorn"))
            {
                int a = CheckoutList.Items.IndexOf("1x Popcorn");
                CheckoutList.Items.RemoveAt(a);
                CheckoutList.Items.Add(b);
            }
            else
            {
                Program.AddToCheckout(_popcorn);
                CheckoutList.Items.Add("1x Popcorn");
            }
        }
        
        private void SodaButton_Click(object sender, EventArgs e)
        {
            Program.AddToCheckout(_soda);
            this.CheckoutList.Items.Add("1x Läsk");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            Program.ClearCheckout();
            this.CheckoutList.Items.Clear();
        }
    }
}