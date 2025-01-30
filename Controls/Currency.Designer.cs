namespace CalculatorProject.Controls
{
    partial class Currency
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbFromCurrency = new ComboBox();
            cmbToCurrency = new ComboBox();
            lblConversionRate = new Label();
            lblCurrency = new Label();
            txtAmountToConvert = new TextBox();
            txtAmountConverted = new TextBox();
            btnSideBar = new Button();
            btnZero = new Button();
            btnNine = new Button();
            btnEight = new Button();
            btnSeven = new Button();
            btnSix = new Button();
            btnFive = new Button();
            btnFour = new Button();
            btnThree = new Button();
            btnTwo = new Button();
            btnOne = new Button();
            btnDelete = new Button();
            btnDecimal = new Button();
            lblLastUpdated = new Label();
            SuspendLayout();
            // 
            // cmbFromCurrency
            // 
            cmbFromCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbFromCurrency.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbFromCurrency.FormattingEnabled = true;
            cmbFromCurrency.Location = new Point(35, 120);
            cmbFromCurrency.Name = "cmbFromCurrency";
            cmbFromCurrency.Size = new Size(163, 33);
            cmbFromCurrency.TabIndex = 1;
            cmbFromCurrency.SelectedIndexChanged += cmbFromCurrency_SelectedIndexChanged;
            // 
            // cmbToCurrency
            // 
            cmbToCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbToCurrency.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            cmbToCurrency.FormattingEnabled = true;
            cmbToCurrency.Location = new Point(35, 243);
            cmbToCurrency.Name = "cmbToCurrency";
            cmbToCurrency.Size = new Size(163, 33);
            cmbToCurrency.TabIndex = 2;
            cmbToCurrency.SelectedIndexChanged += cmbToCurrency_SelectedIndexChanged;
            // 
            // lblConversionRate
            // 
            lblConversionRate.AutoSize = true;
            lblConversionRate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblConversionRate.ForeColor = Color.White;
            lblConversionRate.Location = new Point(22, 208);
            lblConversionRate.Name = "lblConversionRate";
            lblConversionRate.Size = new Size(128, 21);
            lblConversionRate.TabIndex = 3;
            lblConversionRate.Text = "1GBP = 1.24USD";
            // 
            // lblCurrency
            // 
            lblCurrency.AutoSize = true;
            lblCurrency.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCurrency.ForeColor = Color.White;
            lblCurrency.Location = new Point(96, 3);
            lblCurrency.Name = "lblCurrency";
            lblCurrency.Size = new Size(93, 25);
            lblCurrency.TabIndex = 4;
            lblCurrency.Text = "Currency";
            // 
            // txtAmountToConvert
            // 
            txtAmountToConvert.BackColor = Color.FromArgb(32, 32, 32);
            txtAmountToConvert.BorderStyle = BorderStyle.None;
            txtAmountToConvert.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmountToConvert.ForeColor = Color.White;
            txtAmountToConvert.Location = new Point(35, 67);
            txtAmountToConvert.MaxLength = 15;
            txtAmountToConvert.Name = "txtAmountToConvert";
            txtAmountToConvert.ReadOnly = true;
            txtAmountToConvert.Size = new Size(242, 28);
            txtAmountToConvert.TabIndex = 5;
            txtAmountToConvert.TabStop = false;
            txtAmountToConvert.Text = "0";
            txtAmountToConvert.TextChanged += txtAmountToConvert_TextChanged;
            // 
            // txtAmountConverted
            // 
            txtAmountConverted.BackColor = Color.FromArgb(32, 32, 32);
            txtAmountConverted.BorderStyle = BorderStyle.None;
            txtAmountConverted.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            txtAmountConverted.ForeColor = Color.White;
            txtAmountConverted.Location = new Point(36, 161);
            txtAmountConverted.MaxLength = 15;
            txtAmountConverted.Name = "txtAmountConverted";
            txtAmountConverted.ReadOnly = true;
            txtAmountConverted.Size = new Size(241, 28);
            txtAmountConverted.TabIndex = 6;
            txtAmountConverted.TabStop = false;
            txtAmountConverted.Text = "0";
            // 
            // btnSideBar
            // 
            btnSideBar.FlatAppearance.BorderSize = 0;
            btnSideBar.FlatStyle = FlatStyle.Flat;
            btnSideBar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideBar.ForeColor = Color.White;
            btnSideBar.Location = new Point(12, 3);
            btnSideBar.Name = "btnSideBar";
            btnSideBar.Size = new Size(78, 45);
            btnSideBar.TabIndex = 28;
            btnSideBar.Text = "≡";
            btnSideBar.UseVisualStyleBackColor = true;
            btnSideBar.Click += btnSideBar_Click;
            // 
            // btnZero
            // 
            btnZero.BackColor = Color.FromArgb(59, 59, 59);
            btnZero.FlatAppearance.BorderSize = 0;
            btnZero.FlatStyle = FlatStyle.Flat;
            btnZero.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnZero.ForeColor = Color.White;
            btnZero.Location = new Point(107, 417);
            btnZero.Name = "btnZero";
            btnZero.Size = new Size(82, 36);
            btnZero.TabIndex = 29;
            btnZero.Text = "0";
            btnZero.UseVisualStyleBackColor = false;
            btnZero.Click += btnZero_Click;
            // 
            // btnNine
            // 
            btnNine.BackColor = Color.FromArgb(59, 59, 59);
            btnNine.FlatAppearance.BorderSize = 0;
            btnNine.FlatStyle = FlatStyle.Flat;
            btnNine.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnNine.ForeColor = Color.White;
            btnNine.Location = new Point(107, 291);
            btnNine.Name = "btnNine";
            btnNine.Size = new Size(82, 36);
            btnNine.TabIndex = 30;
            btnNine.Text = "9";
            btnNine.UseVisualStyleBackColor = false;
            btnNine.Click += btnNine_Click;
            // 
            // btnEight
            // 
            btnEight.BackColor = Color.FromArgb(59, 59, 59);
            btnEight.FlatAppearance.BorderSize = 0;
            btnEight.FlatStyle = FlatStyle.Flat;
            btnEight.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnEight.ForeColor = Color.White;
            btnEight.Location = new Point(22, 291);
            btnEight.Name = "btnEight";
            btnEight.Size = new Size(82, 36);
            btnEight.TabIndex = 31;
            btnEight.Text = "8";
            btnEight.UseVisualStyleBackColor = false;
            btnEight.Click += btnEight_Click;
            // 
            // btnSeven
            // 
            btnSeven.BackColor = Color.FromArgb(59, 59, 59);
            btnSeven.FlatAppearance.BorderSize = 0;
            btnSeven.FlatStyle = FlatStyle.Flat;
            btnSeven.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSeven.ForeColor = Color.White;
            btnSeven.Location = new Point(195, 333);
            btnSeven.Name = "btnSeven";
            btnSeven.Size = new Size(82, 36);
            btnSeven.TabIndex = 32;
            btnSeven.Text = "7";
            btnSeven.UseVisualStyleBackColor = false;
            btnSeven.Click += btnSeven_Click;
            // 
            // btnSix
            // 
            btnSix.BackColor = Color.FromArgb(59, 59, 59);
            btnSix.FlatAppearance.BorderSize = 0;
            btnSix.FlatStyle = FlatStyle.Flat;
            btnSix.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnSix.ForeColor = Color.White;
            btnSix.Location = new Point(107, 333);
            btnSix.Name = "btnSix";
            btnSix.Size = new Size(82, 36);
            btnSix.TabIndex = 33;
            btnSix.Text = "6";
            btnSix.UseVisualStyleBackColor = false;
            btnSix.Click += btnSix_Click;
            // 
            // btnFive
            // 
            btnFive.BackColor = Color.FromArgb(59, 59, 59);
            btnFive.FlatAppearance.BorderSize = 0;
            btnFive.FlatStyle = FlatStyle.Flat;
            btnFive.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFive.ForeColor = Color.White;
            btnFive.Location = new Point(21, 333);
            btnFive.Name = "btnFive";
            btnFive.Size = new Size(82, 36);
            btnFive.TabIndex = 34;
            btnFive.Text = "5";
            btnFive.UseVisualStyleBackColor = false;
            btnFive.Click += btnFive_Click;
            // 
            // btnFour
            // 
            btnFour.BackColor = Color.FromArgb(59, 59, 59);
            btnFour.FlatAppearance.BorderSize = 0;
            btnFour.FlatStyle = FlatStyle.Flat;
            btnFour.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnFour.ForeColor = Color.White;
            btnFour.Location = new Point(195, 375);
            btnFour.Name = "btnFour";
            btnFour.Size = new Size(82, 36);
            btnFour.TabIndex = 35;
            btnFour.Text = "4";
            btnFour.UseVisualStyleBackColor = false;
            btnFour.Click += btnFour_Click;
            // 
            // btnThree
            // 
            btnThree.BackColor = Color.FromArgb(59, 59, 59);
            btnThree.FlatAppearance.BorderSize = 0;
            btnThree.FlatStyle = FlatStyle.Flat;
            btnThree.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnThree.ForeColor = Color.White;
            btnThree.Location = new Point(107, 375);
            btnThree.Name = "btnThree";
            btnThree.Size = new Size(82, 36);
            btnThree.TabIndex = 36;
            btnThree.Text = "3";
            btnThree.UseVisualStyleBackColor = false;
            btnThree.Click += btnThree_Click;
            // 
            // btnTwo
            // 
            btnTwo.BackColor = Color.FromArgb(59, 59, 59);
            btnTwo.FlatAppearance.BorderSize = 0;
            btnTwo.FlatStyle = FlatStyle.Flat;
            btnTwo.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnTwo.ForeColor = Color.White;
            btnTwo.Location = new Point(21, 375);
            btnTwo.Name = "btnTwo";
            btnTwo.Size = new Size(82, 36);
            btnTwo.TabIndex = 37;
            btnTwo.Text = "2";
            btnTwo.UseVisualStyleBackColor = false;
            btnTwo.Click += btnTwo_Click;
            // 
            // btnOne
            // 
            btnOne.BackColor = Color.FromArgb(59, 59, 59);
            btnOne.FlatAppearance.BorderSize = 0;
            btnOne.FlatStyle = FlatStyle.Flat;
            btnOne.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnOne.ForeColor = Color.White;
            btnOne.Location = new Point(21, 417);
            btnOne.Name = "btnOne";
            btnOne.Size = new Size(82, 36);
            btnOne.TabIndex = 38;
            btnOne.Text = "1";
            btnOne.UseVisualStyleBackColor = false;
            btnOne.Click += btnOne_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(50, 50, 50);
            btnDelete.FlatAppearance.BorderSize = 0;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = Color.White;
            btnDelete.Location = new Point(195, 291);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(82, 36);
            btnDelete.TabIndex = 39;
            btnDelete.Text = "⌫";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnDecimal
            // 
            btnDecimal.BackColor = Color.FromArgb(59, 59, 59);
            btnDecimal.FlatAppearance.BorderSize = 0;
            btnDecimal.FlatStyle = FlatStyle.Flat;
            btnDecimal.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point);
            btnDecimal.ForeColor = Color.White;
            btnDecimal.Location = new Point(195, 417);
            btnDecimal.Name = "btnDecimal";
            btnDecimal.Size = new Size(82, 36);
            btnDecimal.TabIndex = 40;
            btnDecimal.Text = ".";
            btnDecimal.UseVisualStyleBackColor = false;
            btnDecimal.Click += btnDecimal_Click;
            // 
            // lblLastUpdated
            // 
            lblLastUpdated.AutoSize = true;
            lblLastUpdated.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblLastUpdated.ForeColor = Color.White;
            lblLastUpdated.Location = new Point(156, 208);
            lblLastUpdated.Name = "lblLastUpdated";
            lblLastUpdated.Size = new Size(120, 21);
            lblLastUpdated.TabIndex = 41;
            lblLastUpdated.Text = "Fri, 10 Jan 2025";
            // 
            // Currency
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(lblLastUpdated);
            Controls.Add(btnDecimal);
            Controls.Add(btnDelete);
            Controls.Add(btnOne);
            Controls.Add(btnTwo);
            Controls.Add(btnThree);
            Controls.Add(btnFour);
            Controls.Add(btnFive);
            Controls.Add(btnSix);
            Controls.Add(btnSeven);
            Controls.Add(btnEight);
            Controls.Add(btnNine);
            Controls.Add(btnZero);
            Controls.Add(btnSideBar);
            Controls.Add(txtAmountConverted);
            Controls.Add(txtAmountToConvert);
            Controls.Add(lblCurrency);
            Controls.Add(lblConversionRate);
            Controls.Add(cmbToCurrency);
            Controls.Add(cmbFromCurrency);
            Name = "Currency";
            Size = new Size(300, 463);
            Load += Currency_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbFromCurrency;
        private ComboBox cmbToCurrency;
        private Label lblConversionRate;
        private Label lblCurrency;
        private TextBox txtAmountToConvert;
        private TextBox txtAmountConverted;
        private Button btnSideBar;
        private Button btnZero;
        private Button btnNine;
        private Button btnEight;
        private Button btnSeven;
        private Button btnSix;
        private Button btnFive;
        private Button btnFour;
        private Button btnThree;
        private Button btnTwo;
        private Button btnOne;
        private Button btnDelete;
        private Button btnDecimal;
        private Label lblLastUpdated;
    }
}
