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
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.Total = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.SuspendLayout();
            // 
            // PopcornButton
            // 
            this.PopcornButton.BackColor = System.Drawing.Color.Yellow;
            this.PopcornButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PopcornButton.Location = new System.Drawing.Point(1162, 349);
            this.PopcornButton.Name = "PopcornButton";
            this.PopcornButton.Size = new System.Drawing.Size(114, 133);
            this.PopcornButton.TabIndex = 0;
            this.PopcornButton.Text = "Popcorn";
            this.PopcornButton.UseVisualStyleBackColor = false;
            this.PopcornButton.Click += new System.EventHandler(this.PopcornButton_Click);
            // 
            // SodaButton
            // 
            this.SodaButton.BackColor = System.Drawing.Color.Fuchsia;
            this.SodaButton.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SodaButton.Location = new System.Drawing.Point(461, 349);
            this.SodaButton.Name = "SodaButton";
            this.SodaButton.Size = new System.Drawing.Size(114, 133);
            this.SodaButton.TabIndex = 1;
            this.SodaButton.Text = "Läsk";
            this.SodaButton.UseVisualStyleBackColor = false;
            this.SodaButton.Click += new System.EventHandler(this.SodaButton_Click);
            // 
            // CheckoutList
            // 
            this.CheckoutList.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckoutList.FormattingEnabled = true;
            this.CheckoutList.ItemHeight = 26;
            this.CheckoutList.Location = new System.Drawing.Point(1719, 1);
            this.CheckoutList.Name = "CheckoutList";
            this.CheckoutList.Size = new System.Drawing.Size(457, 1096);
            this.CheckoutList.TabIndex = 2;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.Red;
            this.Clear.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Clear.Location = new System.Drawing.Point(1719, 1221);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(229, 165);
            this.Clear.TabIndex = 3;
            this.Clear.Text = "Rensa";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // Pay
            // 
            this.Pay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Pay.Font = new System.Drawing.Font("Trebuchet MS", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Pay.Location = new System.Drawing.Point(1947, 1221);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(229, 165);
            this.Pay.TabIndex = 4;
            this.Pay.Text = "Betala";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Clear_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1719, 168);
            this.panel1.TabIndex = 5;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1719, 168);
            this.splitContainer1.SplitterDistance = 571;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.splitContainer2.Size = new System.Drawing.Size(1143, 168);
            this.splitContainer2.SplitterDistance = 571;
            this.splitContainer2.SplitterWidth = 5;
            this.splitContainer2.TabIndex = 0;
            // 
            // Total
            // 
            this.Total.BackColor = System.Drawing.SystemColors.Info;
            this.Total.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Total.Font = new System.Drawing.Font("Segoe UI", 1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Total.Location = new System.Drawing.Point(1719, 1120);
            this.Total.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Total.Name = "Total";
            this.Total.Size = new System.Drawing.Size(457, 101);
            this.Total.TabIndex = 6;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2176, 1388);
            this.Controls.Add(this.Total);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CheckoutList);
            this.Controls.Add(this.SodaButton);
            this.Controls.Add(this.PopcornButton);
            this.Name = "MainWindow";
            this.Text = "Cinema POS System";
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public Button PopcornButton;
        public Button SodaButton;
        private ListBox CheckoutList;
        public Button Clear;
        public Button Pay;
        private Panel panel1;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        public Panel Total;
    }
}