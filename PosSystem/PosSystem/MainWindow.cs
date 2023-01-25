using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq.Expressions;
using System.Net.Http.Headers;
using System.Reflection.Emit;
using System.Windows.Forms;

namespace PosSystem
{
    public partial class MainWindow : Form
    {
        public static Products products = new();
        public MainWindow()
        {
            InitializeComponent();
            CreateButtons();
            products.GetProducts();
        }

        public int empty = 0;

        int shrek1 = 16;
        int shrek2 = 16;
        int shrek3 = 16;


        List<System.Windows.Forms.Label> movieSeats = new List<System.Windows.Forms.Label>();
        List<List<System.Windows.Forms.Label>> seatList = new List<List<System.Windows.Forms.Label>>();

        Dictionary<TabPage, ProductClass> movieDict = new Dictionary<TabPage, ProductClass>();

        // Create buttons

        public void CreateButtons()
        {
            //Product buttons
            foreach (ProductClass product in products.GetProducts())
            {
                var button = new ProductButton(product);
                button.Text = product.Name;
                button.Name = $"{product.product_id}";
                button.BackColor = ColorTranslator.FromHtml(product.Color);
                button.Size = new Size(100, 100);
                button.Font = new Font("Trebuchet MS", 12);
                button.Click += updateCheckout;

                SnackLayout.Controls.Add(button);
            }

            // Movie buttons
            for (int i = 0; i < products.movieList.Count; i++)
            {

                var product = products.movieList[i];

                TabPage tabpage = new TabPage();
                tabpage.Text = product.Name;
                tabpage.AutoSize = true;
                tabControl1.Controls.Add(tabpage);
               
                movieDict.Add(tabpage, product);

                // Add Movie button
                Button addMovie = new Button();
                addMovie.Text = "Köp Biljett";
                addMovie.AutoSize = true;
                addMovie.Padding = new Padding(20);
                addMovie.Click += UpdateSeats;
                addMovie.Location = new Point((1003 - addMovie.Width * 2), 709);
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
            seatList.Add(new List<System.Windows.Forms.Label>());
            tabpage.Controls.Add(topToBottom);

            Array[] rows =
            {
                new[] {1, 2, 3, 4},
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
                    label.Text = $"{j + 1}";
                    label.AutoSize = true;
                    label.Padding = new Padding(20);
                    label.Font = new Font("Trebuchet MS", 12);
                    label.BackColor = Color.Gray;
                    seatList.Last().Add(label);
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
            movieSeats.Add(amountEmpty);
            empty = 0;
        }

        private void UpdateSeats(object sender, EventArgs e)
        {

            var tab = tabControl1.SelectedTab.ToString();

            Debug.WriteLine($"HLEOIO?{movieSeats[1]}");
            switch (tab)
            {
                case "TabPage: {Shrek 1}":
                    if (shrek1 > 0) { 
                        shrek1 -= 1;
                        movieSeats[0].Text = $"Lediga platser: {shrek1}";
                        seatList[0][shrek1].BackColor = Color.Red;
                        Program.AddToCheckout(movieDict[tabControl1.SelectedTab]);
                    }
                    else {
                       shrek1 = 0;
                       movieSeats[0].Text = $"Lediga platser: {shrek1}";
                    }
                    break;
                case "TabPage: {Shrek 2}":
                    if (shrek2 > 0) { 
                        shrek2 -= 1;
                        movieSeats[1].Text = $"Lediga platser: {shrek2}";
                        seatList[1][shrek2].BackColor = Color.Red;
                        Program.AddToCheckout(movieDict[tabControl1.SelectedTab]);
                    }
                    else
                    {
                        shrek2 = 0;
                        movieSeats[1].Text = $"Lediga platser: {shrek2}";
                    }
                    break;
                case "TabPage: {Shrek 3}":
                    if (shrek3 > 0) { 
                        shrek3 -= 1;
                        movieSeats[2].Text = $"Lediga platser: {shrek3}";
                        seatList[2][shrek3].BackColor = Color.Red;
                        Program.AddToCheckout(movieDict[tabControl1.SelectedTab]);
                    }
                    else
                    {
                        shrek3 = 0;
                        movieSeats[2].Text = $"Lediga platser: {shrek3}";
                    }
                    break;
                default:
                    // code block
                    break;
            }

            UpdateCheckoutList();
            UpdateTotal();

        }

    }
}