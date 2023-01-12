using System.Diagnostics;
using System.Reflection.Emit;
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

        int empty = 0;

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
                tabpage.AutoSize = true;
                tabControl1.Controls.Add(tabpage);

                // Add Movie button
                Button addMovie = new Button();
                addMovie.Text = "Köp Biljett";
                addMovie.AutoSize = true;
                addMovie.Padding = new Padding(20);
                // Add a click function  to add movie
                addMovie.Location = new Point((1003 - addMovie.Width*2), 709);
                Debug.WriteLine(addMovie.Location);
                tabpage.Controls.Add(addMovie);

                Create_Seating(tabpage);
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
        
        // Create seats 
        private void Create_Seating(TabPage tabpage)
        {

            FlowLayoutPanel topToBottom = new FlowLayoutPanel();
            topToBottom.Size = tabpage.Size;
            topToBottom.FlowDirection = FlowDirection.TopDown;
            tabpage.Controls.Add(topToBottom);

            Array[] rows =
            {
                new[] {1, 2, 3, 4,},
                new[] {1, 2, 3, 4},
                new[] {1, 2, 3, 4},
                new[] {1, 2, 3, 4},
            };
            
            for (int i = 0; i < rows.Length; i++)
            {
                FlowLayoutPanel panel = new FlowLayoutPanel();
                panel.FlowDirection = FlowDirection.LeftToRight;
                panel.AutoSize = true;
                topToBottom.Controls.Add(panel);
                for (int j = 0; j < rows[i].Length; j++) {
                    System.Windows.Forms.Label label = new System.Windows.Forms.Label();
                    label.Text = $"{j+1}";
                    label.AutoSize = true;
                    label.Padding = new Padding(20);
                    label.Font = new Font("Trebuchet MS", 12);
                    label.BackColor = Color.Gray;
                    panel.Controls.Add(label);
                    empty += 1;
                };
            };

            System.Windows.Forms.Label amountEmpty = new System.Windows.Forms.Label();
            amountEmpty.Location = new Point(100, 100);
            amountEmpty.AutoSize = true;
            amountEmpty.Padding = new Padding(0, 20, 20, 20);
            amountEmpty.Text = $"Lediga platser: {empty}";
            topToBottom.Controls.Add(amountEmpty);

        }

    }
}