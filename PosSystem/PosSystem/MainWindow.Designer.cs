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
            this.CheckoutList = new System.Windows.Forms.ListBox();
            this.Clear = new System.Windows.Forms.Button();
            this.Pay = new System.Windows.Forms.Button();
            this.TotalText = new System.Windows.Forms.Label();
            this.TabControl = new System.Windows.Forms.TabControl();
            this.SnackPage = new System.Windows.Forms.TabPage();
            this.SnackLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.MoviePage = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabControl.SuspendLayout();
            this.SnackPage.SuspendLayout();
            this.MoviePage.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CheckoutList
            // 
            this.CheckoutList.Font = new System.Drawing.Font("Trebuchet MS", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CheckoutList.FormattingEnabled = true;
            this.CheckoutList.ItemHeight = 35;
            this.CheckoutList.Location = new System.Drawing.Point(1085, 0);
            this.CheckoutList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CheckoutList.Name = "CheckoutList";
            this.CheckoutList.Size = new System.Drawing.Size(405, 809);
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
            this.Clear.Location = new System.Drawing.Point(1085, 881);
            this.Clear.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(221, 132);
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
            this.Pay.Location = new System.Drawing.Point(1291, 881);
            this.Pay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Pay.Name = "Pay";
            this.Pay.Size = new System.Drawing.Size(200, 132);
            this.Pay.TabIndex = 4;
            this.Pay.Text = "Betala";
            this.Pay.UseVisualStyleBackColor = false;
            this.Pay.Click += new System.EventHandler(this.Pay_Click);
            // 
            // TotalText
            // 
            this.TotalText.AutoSize = true;
            this.TotalText.BackColor = System.Drawing.Color.Black;
            this.TotalText.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TotalText.ForeColor = System.Drawing.Color.White;
            this.TotalText.Location = new System.Drawing.Point(1085, 808);
            this.TotalText.MaximumSize = new System.Drawing.Size(406, 73);
            this.TotalText.MinimumSize = new System.Drawing.Size(406, 73);
            this.TotalText.Name = "TotalText";
            this.TotalText.Padding = new System.Windows.Forms.Padding(0, 11, 0, 0);
            this.TotalText.Size = new System.Drawing.Size(406, 73);
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
            this.TabControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(1086, 1013);
            this.TabControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.TabControl.TabIndex = 14;
            // 
            // SnackPage
            // 
            this.SnackPage.BackColor = System.Drawing.Color.Transparent;
            this.SnackPage.Controls.Add(this.SnackLayout);
            this.SnackPage.Location = new System.Drawing.Point(4, 89);
            this.SnackPage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SnackPage.Name = "SnackPage";
            this.SnackPage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SnackPage.Size = new System.Drawing.Size(1078, 920);
            this.SnackPage.TabIndex = 0;
            this.SnackPage.Text = "Ätbart";
            // 
            // SnackLayout
            // 
            this.SnackLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SnackLayout.Location = new System.Drawing.Point(3, 2);
            this.SnackLayout.Name = "SnackLayout";
            this.SnackLayout.Size = new System.Drawing.Size(1072, 916);
            this.SnackLayout.TabIndex = 10;
            // 
            // MoviePage
            // 
            this.MoviePage.Controls.Add(this.tabControl1);
            this.MoviePage.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MoviePage.Location = new System.Drawing.Point(4, 89);
            this.MoviePage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviePage.Name = "MoviePage";
            this.MoviePage.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MoviePage.Size = new System.Drawing.Size(1078, 920);
            this.MoviePage.TabIndex = 1;
            this.MoviePage.Text = "Filmer";
            this.MoviePage.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Trebuchet MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 100);
            this.tabControl1.Location = new System.Drawing.Point(-4, -6);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Multiline = true;
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1086, 930);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 104);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1078, 822);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(30, 723);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(244, 35);
            this.label3.TabIndex = 107;
            this.label3.Text = "Antal Platser: 2 st";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(30, 552);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 35);
            this.label2.TabIndex = 106;
            this.label2.Text = "Salong 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Trebuchet MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(30, 587);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 35);
            this.label1.TabIndex = 105;
            this.label1.Text = "Lediga platser: 100";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 104);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1078, 822);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1490, 1013);
            this.Controls.Add(this.TabControl);
            this.Controls.Add(this.TotalText);
            this.Controls.Add(this.Pay);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CheckoutList);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainWindow";
            this.Text = "Cinema POS System";
            this.TabControl.ResumeLayout(false);
            this.SnackPage.ResumeLayout(false);
            this.MoviePage.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ListBox CheckoutList;
        public Button Clear;
        public Button Pay;
        public Label TotalText;
        public TabControl TabControl;
        public TabPage MoviePage;
        public TabPage SnackPage;
        public FlowLayoutPanel SnackLayout;
        public TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}