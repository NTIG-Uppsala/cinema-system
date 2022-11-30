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
            this.PopcornButton = new System.Windows.Forms.Button();
            this.SodaButton = new System.Windows.Forms.Button();
            this.CheckoutList = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PopcornButton
            // 
            this.PopcornButton.BackColor = System.Drawing.Color.Yellow;
            this.PopcornButton.Location = new System.Drawing.Point(81, 161);
            this.PopcornButton.Name = "PopcornButton";
            this.PopcornButton.Size = new System.Drawing.Size(201, 89);
            this.PopcornButton.TabIndex = 0;
            this.PopcornButton.Text = "Popcorn";
            this.PopcornButton.UseVisualStyleBackColor = false;
            this.PopcornButton.Click += new System.EventHandler(this.PopcornButton_Click);
            // 
            // SodaButton
            // 
            this.SodaButton.BackColor = System.Drawing.Color.Fuchsia;
            this.SodaButton.Location = new System.Drawing.Point(81, 326);
            this.SodaButton.Name = "SodaButton";
            this.SodaButton.Size = new System.Drawing.Size(201, 89);
            this.SodaButton.TabIndex = 1;
            this.SodaButton.Text = "Läsk";
            this.SodaButton.UseVisualStyleBackColor = false;
            this.SodaButton.Click += new System.EventHandler(this.SodaButton_Click);
            // 
            // CheckoutList
            // 
            this.CheckoutList.FormattingEnabled = true;
            this.CheckoutList.ItemHeight = 20;
            this.CheckoutList.Location = new System.Drawing.Point(1183, 0);
            this.CheckoutList.Name = "CheckoutList";
            this.CheckoutList.Size = new System.Drawing.Size(378, 784);
            this.CheckoutList.TabIndex = 2;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Red;
            this.Clear.Location = new System.Drawing.Point(1183, 780);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(190, 84);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Rensa";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Pay.Location = new System.Drawing.Point(1370, 780);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(191, 84);
            this.Pay.TabIndex = 4;
            this.Pay.Text = "Betala";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1558, 865);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CheckoutList);
            this.Controls.Add(this.SodaButton);
            this.Controls.Add(this.PopcornButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        public Button PopcornButton;
        public Button SodaButton;
        private ListBox CheckoutList;
        public Button Clear;
        public Button Pay;
    }
}