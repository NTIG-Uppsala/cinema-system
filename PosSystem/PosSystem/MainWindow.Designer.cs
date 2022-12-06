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
            this.TotalText = new System.Windows.Forms.TextBox();
            this.SodaButtonMedium = new System.Windows.Forms.Button();
            this.SodaButtonLarge = new System.Windows.Forms.Button();
            this.PopcornButtonMedium = new System.Windows.Forms.Button();
            this.PopcornButtonLarge = new System.Windows.Forms.Button();
            this.SnacksButton = new System.Windows.Forms.Button();
            this.MovieButton = new System.Windows.Forms.Button();
            this.OtherButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PopcornButtonSmall
            // 
            this.PopcornButtonSmall.BackColor = System.Drawing.Color.Yellow;
            this.PopcornButtonSmall.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PopcornButtonSmall.Location = new System.Drawing.Point(555, 349);
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
            this.SodaButtonSmall.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SodaButtonSmall.Location = new System.Drawing.Point(37, 349);
            this.SodaButtonSmall.Name = "SodaButtonSmall";
            this.SodaButtonSmall.Size = new System.Drawing.Size(114, 133);
            this.SodaButtonSmall.TabIndex = 1;
            this.SodaButtonSmall.Text = "Läsk\r\nLiten";
            this.SodaButtonSmall.UseVisualStyleBackColor = false;
            this.SodaButtonSmall.Click += new System.EventHandler(this.SodaButtonSmall_Click);
            // 
            // CheckoutList
            // 
            this.CheckoutList.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckoutList.FormattingEnabled = true;
            this.CheckoutList.ItemHeight = 26;
            this.CheckoutList.Location = new System.Drawing.Point(2088, 1);
            this.CheckoutList.Name = "CheckoutList";
            this.CheckoutList.Size = new System.Drawing.Size(464, 1096);
            this.CheckoutList.TabIndex = 2;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(25)))), ((int)(((byte)(28)))));
            this.Clear.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.Clear.FlatAppearance.BorderSize = 5;
            this.Clear.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.ForeColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(2088, 1189);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(245, 165);
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
            this.Pay.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pay.ForeColor = System.Drawing.Color.White;
            this.Pay.Location = new System.Drawing.Point(2316, 1189);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(236, 165);
            this.Pay.TabIndex = 4;
            this.Pay.Text = "Betala";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Clear_Click);
            // 
            // TotalText
            // 
            this.TotalText.BackColor = System.Drawing.SystemColors.Info;
            this.TotalText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalText.Location = new System.Drawing.Point(2088, 1103);
            this.TotalText.Multiline = true;
            this.TotalText.Name = "TotalText";
            this.TotalText.Size = new System.Drawing.Size(464, 80);
            this.TotalText.TabIndex = 0;
            this.TotalText.Text = "Total: 0kr";
            // 
            // SodaButtonMedium
            // 
            this.SodaButtonMedium.BackColor = System.Drawing.Color.Fuchsia;
            this.SodaButtonMedium.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SodaButtonMedium.Location = new System.Drawing.Point(186, 349);
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
            this.SodaButtonLarge.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SodaButtonLarge.Location = new System.Drawing.Point(337, 349);
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
            this.PopcornButtonMedium.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PopcornButtonMedium.Location = new System.Drawing.Point(710, 349);
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
            this.PopcornButtonLarge.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PopcornButtonLarge.Location = new System.Drawing.Point(861, 349);
            this.PopcornButtonLarge.Name = "PopcornButtonLarge";
            this.PopcornButtonLarge.Size = new System.Drawing.Size(114, 133);
            this.PopcornButtonLarge.TabIndex = 9;
            this.PopcornButtonLarge.Text = "Popcorn\rStor";
            this.PopcornButtonLarge.UseVisualStyleBackColor = false;
            this.PopcornButtonLarge.Click += new System.EventHandler(this.PopcornButtonLarge_Click);
            // 
            // SnacksButton
            // 
            this.SnacksButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.SnacksButton.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SnacksButton.Location = new System.Drawing.Point(370, 1);
            this.SnacksButton.Name = "SnacksButton";
            this.SnacksButton.Size = new System.Drawing.Size(573, 153);
            this.SnacksButton.TabIndex = 10;
            this.SnacksButton.Text = "Ätbart";
            this.SnacksButton.UseVisualStyleBackColor = false;
            // 
            // MovieButton
            // 
            this.MovieButton.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MovieButton.Location = new System.Drawing.Point(939, 1);
            this.MovieButton.Name = "MovieButton";
            this.MovieButton.Size = new System.Drawing.Size(573, 153);
            this.MovieButton.TabIndex = 11;
            this.MovieButton.Text = "Filmer";
            this.MovieButton.UseVisualStyleBackColor = true;
            // 
            // OtherButton
            // 
            this.OtherButton.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtherButton.Location = new System.Drawing.Point(1509, 1);
            this.OtherButton.Name = "OtherButton";
            this.OtherButton.Size = new System.Drawing.Size(573, 153);
            this.OtherButton.TabIndex = 12;
            this.OtherButton.Text = "Övrigt";
            this.OtherButton.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2564, 1360);
            this.Controls.Add(this.OtherButton);
            this.Controls.Add(this.MovieButton);
            this.Controls.Add(this.SnacksButton);
            this.Controls.Add(this.PopcornButtonLarge);
            this.Controls.Add(this.PopcornButtonMedium);
            this.Controls.Add(this.SodaButtonLarge);
            this.Controls.Add(this.SodaButtonMedium);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CheckoutList);
            this.Controls.Add(this.SodaButtonSmall);
            this.Controls.Add(this.PopcornButtonSmall);
            this.Name = "MainWindow";
            this.Text = "Cinema POS System";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Button PopcornButtonSmall;
        public Button SodaButtonSmall;
        private ListBox CheckoutList;
        public Button Clear;
        public Button Pay;
        public TextBox TotalText;
        public Button SodaButtonMedium;
        public Button SodaButtonLarge;
        public Button PopcornButtonMedium;
        public Button PopcornButtonLarge;
        public Button SnacksButton;
        public Button MovieButton;
        public Button OtherButton;
    }
}