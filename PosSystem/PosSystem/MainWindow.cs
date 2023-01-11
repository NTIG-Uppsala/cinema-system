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

            // Product buttons
            for (int i = 0; i < products.productList.Count; i++)
            {
                var product = products.productList[i];
                Debug.WriteLine(product.Name);
                Debug.WriteLine(product.Price);
                Debug.WriteLine(product.Vat);

                var button = new ProductButton(product);
                button.Text = product.Name;
                button.Name = $"button{i}";
                button.BackColor = ColorTranslator.FromHtml(product.Color);
                button.Size = new Size(100, 100);
                button.Font = new Font("Trebuchet MS", 12);
                button.Click += updateCheckout;

                SnackLayout.Controls.Add(button);
            }

            // Movie buttons
            for (int i = 0; i < products.moviesList.Count; i++)
            {
                var product = products.moviesList[i];


                TabPage tabpage = new TabPage();
                tabpage.Text = product.Name;
                tabControl1.Controls.Add(tabpage);
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

        private void MovieLayout_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}