namespace PosSystem
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PopcornButtonSmall = new System.Windows.Forms.Button();
            this.SodaButtonSmall = new System.Windows.Forms.Button();
            this.CheckoutList = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.SodaButtonMedium = new System.Windows.Forms.Button();
            this.SodaButtonLarge = new System.Windows.Forms.Button();
            this.PopcornButtonMedium = new System.Windows.Forms.Button();
            this.PopcornButtonLarge = new System.Windows.Forms.Button();
            this.TotalText = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SnackPage = new System.Windows.Forms.TabPage();
            this.MoviePage = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.SnackPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // PopcornButtonSmall
            // 
            this.PopcornButtonSmall.BackColor = System.Drawing.Color.Yellow;
            this.PopcornButtonSmall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PopcornButtonSmall.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PopcornButtonSmall.Location = new System.Drawing.Point(664, 168);
            this.PopcornButtonSmall.Name = "PopcornButtonSmall";
            this.PopcornButtonSmall.Size = new System.Drawing.Size(114, 133);
            this.PopcornButtonSmall.TabIndex = 0;
            this.PopcornButtonSmall.Text = "Popcorn\r\nLiten";
            this.PopcornButtonSmall.UseVisualStyleBackColor = false;
            this.PopcornButtonSmall.Click += new System.EventHandler(this.PopcornButtonSmall_Click);
            // 
            // SodaButtonSmall
            // 
            this.SodaButtonSmall.BackColor = System.Drawing.Color.Fuchsia;
            this.SodaButtonSmall.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SodaButtonSmall.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SodaButtonSmall.Location = new System.Drawing.Point(146, 168);
            this.SodaButtonSmall.Name = "SodaButtonSmall";
            this.SodaButtonSmall.Size = new System.Drawing.Size(114, 133);
            this.SodaButtonSmall.TabIndex = 1;
            this.SodaButtonSmall.Text = "Läsk\r\nLiten";
            this.SodaButtonSmall.UseVisualStyleBackColor = false;
            this.SodaButtonSmall.Click += new System.EventHandler(this.SodaButtonSmall_Click);
            // 
            // CheckoutList
            // 
            this.CheckoutList.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckoutList.FormattingEnabled = true;
            this.CheckoutList.ItemHeight = 42;
            this.CheckoutList.Location = new System.Drawing.Point(1240, 0);
            this.CheckoutList.Name = "CheckoutList";
            this.CheckoutList.Size = new System.Drawing.Size(462, 1054);
            this.CheckoutList.TabIndex = 2;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clear.FlatAppearance.BorderSize = 5;
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Clear.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(1240, 1175);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(253, 176);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Rensa";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(123)))), ((int)(((byte)(182)))));
            this.Pay.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Pay.FlatAppearance.BorderSize = 5;
            this.Pay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pay.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pay.ForeColor = System.Drawing.Color.White;
            this.Pay.Location = new System.Drawing.Point(1475, 1175);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(229, 176);
            this.Pay.TabIndex = 4;
            this.Pay.Text = "Betala";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // SodaButtonMedium
            // 
            this.SodaButtonMedium.BackColor = System.Drawing.Color.Fuchsia;
            this.SodaButtonMedium.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SodaButtonMedium.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SodaButtonMedium.Location = new System.Drawing.Point(295, 168);
            this.SodaButtonMedium.Name = "SodaButtonMedium";
            this.SodaButtonMedium.Size = new System.Drawing.Size(114, 133);
            this.SodaButtonMedium.TabIndex = 6;
            this.SodaButtonMedium.Text = "Läsk\r\nMellan";
            this.SodaButtonMedium.UseVisualStyleBackColor = false;
            this.SodaButtonMedium.Click += new System.EventHandler(this.SodaButtonMedium_Click);
            // 
            // SodaButtonLarge
            // 
            this.SodaButtonLarge.BackColor = System.Drawing.Color.Fuchsia;
            this.SodaButtonLarge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SodaButtonLarge.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SodaButtonLarge.Location = new System.Drawing.Point(446, 168);
            this.SodaButtonLarge.Name = "SodaButtonLarge";
            this.SodaButtonLarge.Size = new System.Drawing.Size(114, 133);
            this.SodaButtonLarge.TabIndex = 7;
            this.SodaButtonLarge.Text = "Läsk\r\nStor";
            this.SodaButtonLarge.UseVisualStyleBackColor = false;
            this.SodaButtonLarge.Click += new System.EventHandler(this.SodaButtonLarge_Click);
            // 
            // PopcornButtonMedium
            // 
            this.PopcornButtonMedium.BackColor = System.Drawing.Color.Yellow;
            this.PopcornButtonMedium.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PopcornButtonMedium.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PopcornButtonMedium.Location = new System.Drawing.Point(819, 168);
            this.PopcornButtonMedium.Name = "PopcornButtonMedium";
            this.PopcornButtonMedium.Size = new System.Drawing.Size(114, 133);
            this.PopcornButtonMedium.TabIndex = 8;
            this.PopcornButtonMedium.Text = "Popcorn\rMellan";
            this.PopcornButtonMedium.UseVisualStyleBackColor = false;
            this.PopcornButtonMedium.Click += new System.EventHandler(this.PopcornButtonMedium_Click);
            // 
            // PopcornButtonLarge
            // 
            this.PopcornButtonLarge.BackColor = System.Drawing.Color.Yellow;
            this.PopcornButtonLarge.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.PopcornButtonLarge.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PopcornButtonLarge.Location = new System.Drawing.Point(970, 168);
            this.PopcornButtonLarge.Name = "PopcornButtonLarge";
            this.PopcornButtonLarge.Size = new System.Drawing.Size(114, 133);
            this.PopcornButtonLarge.TabIndex = 9;
            this.PopcornButtonLarge.Text = "Popcorn\rStor";
            this.PopcornButtonLarge.UseVisualStyleBackColor = false;
            this.PopcornButtonLarge.Click += new System.EventHandler(this.PopcornButtonLarge_Click);
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.BackColor = System.Drawing.Color.Black;
            this.TotalText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalText.ForeColor = System.Drawing.Color.White;
            this.TotalText.Location = new System.Drawing.Point(1240, 1077);
            this.TotalText.MaximumSize = new System.Drawing.Size(464, 97);
            this.TotalText.MinimumSize = new System.Drawing.Size(464, 97);
            this.TotalText.Name = "TotalText";
            this.TotalText.Padding = new System.Windows.Forms.Padding(0, 15, 0, 0);
            this.TotalText.Size = new System.Drawing.Size(464, 97);
            this.TotalText.TabIndex = 13;
            this.TotalText.Text = "Totalt: 0kr";
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.SnackPage);
            this.TabControl.Controls.Add(this.MoviePage);
            this.TabControl.Font = new System.Drawing.Font("Trebuchet MS", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TabControl.ItemSize = new System.Drawing.Size(200, 85);
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1241, 1351);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 14;
            // 
            // SnackPage
            // 
            this.SnackPage.Controls.Add(this.SodaButtonLarge);
            this.SnackPage.Controls.Add(this.PopcornButtonSmall);
            this.SnackPage.Controls.Add(this.PopcornButtonLarge);
            this.SnackPage.Controls.Add(this.SodaButtonSmall);
            this.SnackPage.Controls.Add(this.PopcornButtonMedium);
            this.SnackPage.Controls.Add(this.SodaButtonMedium);
            this.SnackPage.Location = new System.Drawing.Point(4, 89);
            this.SnackPage.Name = "SnackPage";
            this.SnackPage.Padding = new System.Windows.Forms.Padding(3);
            this.SnackPage.Size = new System.Drawing.Size(1233, 1258);
            this.SnackPage.TabIndex = 0;
            this.SnackPage.Text = "Ätbart";
            this.SnackPage.UseVisualStyleBackColor = true;
            // 
            // MoviePage
            // 
            this.MoviePage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoviePage.Location = new System.Drawing.Point(4, 89);
            this.MoviePage.Name = "MoviePage";
            this.MoviePage.Padding = new System.Windows.Forms.Padding(3);
            this.MoviePage.Size = new System.Drawing.Size(1233, 1258);
            this.MoviePage.TabIndex = 1;
            this.MoviePage.Text = "Filmer";
            this.MoviePage.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1703, 1351);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CheckoutList);
            this.Name = "MainWindow";
            this.Text = "Cinema POS System";
            this.TabControl.ResumeLayout(false);
            this.SnackPage.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button PopcornButtonSmall;
        public Button SodaButtonSmall;
        private ListBox CheckoutList;
        public Button Clear;
        public Button Pay;
        public Button SodaButtonMedium;
        public Button SodaButtonLarge;
        public Button PopcornButtonMedium;
        public Button PopcornButtonLarge;
        public Label TotalText;
        public TabControl TabControl;
        public TabPage SnackPage;
        public TabPage MoviePage;
    }
}