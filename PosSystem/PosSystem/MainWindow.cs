namespace PosSystem
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void PopcornButton_Click(object sender, EventArgs e)
        {
            this.CheckoutList.Items.Add("Popcorn");
        }

        private void SodaButton_Click(object sender, EventArgs e)
        {
            this.CheckoutList.Items.Add("L�sk");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            this.CheckoutList.Items.Clear();
        }
        
    }
}