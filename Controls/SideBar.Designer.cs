namespace CalculatorProject.Controls
{
    partial class SideBar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SideBar));
            btnStandard = new Button();
            btnScientific = new Button();
            lblCalculator = new Label();
            btnSettings = new Button();
            btnSideBar = new Button();
            lblConversions = new Label();
            btnCurrency = new Button();
            SuspendLayout();
            // 
            // btnStandard
            // 
            btnStandard.FlatAppearance.BorderSize = 0;
            btnStandard.FlatStyle = FlatStyle.Flat;
            btnStandard.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnStandard.ForeColor = Color.White;
            btnStandard.Image = (Image)resources.GetObject("btnStandard.Image");
            btnStandard.Location = new Point(0, 73);
            btnStandard.Name = "btnStandard";
            btnStandard.Size = new Size(370, 40);
            btnStandard.TabIndex = 0;
            btnStandard.Text = "Standard";
            btnStandard.TextAlign = ContentAlignment.MiddleLeft;
            btnStandard.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnStandard.UseVisualStyleBackColor = false;
            btnStandard.Click += btnStandard_Click;
            // 
            // btnScientific
            // 
            btnScientific.FlatAppearance.BorderSize = 0;
            btnScientific.FlatStyle = FlatStyle.Flat;
            btnScientific.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnScientific.ForeColor = Color.White;
            btnScientific.Image = (Image)resources.GetObject("btnScientific.Image");
            btnScientific.Location = new Point(0, 119);
            btnScientific.Name = "btnScientific";
            btnScientific.Size = new Size(370, 40);
            btnScientific.TabIndex = 1;
            btnScientific.Text = "Scientific";
            btnScientific.TextAlign = ContentAlignment.MiddleLeft;
            btnScientific.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnScientific.UseVisualStyleBackColor = false;
            btnScientific.Click += btnScientific_Click;
            // 
            // lblCalculator
            // 
            lblCalculator.AutoSize = true;
            lblCalculator.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblCalculator.ForeColor = Color.White;
            lblCalculator.Location = new Point(100, 17);
            lblCalculator.Name = "lblCalculator";
            lblCalculator.Size = new Size(102, 25);
            lblCalculator.TabIndex = 2;
            lblCalculator.Text = "Calculator";
            // 
            // btnSettings
            // 
            btnSettings.FlatAppearance.BorderSize = 0;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSettings.ForeColor = Color.White;
            btnSettings.Image = (Image)resources.GetObject("btnSettings.Image");
            btnSettings.Location = new Point(0, 433);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(370, 40);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            btnSettings.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSettings.UseVisualStyleBackColor = false;
            btnSettings.Click += btnSettings_Click;
            // 
            // btnSideBar
            // 
            btnSideBar.FlatAppearance.BorderSize = 0;
            btnSideBar.FlatStyle = FlatStyle.Flat;
            btnSideBar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            btnSideBar.ForeColor = Color.White;
            btnSideBar.Location = new Point(3, 3);
            btnSideBar.Name = "btnSideBar";
            btnSideBar.Size = new Size(78, 45);
            btnSideBar.TabIndex = 26;
            btnSideBar.Text = "≡";
            btnSideBar.UseVisualStyleBackColor = true;
            btnSideBar.Click += btnSideBar_Click;
            // 
            // lblConversions
            // 
            lblConversions.AutoSize = true;
            lblConversions.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            lblConversions.ForeColor = Color.White;
            lblConversions.Location = new Point(100, 192);
            lblConversions.Name = "lblConversions";
            lblConversions.Size = new Size(121, 25);
            lblConversions.TabIndex = 27;
            lblConversions.Text = "Conversions";
            // 
            // btnCurrency
            // 
            btnCurrency.FlatAppearance.BorderSize = 0;
            btnCurrency.FlatStyle = FlatStyle.Flat;
            btnCurrency.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnCurrency.ForeColor = Color.White;
            btnCurrency.Image = (Image)resources.GetObject("btnCurrency.Image");
            btnCurrency.Location = new Point(0, 246);
            btnCurrency.Name = "btnCurrency";
            btnCurrency.Size = new Size(370, 40);
            btnCurrency.TabIndex = 28;
            btnCurrency.Text = "Currency";
            btnCurrency.TextAlign = ContentAlignment.MiddleLeft;
            btnCurrency.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCurrency.UseVisualStyleBackColor = false;
            btnCurrency.Click += btnCurrency_Click;
            // 
            // SideBar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(32, 32, 32);
            Controls.Add(btnCurrency);
            Controls.Add(lblConversions);
            Controls.Add(btnSideBar);
            Controls.Add(btnSettings);
            Controls.Add(lblCalculator);
            Controls.Add(btnScientific);
            Controls.Add(btnStandard);
            DoubleBuffered = true;
            MaximumSize = new Size(370, 462);
            MinimumSize = new Size(0, 532);
            Name = "SideBar";
            Size = new Size(370, 532);
            Load += SideBar_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnStandard;
        private Button btnScientific;
        private Label lblCalculator;
        private Button btnSettings;
        private Button btnSideBar;
        private Label lblConversions;
        private Button btnCurrency;
    }
}
